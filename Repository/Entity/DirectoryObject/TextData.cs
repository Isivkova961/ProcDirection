namespace Assistant.Repository.Entity.DirectoryObject
{
    public class TextData
    {
        public TextData()
        {
        }

        public TextData(int _id, string _name, string _typeText, string _text, bool _isHide, bool _isAllowBlank, string _tableName, bool _isEdit)
        {
            id = _id;
            name = _name;
            typeText = _typeText;
            text = _text;
            isHide = _isHide;
            isAllowBlank = _isAllowBlank;
            tableName = _tableName;
            isEdit = _isEdit;
        }

        /// <summary>
        /// ключ поля
        /// </summary>
        public int id;
        /// <summary>
        /// Название поля, текст
        /// </summary>
        public string name;
        /// <summary>
        /// тип поля
        /// </summary>
        public string typeText;
        /// <summary>
        /// текст надписи
        /// </summary>
        public string text;
        /// <summary>
        /// скрывать поле
        /// </summary>
        public bool isHide;
        /// <summary>
        /// редактировать поле
        /// </summary>
        public bool isEdit;
        /// <summary>
        /// Разрешить пустое
        /// </summary>
        public bool isAllowBlank;
        /// <summary>
        /// Таблица из которой заполняем данные
        /// </summary>
        public string tableName;



    }
}

