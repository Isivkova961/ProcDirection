using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity.Auto
{
    public class KmisNapr
    {
        public KmisNapr() { }
        public KmisNapr(string _fio, string _fio_d, string _numberib, string _date_gosp, string _date_vipis,
            string _otdel, string _address, string _type_gosp, string _polis)
        {
            fio = _fio;
            fio_d = _fio_d;
            numberib = _numberib;
            date_gosp = _date_gosp;
            date_vipis = _date_vipis;
            otdel = _otdel;
            address = _address;
            type_gosp = _type_gosp;
            polis = _polis;
        }

        public string fio { get; set; }
        public string fio_d { get; set; }
        public string numberib { get; set; }
        public string date_gosp { get; set; }
        public string date_vipis { get; set; }
        public string otdel { get; set; }
        public string address { get; set; }
        public string type_gosp { get; set; }
        public string polis { get; set; }
    }
}
