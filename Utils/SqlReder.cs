using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Assistant.Utils
{
    public class SqlReader : IEnumerable<IDictionary<string, object>>
    {
        private readonly Dictionary<int, string> _columns;
        private readonly SqlCommand _cmd;
        private int _tableNumber;
        private int _rowNumber;
        private int _totalTableCount;

        public SqlReader(SqlCommand cmd)
        {
            _columns = new Dictionary<int, string>();
            _tableNumber = -1;
            _totalTableCount = -1;
            _cmd = cmd;
        }

        public int TableNumber
        {
            get { return _tableNumber; }
        }

        public int RowNumber
        {
            get { return _rowNumber; }
        }

        public int TotalTableCount
        {
            get { return _totalTableCount; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<IDictionary<string, object>> GetEnumerator()
        {
            return new ExpandoEnumerator(this);
        }

        private sealed class ExpandoEnumerator : IEnumerator<IDictionary<string, object>>
        {
            private IDictionary<string, object> _current;
            private readonly SqlReader _sqlReader;
            private SqlDataReader _reader;

            public ExpandoEnumerator(SqlReader sqlReader)
            {
                _sqlReader = sqlReader;
            }

            public void Dispose()
            {
                Close();
            }

            public void Reset()
            {
                Close();
            }

            private void Close()
            {
                if (_reader != null)
                {
                    _reader.Close();
                    _reader.Dispose();
                }
                if (_sqlReader._totalTableCount == -1) _sqlReader._totalTableCount = _sqlReader._tableNumber;
                _sqlReader._tableNumber = -1;
                _sqlReader._rowNumber = -1;
                _sqlReader._columns.Clear();
                _reader = null;
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public IDictionary<string, object> Current
            {
                get { return _current; }
            }

            public bool MoveNext()
            {
                if (_reader == null)
                {
                    Reset();
                    if (_sqlReader._cmd.Connection.State != ConnectionState.Open)
                    {
                        _sqlReader._cmd.Connection.Open();
                    }
                    _reader = _sqlReader._cmd.ExecuteReader();
                    if (_reader == null) return false;
                    _sqlReader._tableNumber = 0;
                    GetColumns();
                }
                if (_reader.Read())
                {
                    _sqlReader._rowNumber++;
                    _current = GetValues();
                    return true;
                }
                if (_reader.NextResult())
                {
                    _sqlReader._tableNumber++;
                    GetColumns();
                    return MoveNext();
                }
                Reset();
                return false;
            }

            private void GetColumns()
            {
                _sqlReader._columns.Clear();
                for (int i = 0; i < _reader.FieldCount; i++)
                {
                    _sqlReader._columns.Add(i, _reader.GetName(i));
                }
            }

            private IDictionary<string, object> GetValues()
            {
                IDictionary<string, object> o = new ExpandoObject();
                for (int i = 0; i < _reader.FieldCount; i++)
                {
                    var value = !_reader.IsDBNull(i) ? _reader.GetValue(i) : null;//_reader.GetProviderSpecificFieldType(i).Default();
                    o.Add(_sqlReader._columns[i], value);
                }
                return o;
            }
        }
    }
}

