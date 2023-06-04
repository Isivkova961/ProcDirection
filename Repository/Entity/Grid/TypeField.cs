using System;
using System.Dynamic;
using Repository;

namespace Assistant.Repository.Entity
{
    public class TypeField: BaseClass
    {
        public TypeField()
        {
        }

        public TypeField(ExpandoObject obj): base(obj) { }

        public TypeField(string _code, string _name)
        {
            code = _code;
            name = _name;
        }

        [ModelField("code")]
        public string code
        {
            get { return get<string>("code"); }
            set { set<string>("code", value); }
        }

        [ModelField("name")]
        public string name
        {
            get { return get<string>("name"); }
            set { set<string>("name", value); }
        }

        public static explicit operator TypeField(ExpandoObject src) { return new TypeField(src); }
        public static explicit operator ExpandoObject(TypeField wrp) { return wrp.Wrapped; }
    }
}
