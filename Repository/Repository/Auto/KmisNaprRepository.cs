using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Auto
{
    public partial class KmisNaprRepository : BaseRepository
    {
        public KmisNaprRepository() : base("kmis_napr") { }
        public static string TableName = "kmis_napr";
    }

}
