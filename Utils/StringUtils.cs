using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assistant.Utils
{
    public static class StringUtils
    {
        /// <summary>
        /// Удаление последнего символа в строке
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns></returns>
        public static string RemoveLastSymbol(string str)
        {
            return str != "" ? str.Remove(str.Length - 1, 1) : str;
        }

        /// <summary>
        /// Получение возраста
        /// </summary>
        /// <param name="dateOfBirth">Дата рождения</param>
        /// <param name="dateAsAt">Дата от которой считаем</param>
        /// <returns></returns>
        public static int GetAge(this DateTime dateOfBirth, DateTime dateAsAt)
        {
            return dateAsAt.Year - dateOfBirth.Year - (dateOfBirth.DayOfYear < dateAsAt.DayOfYear ? 0 : 1);
        }

        /// <summary>
        /// Проверка в строке цифр
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns></returns>
        public static bool IsDigitsOnly(string str)
        {
            return str.All(c => (c >= '0' && c <= '9') || c == ',');
        }

        /// <summary>
        /// Получение ФИО
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronymic">Отчетство</param>
        /// <param name="dateBirth">Дата рождения</param>
        /// <returns></returns>
        public static string GetIndividual(string lastName, string firstName, string patronymic, string dateBirth)
        {
            return lastName + " " + firstName + " " + patronymic + "(" + dateBirth + ")";
        }

        /// <summary>
        /// Получение списка из строки
        /// </summary>
        /// <param name="strData">строка, в которую надо добавить</param>
        /// <param name="str">данные, которые надо добавить в список</param>
        /// <returns>Возвращает строку вида "строка,"</returns>
        public static string GetListString(this string strData, string str)
        {
            strData += strData == string.Empty ? str : "," + str;
            return strData;
        }

        /// <summary>
        /// Получение списка из строки для выгрузки в excel
        /// </summary>
        /// <param name="strData">строка, в которую надо добавить</param>
        /// <param name="str">данные, которые надо добавить в список</param>
        /// <returns>Возвращает строку вида "строка,"</returns>
        public static string GetListStringExcel(this string strData, string str)
        {
            strData += strData == string.Empty ? str : ";" + str;
            return strData;
        }

        /// <summary>
        /// Очистка полей на форме в зависимости от типа
        /// </summary>
        /// <param name="panel">панель на форме</param>
        public static void ClearFieldForm(this Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = "";
                if (c.GetType() == typeof(MaskedTextBox))
                    c.Text = "";
                if (c.GetType() == typeof(ComboBox))
                    ((ComboBox)c).SelectedIndex = -1;
                if (c.GetType() == typeof(CheckBox))
                    ((CheckBox)c).Checked = false;
            }
        }

        /// <summary>
        /// Получение фильтра в зависимости от типа данных
        /// </summary>
        /// <param name="typeData">Тип данных</param>
        /// <param name="field">Поле</param>
        /// <param name="data">Даннные</param>
        /// <returns></returns>
        public static string GetFilter(string typeData, string field, object data)
        {
            switch (typeData)
            {
                case "string":
                    return $" AND (lower({field}) LIKE lower(''%{data}%''))";
                case "date":
                    return $" AND ({field} = ''{data}'')";
                case "guid":
                    return $" AND ({field} = ''{data}'')";
                case "bool":
                    return $" AND ({field} = {data})";
                case "number":
                    return $" AND ({field} = {data})";
            }
            return "";
        }

        /// <summary>
        /// Удаление 1 символа _ из типов данных
        /// </summary>
        /// <param name="str">Переданный тип</param>
        /// <returns></returns>
        public static string GetTypeData(this string str)
        {
            return str.Remove(0, 1);
        }

        /// <summary>
        /// Проверка даты рождения пациента/работника
        /// </summary>
        /// <returns>Возвращает результат проверки</returns>
        public static void CheckDateBirth(this string dateData)
        {
            int[] months31 = { 1, 3, 5, 7, 8, 10, 12 };
            int[] months30 = { 4, 6, 9, 11 };
            var str = dateData;
            var words = str.Split(new char[] { '.' });
            var year = int.Parse(words[2]);
            var month = int.Parse(words[1]);
            var day = int.Parse(words[0]);

            if (year <= 1800 || year >= DateTime.Now.Year)
            {
                throw new ArgumentException("Неверный год рождения");
            }

            if (month == 0 || month > 12)
            {
                throw new ArgumentException("Неверный месяц рождения");
            }

            if (months31.Where(i => month == i).Any(i => day == 0 || day > 31))
            {
                throw new ArgumentException("Неверная дата рождения");
            }

            if (months30.Where(i => month == i).Any(i => day == 0 || day > 30))
            {
                throw new ArgumentException("Неверная дата рождения");
            }

            if (month != 2) return;

            if (year % 4 != 0)
            {
                if (day > 28)
                {
                    throw new ArgumentException("Неверная дата рождения");
                }
            }
            else if (day > 29)
            {
                throw new ArgumentException("Неверная дата рождения");
            }
        }

        public static string GetNameColumn(string nameColumnBd, bool isTable)
        {
            var data = nameColumnBd.Split(new char[] { '_' });
            string str = "";
            foreach (var s in data)
            {
                if (s == data[0] && !isTable) str = s;
                else
                {
                    string str1 = "";
                    var arr = s.ToCharArray();
                    str1 = Char.ToUpper(arr[0]).ToString();
                    for (int i = 1; i < arr.Length; i++)
                    {
                        str1 += arr[i];
                    }
                    str += str1;
                }
            } 
            return str;
        }

        public static string GetTypeColumn(string typeColumnBd)
        {
            switch (typeColumnBd)
            {
                case "integer":
                    return "Int32?";
                case "uuid":
                    return "Guid?";
                case "character varying":
                    return "string";
                case "date":
                    return "DateTime?";
                case "timestamp without time zone":
                    return "DateTime?";
                case "real":
                    return "double?";
                case "boolean":
                    return "Boolean";
                case "serial":
                    return "Int64?";

            }
            return "";
        }
    }
}
