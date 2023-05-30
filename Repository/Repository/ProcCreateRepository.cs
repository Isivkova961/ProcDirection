using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assistant.Utils;

namespace Assistant.Repository.Repository
{
    public static partial class ProcCreateRepository
    {
        public static dynamic[] ListColumn(this string tableName)
        {
            return
                "SELECT * FROM column_find (@table_name)".Query()
                    .Params("@table_name", tableName)
                    .ToArray();
        }

        /// <summary>
        /// Находение ключей по назваванию таблицы
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static dynamic[] ListConstraint(string tableName)
        {
            return
                "SELECT * FROM constraint_find(@table_name)".Query()
                    .Params("@table_name", tableName)
                    .ToArray();
        }

        /// <summary>
        /// Отображение списка всех клучей в БД
        /// </summary>
        /// <returns></returns>
        public static dynamic[] ListConstraintAll()
        {
            return "SELECT * FROM constraint_all()".Query().ToArray();
        }

        /// <summary>
        /// Нахождение всех процедур, которые нужно удалить в системе
        /// </summary>
        /// <returns></returns>
        public static dynamic[] ListProc()
        {
            var cmd =
                "SELECT proname, proargtypes FROM pg_proc WHERE pronamespace = 2200 AND proargnames IS NOT NULL " +
                "AND (proname LIKE '%delete%' OR proname LIKE '%restore%' OR proname like '%update%' OR proname LIKE '%inserte%' " +
                "OR proname LIKE '%find%')";
            return
                cmd.Query()
                    .ToArray();
        }

        /// <summary>
        /// Список типов данных по переданому коду
        /// </summary>
        /// <param name="typeArr">Коды через запятую</param>
        /// <returns></returns>
        public static dynamic[] ListTypeData(string typeArr)
        {
            return
                string.Format("SELECT typname, typelem FROM pg_type WHERE typelem IN ({0})", typeArr).Query().ToArray();
        }
    }
}
