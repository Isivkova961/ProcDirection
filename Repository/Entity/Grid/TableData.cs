using System;
using System.Dynamic;

namespace Assistant.Repository.Entity.Grid
{
    public class TableData: BaseClass
    {
        public TableData()
        {
            guid = System.Guid.NewGuid();
        }

        public TableData(ExpandoObject obj): base(obj) { }

        public TableData(Guid? _guid, string _nameColumn, string _typeField, Int32? _sizeField, bool _isNotNull, bool _isPk,
            bool _isFk, string _pkName, string _fkName, string _defaultData, bool _isNotTable, string _fkColumnName)
        {
            guid = _guid;
            nameColumn = _nameColumn;
            typeField = _typeField;
            sizeField = _sizeField;
            isNotNull = _isNotNull;
            isPk = _isPk;
            isFk = _isFk;
            pkName = _pkName;
            fkName = _fkName;
            defaultData = _defaultData;
            isNotTable = _isNotTable;
            fkColumnName = _fkColumnName;
        }

        [ModelField("guid")]
        public Guid? guid
        {
            get { return get<Guid?>("guid"); }
            set { set<Guid?>("guid", value); }
        }

        [ModelField("nameColumn")]
        public string nameColumn
        {
            get { return get<string>("nameColumn"); }
            set { set<string>("nameColumn", value); }
        }

        [ModelField("typeField")]
        public string typeField
        {
            get { return get<string>("typeField"); }
            set { set<string>("typeField", value); }
        }

        [ModelField("sizeField")]
        public Int32? sizeField
        {
            get { return get<Int32?>("sizeField"); }
            set { set<Int32?>("sizeField", value); }
        }

        [ModelField("isNotNull")]
        public bool isNotNull
        {
            get { return get<bool>("isNotNull"); }
            set { set<bool>("isNotNull", value); }
        }

        [ModelField("isPk")]
        public bool isPk
        {
            get { return get<bool>("isPk"); }
            set { set<bool>("isPk", value); }
        }

        [ModelField("isFk")]
        public bool isFk
        {
            get { return get<bool>("isFk"); }
            set { set<bool>("isFk", value); }
        }

        [ModelField("pkName")]
        public string pkName
        {
            get { return get<string>("pkName"); }
            set { set<string>("pkName", value); }
        }

        [ModelField("fkName")]
        public string fkName
        {
            get { return get<string>("fkName"); }
            set { set<string>("fkName", value); }
        }

        [ModelField("fkColumnName")]
        public string fkColumnName
        {
            get { return get<string>("fkColumnName"); }
            set { set<string>("fkColumnName", value); }
        }

        [ModelField("defaultData")]
        public string defaultData
        {
            get { return get<string>("defaultData"); }
            set { set<string>("defaultData", value); }
        }

        [ModelField("nameColumnGrid")]
        public string nameColumnGrid
        {
            get { return get<string>("nameColumnGrid"); }
            set { set<string>("nameColumnGrid", value); }
        }

        [ModelField("isVisible")]
        public bool isVisible
        {
            get { return get<bool>("isVisible"); }
            set { set<bool>("isVisible", value); }
        }

        [ModelField("isNotTable")]
        public bool isNotTable
        {
            get { return get<bool>("isNotTable"); }
            set { set<bool>("isNotTable", value); }
        }



        public static explicit operator TableData(ExpandoObject src) { return new TableData(src); }
        public static explicit operator ExpandoObject(TableData wrp) { return wrp.Wrapped; }
    }
}
