using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assistant.Utils
{
    /// <summary>
    /// Класс, в котором храняться стандартные названия для файлов
    /// </summary>
    public static class TempValue
    {
        public static string UserFileNameLog;
        public static DateTime DateNow = DateTime.Now;
        public static string TypeUpdatedBd;
        public static string UserName;
        public static string DirectoryExe = System.IO.Directory.GetCurrentDirectory();
        public static string PathSettingLoggin = DirectoryExe + "\\Setting.dat";
        public static string PathImport = DirectoryExe + "\\import";
        public static string VersionProgram;

        public static string PathSql = @"..\..\..\SqlScript\Clishe_sql\table.sql";
        public static string PathStructSql = @"..\..\..\SqlScript\Clishe_sql\struct_clishe.sql";
        public static string PathUdtSql = @"..\..\..\SqlScript\Clishe_sql\udt_clishe.sql";
        public static string PathStruct = @"..\..\..\SqlScript\Structure\struct.sql";
        public static string PathUdtt = @"..\..\..\SqlScript\Structure\udtt.sql";
        public static string PathAuto = @"..\..\..\SqlScript\Auto\";

        /// <summary>
        /// Получение название файла пользователя для лога
        /// </summary>
        /// <returns>Возвращает название файла Имя компьютера_Имя пользователя_Дата</returns>
        public static string GetUserFileNameLog()
        {
            return LogUtils.Host + "_" + UserName + "_" + DateNow;
        }

        public static string GetGender(ComboBox cobGender)
        {
            return cobGender.SelectedIndex == -1 ? "" : (cobGender.Text == "Мужской") ? "М" : "Ж";
        }

        public static string GetGenderData(this string gender)
        {
            return (gender == "М") ? "Мужской" : (gender == "Ж") ? "Женский" : "";
        }

        public static string GetVersionUser()
        {
            return string.Format("Профосмотры 302н версия {0}. Пользователь: {1}", VersionProgram, UserName);
        }

        public static void GetMessageError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool GetMessageDelete()
        {
            return
                (MessageBox.Show("Вы точно хотите удалить запись?", "Сообщение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) !=
                 DialogResult.Yes);
        }

        public static bool GetMessageDelete(string message)
        {
            return (MessageBox.Show(message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes);
        }

        public static void GetMessageOk(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Добавить данные в список
        /// </summary>
        /// <param name="item">Параметры</param>
        /// <param name="typeUpdate">Если typeUpdate = true - Inserted, Updated, false - Deleted</param>
        public static dynamic InsertModelData(dynamic item, bool typeUpdate)
        {
            if (typeUpdate)
            {
                item.inserted = DateNow;
                item.updated = DateNow;
            }
            else
            {
                item.deleted = DateNow;
            }
            return item;
        }

        public static string GetNameReport(this string nameReport)
        {
            return $"CheckupReport.Report.{nameReport}.report.rdlc";
        }

        public static string GetClass(this string tableName)
        {
            return "f" + StringUtils.GetNameColumn(tableName, true) + "s";
            //AppendixUtils.GetNameSpaces();
            //var data = AppendixUtils.TypeFormDatas.FirstOrDefault(x => x.NameTable == tableName);
            //return data != null ? string.Format("{0}.{1}", data.NameSpace, data.NameForm) : "";
        }


    }
}
