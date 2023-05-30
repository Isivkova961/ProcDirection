using System.Data;
using System.Linq;
using System.Windows.Forms;
using Assistant.Repository.Repository.Grid;
using Assistant.Utils;

namespace Assistant.Repository
{
    /// <summary>
    /// Класс работы с гридом
    /// </summary>
    public static class GridUtils
    {
        /// <summary>
        /// Получение заголовков для таблицы
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static dynamic[] ToGridHeader(string tableName)
        {
            var repo = new GridItemRepository();
            return repo.Find(tableName).ToArray(); ;
        }

        /// <summary>
        /// Заполнение заголовков таблицы
        /// </summary>
        /// <param name="dgv">Грид</param>
        /// <param name="ds">Данные</param>
        /// <param name="tableName">Название таблицы</param>
        public static void TuneColumns(this DataGridView dgv, DataSet ds, string tableName)
        {
            if (ds == null) return;
            if (ds.Tables.Count == 0) return;
            dgv.DataSource = ds.Tables[0];
            GetHeader(dgv, tableName);
        }

        /// <summary>
        /// Заполнение заголовков таблицы на основе массива
        /// </summary>
        /// <param name="dgv">грид</param>
        /// <param name="dataSet">массив</param>
        /// <param name="tableName">Название таблицы</param>
        public static void ArrayTuneColumns(this DataGridView dgv, dynamic dataSet, string tableName)
        {
            dgv.DataSource = dataSet;
            for (var i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Visible = false;
            }
            GetHeader(dgv, tableName);
        }

        public static void GetHeader(this DataGridView dgv, string tableName)
        {
            var headers = ToGridHeader(tableName);
            foreach (var header in headers.Where(header => dgv.Columns.Contains(header.name)))
            {
                dgv.Columns[header.name].Visible = header.is_visible;
                dgv.Columns[header.name].HeaderText = header.text_column;
            }
        }


    }
}
