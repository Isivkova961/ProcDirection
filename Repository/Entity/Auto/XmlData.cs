using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assistant.Repository;

namespace Repository.Entity.Auto
{
    public class XmlData 
    {
        public XmlData() { }
        public XmlData(string _reestr_id, string _step, string _tipopl, int _num, int _i, string _nameXml)
        {
            reestr_id = _reestr_id;
            step = _step;
            tipopl = _tipopl;
            num = _num;
            i = _i;
            nameXml = _nameXml;

        }



        public string reestr_id { get; set; }
        public string step { get; set; }
        public string tipopl { get; set; }
        public int num { get; set; }
        public int i { get; set; }
        public string nameXml { get; set; }
    }

}
