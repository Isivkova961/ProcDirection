using System;
using System.Dynamic;

namespace Assistant.Repository.Entity.Grid
{

    public class GridItem : BaseClass
    {
        public GridItem()
        {
            guid = System.Guid.NewGuid();
        }

        public GridItem(ExpandoObject obj): base(obj) { }

        public GridItem(Int64? _id, Guid? _guid, Guid? _gridGuid, string _name, string _textColumn,
            bool _isVisibleColumn, DateTime? _inserted, DateTime? _updated, DateTime? _deleted)
        {
            id = _id;
            guid = _guid;
            gridGuid = _gridGuid;
            name = _name;
            textColumn = _textColumn;
            isVisibleColumn = _isVisibleColumn;
            inserted = _inserted;
            updated = _updated;
            deleted = _deleted;
        }

        [ModelField("id")]
        public Int64? id
        {
            get { return get<Int64?>("id"); }
            set { set<Int64?>("id", value); }
        }

        [ModelField("guid")]
        public Guid? guid
        {
            get { return get<Guid?>("guid"); }
            set { set<Guid?>("guid", value); }
        }

        [ModelField("grid_guid")]
        public Guid? gridGuid
        {
            get { return get<Guid?>("grid_guid"); }
            set { set<Guid?>("grid_guid", value); }
        }

        [ModelField("name")]
        public string name
        {
            get { return get<string>("name"); }
            set { set<string>("name", value); }
        }

        [ModelField("text_column")]
        public string textColumn
        {
            get { return get<string>("text_column"); }
            set { set<string>("text_column", value); }
        }

        [ModelField("is_visible")]
        public bool isVisibleColumn
        {
            get { return get<bool>("is_visible"); }
            set { set<bool>("is_visible", value); }
        }

        [ModelField("inserted")]
        public DateTime? inserted
        {
            get { return get<DateTime?>("inserted"); }
            set { set<DateTime?>("inserted", value); }
        }

        [ModelField("updated")]
        public DateTime? updated
        {
            get { return get<DateTime?>("updated"); }
            set { set<DateTime?>("updated", value); }
        }

        [ModelField("deleted")]
        public DateTime? deleted
        {
            get { return get<DateTime?>("deleted"); }
            set { set<DateTime?>("deleted", value); }
        }

        public static explicit operator GridItem(ExpandoObject src) { return new GridItem(src); }
        public static explicit operator ExpandoObject(GridItem wrp) { return wrp.Wrapped; }
    }
}
