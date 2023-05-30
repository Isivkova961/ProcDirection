using System;
using System.Dynamic;

namespace Assistant.Repository.Entity.Grid
{
    public class Grid: BaseClass
    {
        public Grid()
        {
            guid = System.Guid.NewGuid();
        }

        public Grid(ExpandoObject obj): base(obj) { }

        public Grid(Int64? _id, Guid? _guid, string _name, DateTime? _inserted, DateTime? _updated, DateTime? _deleted)
        {
            id = _id;
            guid = _guid;
            name = _name;
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

        [ModelField("name")]
        public string name
        {
            get { return get<string>("name"); }
            set { set<string>("name", value); }
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

        public static explicit operator Grid(ExpandoObject src) { return new Grid(src); }
        public static explicit operator ExpandoObject(Grid wrp) { return wrp.Wrapped; }
    }
}
