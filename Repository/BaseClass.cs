using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace Repository
{
    public class BaseClass : DynamicObject, IDictionary<string, object>
    {
        private ExpandoObject wrapped;

        protected virtual int GetToStringOrder(string name)
        {
            return name == "id" ? 10 : 0;
        }

        public BaseClass()
        {
            Wrapped = new ExpandoObject();
            //FixFields();
        }

        public BaseClass(IDictionary<string, object> obj)
        {
            if ((obj == null) || (obj is ExpandoObject))
            {
                Wrapped = obj as ExpandoObject;
            }
            else
            {
                Wrapped = new ExpandoObject();
                foreach (KeyValuePair<string, object> pair in obj) _d.Add(pair.Key, pair.Value);
            }
            //FixFields();
        }

        public ExpandoObject Wrapped
        {
            get
            {
                DoBeforeUnwrap();
                return wrapped;
            }
            set { wrapped = value; }
        }

        protected IDictionary<string, object> _d
        {
            get { return wrapped; }
        }

        protected virtual void DoBeforeUnwrap()
        {

        }

        public override string ToString()
        {
            PropertyInfo returnedProperty = null;
            int fieldOrder = 0;
            var pis = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(x => new
                {
                    pi = x,
                    attrs = x.GetCustomAttributes(typeof(ModelFieldAttribute), true)
                });
            foreach (var pi in pis.Where(x => x.attrs.Any()))
            {
                var name = pi.attrs.Cast<ModelFieldAttribute>().Select(x => x.Name).First();
                int curOrder = GetToStringOrder(name);
                if (fieldOrder < curOrder)
                {
                    fieldOrder = curOrder;
                    returnedProperty = pi.pi;
                }
            }
            if (returnedProperty == null) return base.ToString();
            return returnedProperty.GetValue(this, null).ToString();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return _d.TryGetValue(binder.Name, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _d[binder.Name] = value;
            return true;
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return _d.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<string, object> item)
        {
            _d.Add(item);
        }

        public void Clear()
        {
            _d.Clear();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            return _d.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            _d.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            return _d.Remove(item);
        }

        public int Count
        {
            get { return _d.Count; }
        }

        public bool IsReadOnly
        {
            get { return _d.IsReadOnly; }
        }

        public bool ContainsKey(string key)
        {
            return _d.ContainsKey(key);
        }

        public void Add(string key, object value)
        {
            _d.Add(key, value);
        }

        public bool Remove(string key)
        {
            return _d.Remove(key);
        }

        public bool TryGetValue(string key, out object value)
        {
            return _d.TryGetValue(key, out value);
        }

        public object this[string key]
        {
            get { return _d[key]; }
            set { _d[key] = value; }
        }

        public ICollection<string> Keys
        {
            get { return _d.Keys; }
        }

        public ICollection<object> Values
        {
            get { return _d.Values; }
        }

        public bool FixField<T>(string name, T value, bool overWrite = false)
        {
            if ((!overWrite) && (_d.ContainsKey(name))) return false;
            set(name, value);
            return true;
        }

        public T get<T>(string name)
        {
            object ret = default(T);
            if (!SpecialGet(name, typeof(T), ref ret)) ret = intGet<T>(name, ret);
            return (T)ret;
        }

        protected object intGet<T>(string name, object ret)
        {
            if (_d.ContainsKey(name))
            {
                var value = _d[name];
                _d[name] = FixGetValue(name, typeof(T), value);
                ret = _d[name];
            }
            return ret;
        }

        protected virtual object FixGetValue(string name, Type type, object value)
        {
            return value;
        }

        protected virtual object FixSetValue(string name, Type type, object value)
        {
            return value;
        }

        protected virtual bool SpecialGet(string name, Type type, ref object ret)
        {
            return false;
        }

        public void set<T>(string name, T value)
        {
            Type type = typeof(T);
            if (!SpecialSet(name, type, value)) intSet(name, FixSetValue(name, typeof(T), value));
        }

        protected virtual bool SpecialSet(string name, Type type, object value)
        {
            return false;
        }

        protected void intSet<T>(string name, T value)
        {
            _d[name] = value;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ModelFieldAttribute : Attribute
    {
        public ModelFieldAttribute() : base()
        {

        }

        public ModelFieldAttribute(string Name)
            : base()
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }

}
