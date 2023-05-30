using System;
using System.Diagnostics;
using System.IO;

namespace Assistant.Utils
{
    public static class LogUtils
    {

        public static System.Net.IPAddress IpAdress;
        public static string Host;

        public static string PathLog = Environment.CurrentDirectory + @"\Log.txt";
        public static string PathLogUpdate = @"c:\AssistentTmp\Log.txt"; //Вынесли в настройки app.config 
        public static string messageLogData;
        public static string messageLogDataUpdate;
        public static string Separator = "--------------------------------------------------------------------------------";
        public static string PathCheckData = @"CheckWorker.txt";




        public static void GetIPHost()
        {
            // Получение имени компьютера.
            Host = System.Net.Dns.GetHostName();
            // Получение ip-адреса.
            IpAdress = System.Net.Dns.GetHostByName(Host).AddressList[0];
        }

        /// <summary>
        /// Сохранение лога в файл
        /// </summary>
        public static void SaveLog()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(PathLog, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("Лог на дату: " + TempValue.DateNow);
                    sw.Write(messageLogData);

                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Лог не сохранился");
            }
        }

        /// <summary>
        /// Сохранение лога в файл
        /// </summary>
        public static void SaveLogUpdate()
        {
            try
            {
                using (var sw = new StreamWriter(PathLogUpdate, true, System.Text.Encoding.UTF8))
                {
                    sw.Write(messageLogDataUpdate);

                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Лог не сохранился");
            }
        }

        /// <summary>
        /// Сохранение сообщений в лог
        /// </summary>
        /// <param name="messageLog">Сообщение лога</param>
        public static void GetLogMessageSeans(string messageLog)
        {
            messageLogData += messageLog + "\r\n";
        }

        /// <summary>
        /// Сохранение сообщений в лог
        /// </summary>
        /// <param name="messageLog">Сообщение лога</param>
        public static void GetLogMessageSeansUpdate(string messageLog)
        {
            messageLogDataUpdate += DateTime.Now + ": " + messageLog + "\r\n";
        }

        /// <summary>
        /// Сохранение запросов в лог
        /// </summary>
        /// <param name="sqlText">Запрос</param>
        public static string GetLogSqlText(string sqlText)
        {
            return sqlText + "\r\n";
        }

        /// <summary>
        /// Получение текста сообщения в лог в зависимости от типа сообщения
        /// </summary>
        /// <param name="typeMessage">Тип сообщения: 0 - Вход, 1 - Выход, 2 - Запрос</param>
        /// <returns></returns>
        public static string GetTextMessage(int typeMessage)
        {
            switch (typeMessage)
            {
                case 0:
                    return "Пользователь " + TempValue.UserName + " произвел вход в ";
                case 1:
                    return "Пользователь " + TempValue.UserName + " закончил работу с программой." + "\r\n" + Separator;
                case 2:
                    return "Пользователь выполнил запрос(ы):";
            }
            return "Err";
        }

        /// <summary>
        /// Получение название модуля для вставки в лог
        /// </summary>
        /// <param name="typeModul">Тип модуля admin, registrator, doctor, profpatolog, econom, laborant</param>
        /// <returns></returns>
        public static string GetModulName(string typeModul)
        {
            switch (typeModul)
            {
                case "admin":
                    return " Модуль администратора ";
                case "registrator":
                    return " Модуль регистратора ";
                case "doctor":
                    return " Модуль врача ";
                case "profpatolog":
                    return " Модуль профпатолога ";
                case "econom":
                    return " Модуль экономиста ";
                case "laborant":
                    return " Модуль лаборанта ";
            }
            return "Err";
        }

        /// <summary>
        /// Получение типа изменения для лога
        /// </summary>
        /// <param name="typeUpdate">Тип изменения 0 - Добавление, 1 - Изменение, 2 - Удаление</param>
        /// <returns></returns>
        public static string GetTypeUpdateBd(int typeUpdate)
        {
            switch (typeUpdate)
            {
                case 0:
                    return "Добавление: ";
                case 1:
                    return "Изменение: ";
                case 2:
                    return "Удаление: ";
            }
            return "Err";
        }

        public static void SaveInLog(string typeModul)
        {
            var messageLog = GetTextMessage(0) + GetModulName(typeModul);
            GetLogMessageSeansUpdate(messageLog);
        }

        public static void SaveOutLog()
        {
            var messageLog = GetTextMessage(1);
            GetLogMessageSeansUpdate(messageLog);
            SaveLogUpdate();
        }

        public static void SaveUpdateLog(string sqlText, bool isNew)
        {
            var messageLog = GetTypeUpdateBd(isNew ? 0 : 1);
            messageLog += GetLogSqlText(sqlText);
            GetLogMessageSeansUpdate(messageLog);

        }

        public static void SaveDeleteLog(string sqlText)
        {
            var messageLog = GetTypeUpdateBd(2);
            messageLog += GetLogSqlText(sqlText);
            GetLogMessageSeansUpdate(messageLog);

        }

        public static void OpenCheckData(string data)
        {
            try
            {
                using (var sw = new StreamWriter(PathCheckData, false, System.Text.Encoding.UTF8))
                {
                    sw.Write(data);
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Данные не сохранились");
            }
            Process.Start("C:\\Windows\\System32\\notepad.exe", PathCheckData);
        }



    }
}
