using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity.Auto
{
    public class KmisNaprList
    {
        public KmisNaprList() { }
        public KmisNaprList(string _fio, string _numberib,
            string _otdel)
        {
            fio = _fio;
            numberib = _numberib;
            otdel = _otdel;
        }

        public string fio { get; set; }
        public string numberib { get; set; }
        public string otdel { get; set; }
    }
}
