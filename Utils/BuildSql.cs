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
            return string.Format(" exec {0}" + "\r\n", procedureName);
        }

        /// <summary>
        /// Получение функции загрузки таблицы по фильтру
        /// </summary>
        /// <param name="procedureName">Название процедуры</param>
        /// <param name="filter">Фильтр</param>
        /// <returns></returns>
        public static string GetListProcedure(this string procedureName, string filter)
        {
            return string.Format("exec {0} '{1}'" + "\r\n", procedureName, filter);
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

    }
}
