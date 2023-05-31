using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assistant.Repository;

namespace Repository.Entity.Auto
{
    public class Napr 
    {

        public Napr(string _fio_d, string _path)
        {
            fio_d = _fio_d;
            path = _path;

        }



        public string fio_d { get; set; }


        public string path { get; set; }

    }

}
