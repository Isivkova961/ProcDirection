using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assistant.Repository;

namespace Repository.Entity.Auto
{
    public class Napr 
    {
        public Napr(string _fio_d)
        {
            fio_d = _fio_d;

        }

        public string fio_d { get; set; }

    }

}
