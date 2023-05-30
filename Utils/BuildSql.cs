using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assistant.Utils
{
    public static class BuildSql
    {

        /// <summary>
        /// Получение типов полей
        /// </summary>
        /// <param name="arr">Массив данных</param>
        /// <param name="typeProc">Тип процедуры</param>
        /// <param name="typeData">Тип данных</param>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static string GetColumnType(dynamic[] arr, string typeProc, bool typeData, string tableName)
        {
            if (arr.Length == 0) return null;
            var str = "";
            var strDataUpdate = "";
            foreach (var o in arr)
            {
                var bData = true;
                if (typeProc == "Inserted" || typeProc == "InsertedData")
                    if (o.column_name == "updated" || o.column_name == "deleted" || o.column_name == "id") bData = false;
                if (typeProc == "Updated" || typeProc == "UpdatedData")
                    if (o.column_name == "inserted" || o.column_name == "deleted" || o.column_name == "id" || (o.column_name == "guid" && typeProc == "UpdatedData")) bData = false;
                if (bData)
                {
                    str += o.column_name;
                    strDataUpdate += o.column_name + "=" + "udt_" + tableName + "." + o.column_name + ",";
                    if (typeData)
                    {
                        str += " " + o.data_type;
                        if (o.data_type == "character varying")
                            str += "(" + o.character_maximum_length.ToString() + ")";
                    }
                    str += ",";
                }
            }
            str = str.Remove(str.Length - 1);
            strDataUpdate = strDataUpdate.Remove(strDataUpdate.Length - 1);
            if (typeProc == "UpdatedData")
                return strDataUpdate;

            return str;

        }

        /// <summary>
        /// Получение struct
        /// </summary>
        /// <param name="arr">массив данных</param>
        /// <param name="isUdt">Флаг udt</param>
        /// <returns></returns>
        public static string GetStructField(dynamic[] arr, bool isUdt)
        {
            var str = string.Empty;
            var columnLastName = arr[arr.Length - 1].column_name;
            foreach (var o in arr)
            {
                if (o.column_name != "id")
                {
                    str += o.column_name;
                    str += " " + o.data_type;
                    if (o.data_type == "character varying")
                        str += "(" + o.character_maximum_length.ToString() + ")";
                    if (o.is_nullable == "NO" && !isUdt)
                        str += " NOT NULL";
                    if (o.column_default != null)
                        str += " DEFAULT " + o.column_default;
                }
                else if (!isUdt)
                {
                    str += "id serial NOT NULL";
                }
                if (str != string.Empty && ((isUdt && o.column_name != columnLastName && o.column_name != "id") || !isUdt)) str += "," + "\r\n";
            }
            return str;
        }

        /// <summary>
        /// Получение struct
        /// </summary>
        /// <param name="fieldList">Данные</param>
        /// <param name="o">массив данных</param>
        /// <param name="isUdt">Флаг udt</param>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static string GetStructField(this string fieldList, dynamic o, bool isUdt, string tableName)
        {
            if (fieldList.Length > 0) fieldList += ",";

            fieldList += "\r\n" + o.nameColumn + " " + o.typeField;

            if (o.sizeField > 0) fieldList += "(" + o.sizeField.ToString() + ")";
            if (o.isNotNull && !isUdt) fieldList += " NOT NULL";
            if (o.defaultData != "" && o.defaultData != null && !isUdt) fieldList += " DEFAULT " + o.defaultData;

            return fieldList;
        }

        /// <summary>
        /// Получение ключей
        /// </summary>
        /// <param name="arr">массив данных</param>
        /// <returns></returns>
        public static string GetConstraint(dynamic[] arr)
        {
            var str = string.Empty;
            foreach (var o in arr)
            {
                if (o.per_forec_key == null)
                {
                    str += string.Format("CONSTRAINT {0} PRIMARY KEY ({1})", o.per_const_name, o.per_column_name);
                }
                else
                {
                    str += string.Format("\r\n" + "CONSTRAINT {0} FOREIGN KEY ({1})" + "\r\n", o.per_const_name,
                        o.per_column_name);
                    str += string.Format("REFERENCES public.{0} ({1}) MATCH SIMPLE" + "\r\n", o.forec_table_name,
                        o.forec_column_name);
                    str += "ON UPDATE NO ACTION ON DELETE NO ACTION";
                }
                str += ",";
            }
            return StringUtils.RemoveLastSymbol(str);
        }

        /// <summary>
        /// Получение ключей
        /// </summary>
        /// <param name="o">массив данных</param>
        /// <param name="tableName">таблица</param>
        /// <returns></returns>
        public static string GetConstraint(dynamic o, string tableName)
        {
            var str = string.Empty;
            if (o.isPk)
            {
                str += string.Format("\r\n" + "CONSTRAINT {0} PRIMARY KEY ({1})", "pk_" + tableName,
                    o.nameColumn);
            }
            if (o.isFk)
            {
                str += string.Format("," + "\r\n" + "CONSTRAINT {0} FOREIGN KEY ({1})" + "\r\n",
                    "fk_" + o.fkName + "$" + tableName, o.nameColumn);
                str += string.Format("REFERENCES public.{0}(guid) MATCH SIMPLE" + "\r\n", o.fkName);
                str += "ON UPDATE NO ACTION ON DELETE NO ACTION";
            }
            str += ",";
            return StringUtils.RemoveLastSymbol(str);
        }

        /// <summary>
        /// Получение списка полей
        /// </summary>
        /// <param name="arr">массив данных</param>
        /// <returns></returns>
        public static string GetAddColumns(dynamic[] arr)
        {
            var str = string.Empty;
            foreach (var o in arr)
            {
                str += string.Format("IF (SELECT * FROM column_id('{0}','{1}')) IS NULL then" + "\r\n", o.table_name,
                    o.column_name);
                str += string.Format("ALTER TABLE public.{0}" + "\r\n", o.table_name);
                str += "ADD COLUMN ";
                if (o.column_name != "id")
                {
                    str += o.column_name;
                    str += " " + o.data_type;
                    if (o.data_type == "character varying")
                        str += "(" + o.character_maximum_length.ToString() + ")";
                    if (o.is_nullable == "NO")
                        str += " NOT NULL";
                    if (o.column_default != null)
                        str += " DEFAULT " + o.column_default;
                }
                else
                {
                    str += "id serial NOT NULL";
                }
                str += ";" + "\r\n" + "end if;" + "\r\n";
            }
            return str;
        }

        /// <summary>
        /// Получение списка полей
        /// </summary>
        /// <param name="o">массив данных</param>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static string GetAddColumns(dynamic o, string tableName)
        {
            var str = string.Empty;

            str += string.Format("IF (SELECT * FROM column_id('{0}','{1}')) IS NULL then" + "\r\n", tableName,
                o.nameColumn);
            str += string.Format("ALTER TABLE public.{0}" + "\r\n", tableName);
            str += "ADD COLUMN ";

            str += o.nameColumn + " " + o.typeField;
            if (o.sizeField > 0) str += "(" + o.sizeField.ToString() + ") ";
            if (o.isNotNull) str += " NOT NULL";
            if (o.defaultData != "" && o.defaultData != null) str += " DEFAULT " + o.defaultData;
            str += ";" + "\r\n" + "end if;" + "\r\n";

            return str;
        }

        /// <summary>
        /// Получение списка ключей
        /// </summary>
        /// <param name="arr">массив данных</param>
        /// <returns></returns>
        public static string GetAddConstraint(dynamic[] arr)
        {
            var str = string.Empty;
            foreach (var o in arr)
            {
                str += string.Format("IF (SELECT * FROM constraint_id('{0}')) IS NULL then" + "\r\n", o.per_const_name);
                str += string.Format("ALTER TABLE public.{0}" + "\r\n", o.per_table_name);
                if (o.per_forec_key == null)
                {
                    str += string.Format("ADD CONSTRAINT {0} PRIMARY KEY ({1})", o.per_const_name, o.per_column_name);
                }
                else
                {
                    str += string.Format("ADD CONSTRAINT {0} FOREIGN KEY ({1})" + "\r\n", o.per_const_name,
                        o.per_column_name);
                    str += string.Format("REFERENCES public.{0} ({1}) MATCH SIMPLE" + "\r\n", o.forec_table_name,
                        o.forec_column_name);
                    str += "ON UPDATE NO ACTION ON DELETE NO ACTION";
                }
                str += ";" + "\r\n" + "end if;" + "\r\n";
            }
            return StringUtils.RemoveLastSymbol(str);
        }

        /// <summary>
        /// Получение списка ключей
        /// </summary>
        /// <param name="o">массив данных</param>
        /// <param name="tableName">Таблица</param>
        /// <returns></returns>
        public static string GetAddConstraint(dynamic o, string tableName)
        {
            var str = string.Empty;

            if (o.isPk)
            {
                str += string.Format("IF (SELECT * FROM constraint_id('{0}')) IS NULL then" + "\r\n", "pk_" + tableName);
                str += string.Format("ALTER TABLE public.{0}" + "\r\n", tableName);
                str += string.Format("ADD CONSTRAINT {0} PRIMARY KEY ({1})", "pk_" + tableName, o.nameColumn);
            }
            if (o.isFk)
            {
                str += string.Format("IF (SELECT * FROM constraint_id('{0}')) IS NULL then" + "\r\n",
                    "fk_" + o.fkName + "$" + tableName);
                str += string.Format("ALTER TABLE public.{0}" + "\r\n", tableName);
                str += string.Format("ADD CONSTRAINT {0} FOREIGN KEY ({1})" + "\r\n", "fk_" + o.fkName + "$" + tableName,
                    o.nameColumn);
                str += string.Format("REFERENCES public.{0}(guid) MATCH SIMPLE" + "\r\n", o.fkName);
                str += "ON UPDATE NO ACTION ON DELETE NO ACTION";
            }
            str += ";" + "\r\n" + "end if;" + "\r\n";
            
            return StringUtils.RemoveLastSymbol(str);
        }

        /// <summary>
        /// Проверка есть ли такая таблица в структуре
        /// </summary>
        /// <param name="str">Строка структуры</param>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static bool IsTableStruct(string str, string tableName)
        {
            var strBegin = string.Format("-------------------------------------------------------------------" + "\r\n" + "-- {0} --", tableName);
            var indexBegin = str.IndexOf(strBegin);

            return indexBegin > -1;
        }

        /// <summary>
        /// Получение данных для замены в структуре
        /// </summary>
        /// <param name="str">Строка структуры</param>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static string GetPlaceTable(string str, string tableName)
        {
            var strBegin = string.Format("-------------------------------------------------------------------" + "\r\n" + "-- {0} --", tableName);
            var strEnd = string.Format("ALTER TABLE public.{0}" + "\r\n" + "  OWNER TO postgres;", tableName);
            var indexBegin = str.IndexOf(strBegin);
            var indexEnd = str.IndexOf(strEnd);
            var lengthStr = strEnd.Length;

            if (indexBegin > -1 && indexEnd > -1)
            {
                str = str.Remove(indexBegin, indexEnd + lengthStr - indexBegin);
                str = str.Insert(indexBegin, "/*table_ins*/");
            }

            return str;
        }


        /// <summary>
        /// Чтение из файла
        /// </summary>
        /// <param name="path">Путь</param>
        /// <returns></returns>
        public static string ReaderFile(string path)
        {
            var str = string.Empty;
            using (var reader = File.OpenText(path))
            {
                str = reader.ReadToEnd();
            }
            return str;
        }

        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="path">Путь</param>
        /// <param name="isNewFile">Флаг дозаписи</param>
        /// <param name="dataWriter">Данные для записи</param>
        public static void WriterFile(string path, bool isNewFile, string dataWriter, Encoding encoding = null)
        {
            if (encoding == null) encoding = Encoding.ASCII;
            using (var sw = new StreamWriter(path, isNewFile, encoding))
            {
                sw.WriteLine(dataWriter);
                sw.Close();
            }
        }

        /// <summary>
        /// Проверка типа поля
        /// </summary>
        /// <param name="value">Поле</param>
        /// <returns></returns>
        public static bool isQuotes(object value)
        {
            if (value.GetType() == typeof(Int64)) return false;
            if (value.GetType() == typeof(Guid)) return true;
            if (value.GetType() == typeof(DateTime)) return true;
            if (value.GetType() == typeof(string)) return true;
            if (value.GetType() == typeof(bool)) return false;

            return false;
        }

        /// <summary>
        /// Получение полей
        /// </summary>
        /// <param name="value">Данные</param>
        /// <returns></returns>
        public static string GetFields(object value)
        {
            return value == null ? "null" : string.Format((isQuotes(value) ? "'{0}'" : "{0}"), value);
        }

        /// <summary>
        /// Получение функции добавления в udt
        /// </summary>
        /// <param name="udtTable">Название udt таблицы</param>
        /// <param name="strField">Поля</param>
        /// <param name="strData">Данные</param>
        /// <returns></returns>
        public static string GetInsertUdt(string udtTable, string strField, string strData)
        {
            return string.Format("INSERT INTO {0} ({1}) VALUES ({2});" + "\r\n", udtTable, strField, strData);
        }

        /// <summary>
        /// Получение списка ключей
        /// </summary>
        /// <param name="strField">Строка полей</param>
        /// <param name="key">Ключ</param>
        /// <returns></returns>
        public static string GetListKey(this string strField, string key)
        {
            return strField.GetListString(key);
        }

        /// <summary>
        /// Получение списка переменных для вывода в запрос
        /// </summary>
        /// <param name="strData">Строка</param>
        /// <param name="value">Данные</param>
        /// <returns></returns>
        public static string GetListValue(this string strData, object value)
        {
            return strData.GetListString(GetFields(value));
        }

        /// <summary>
        /// Получение списка переменых для вывода проверки в загрузку комиссии
        /// </summary>
        /// <param name="strData">Строка</param>
        /// <param name="value">Данные</param>
        /// <returns></returns>
        public static string GetListValueText(this string strData, object value)
        {
            var data = GetFields(value);
            if (data == "null") data = " ";
            if (data == "False") data = "нет";
            if (data == "True") data = "да";
            return strData.GetListString(data);
        }

        /// <summary>
        /// Получение функции
        /// </summary>
        /// <param name="procedureName">Название процедуры</param>
        /// <returns></returns>
        public static string GetProcedure(this string procedureName)
        {
            return string.Format(" SELECT * FROM {0}();" + "\r\n", procedureName);
        }

        /// <summary>
        /// Получение функции загрузки таблицы по фильтру
        /// </summary>
        /// <param name="procedureName">Название процедуры</param>
        /// <param name="filter">Фильтр</param>
        /// <returns></returns>
        public static string GetListProcedure(this string procedureName, string filter)
        {
            return string.Format("SELECT * FROM {0} ('{1}');" + "\r\n", procedureName, filter);
        }

        /// <summary>
        /// Получение функции загрузки данных по guid
        /// </summary>
        /// <param name="procedureName">Название процедуры</param>
        /// <returns></returns>
        public static string GetLoadProcedure(this string procedureName)
        {
            return string.Format("SELECT * FROM {0}(@guid);" + "\r\n", procedureName);
        }

        /// <summary>
        /// Получение функции очистки udt
        /// </summary>
        /// <param name="udtName">udt таблица</param>
        /// <returns></returns>
        public static string GetClearUdtProc(this string udtName)
        {
            return string.Format("DELETE FROM {0}", udtName);
        }

        /// <summary>
        /// Получение списка полей для ХП
        /// </summary>
        /// <param name="fieldList">Строка из полей</param>
        /// <param name="o">Поле</param>
        /// <param name="isType">Список для вывода таблицы</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns></returns>
        public static string GetFieldList(this string fieldList, dynamic o, bool isType, string tableName)
        {
            if (fieldList.Length > 0)
                fieldList += ",";

            if (isType)
            {
                if (o.typeField == "character varying")
                    fieldList += string.Format("{0} {1}({2})", o.nameColumn, o.typeField, o.sizeField);
                else
                    fieldList += string.Format("{0} {1}", o.nameColumn, o.typeField);
            }
            else
            {
                fieldList += tableName != "" ? string.Format("{0}.{1}", o.isNotTable ? o.fkName : tableName, o.isNotTable ? o.fkColumnName : o.nameColumn) : string.Format("{0}", o.nameColumn);
            }
            return fieldList;
        }

        /// <summary>
        /// Получение списка для изменения данных ХП
        /// </summary>
        /// <param name="updatedList">Строка ХП для изменения данных</param>
        /// <param name="o">Поле</param>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static string GetUpdated(this string updatedList, dynamic o, string tableName)
        {
            if (updatedList.Length > 0)
                updatedList += ",";

            updatedList += string.Format("{0}=udt_{1}.{2}", o.nameColumn, tableName, o.nameColumn);

            return updatedList;
        }
    }
}
