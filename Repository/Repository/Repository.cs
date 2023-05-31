using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Assistant.Repository.Repository;
using Assistant.Utils;
using Npgsql;

namespace Repository.Repository
{
    public partial class Repository
    {
        public readonly string StoredProcList;
        public readonly string StoredProcLoad;
        public readonly string StoredProcSave;
        public readonly string StoredProcDelete;
        public readonly string StoredProcFind;
        public readonly string UdtTable;
        public readonly string ObjectName;

        public Repository(string objectName)
        {
            StoredProcList = string.Format("{0}_list", objectName);
            StoredProcLoad = string.Format("{0}_load", objectName);
            StoredProcSave = string.Format("{0}_save", objectName);
            StoredProcDelete = string.Format("{0}_delete", objectName);
            StoredProcFind = string.Format("{0}_find", objectName);
            UdtTable = string.Format("udt_{0}", objectName);
            ObjectName = objectName;
        }

        /// <summary>
        /// Проверка, есть ли данная функция в БД
        /// </summary>
        /// <param name="procName">Название функции</param>
        /// <returns></returns>
        public static bool CheckProcName(string procName)
        {
            if (GetProcExistsRepository.FindProc(procName)) return true;

            LogUtils.GetLogMessageSeans(string.Format("Не найдена хранимая процедура '{0}'", procName));
            LogUtils.GetLogMessageSeansUpdate(string.Format("Не найдена хранимая процедура '{0}'", procName));
            TempValue.GetMessageError(string.Format("Не найдена хранимая процедура '{0}'", procName));
            return false;
        }

        /// <summary>
        /// Проверка, выполнилась ли функция 
        /// </summary>
        /// <param name="procName">Название функции</param>
        public static void CheckExecuteProc(string procName)
        {
            LogUtils.GetLogMessageSeans(string.Format("Процедура '{0}' не выполнилась", procName));
            LogUtils.GetLogMessageSeansUpdate(string.Format("Процедура '{0}' не выполнилась", procName));
        }

        /// <summary>
        /// Загрузка данных по фильтру
        /// </summary>
        /// <param name="filter">фильтр</param>
        /// <returns></returns>
        public virtual SqlCommand List(string filter)
        {
            return StoredProcList.GetListProcedure(filter).Query();
            //return !CheckProcName(StoredProcList) ? null : StoredProcList.GetListProcedure(filter).Query();
        }

        /// <summary>
        /// Загрузка данных по ключу
        /// </summary>
        /// <param name="guid">индитификатор</param>
        /// <returns></returns>
        public virtual SqlCommand Load(Guid guid)
        {
            return !CheckProcName(StoredProcLoad) ? null : StoredProcLoad.GetLoadProcedure().Query().Params("@guid", guid);
        }

        /// <summary>
        /// Сохранение данных в БД
        /// </summary>
        /// <param name="items">Данные</param>
        /// <param name="isNew">Тип сохранения: true - новые, false - изменяемые</param>
        public virtual void Save(dynamic items, bool isNew)
        {
            //if (!CheckProcName(StoredProcSave)) return;
            string sqlText = GetSqlText(items, StoredProcSave);

            sqlText.Query().Exec();

            LogUtils.SaveUpdateLog(sqlText, isNew);

        }

        /// <summary>
        /// Удаление данных из БД
        /// </summary>
        /// <param name="items">Данные</param>
        public virtual void Delete(dynamic items)
        {
            if (!CheckProcName(StoredProcDelete)) return;

            string sqlText = GetSqlText(items, StoredProcDelete);

            var arr = sqlText.Query().ToArray();
            if (arr.Length == 0)
            {
                CheckExecuteProc(StoredProcDelete);
            }
            LogUtils.SaveDeleteLog(sqlText);
        }

        /// <summary>
        /// Нахождение данных
        /// </summary>
        /// <param name="items">данные для поиска</param>
        /// <returns></returns>
        public virtual SqlCommand Find(dynamic items)
        {
            if (!CheckProcName(StoredProcFind)) return null;
            string sqlText = GetSqlText(items, StoredProcFind);
            return sqlText.Query();
        }

        /// <summary>
        /// Получение текста запроса
        /// </summary>
        /// <param name="items">Данные</param>
        /// <param name="nameProcedure">Название процедуры</param>
        /// <returns></returns>
        public virtual dynamic GetSqlText(dynamic items, string nameProcedure)
        {
            return GetInsertUdtSql(items) + nameProcedure.GetProcedure() + UdtTable.GetClearUdtProc();
        }

        /// <summary>
        /// Получение Udt полей
        /// </summary>
        /// <returns></returns>
        public virtual dynamic[] GetUdtField()
        {
            return UdtTable.ListColumn();
        }

        /// <summary>
        /// Создание запроса по данным на добавление в Udt
        /// </summary>
        /// <param name="items">список</param>
        /// <returns>Возвращает запрос для записи в БД в udt таблицу</returns>
        public virtual object GetInsertUdtSql(dynamic items)
        {
            var strSql = string.Empty;
            var arr = GetUdtField();
            foreach (IDictionary<string, object> item in items)
            {
                var strField = string.Empty;
                var strData = string.Empty;
                foreach (KeyValuePair<string, object> o in from o in item from o1 in arr.Where(o1 => o1.column_name == o.Key) select o)
                {
                    strField = strField.GetListKey(o.Key);
                    strData = strData.GetListValue(o.Value);
                }
                strSql += BuildSql.GetInsertUdt(UdtTable, strField, strData);
            }
            return strSql;
        }
    }
}
