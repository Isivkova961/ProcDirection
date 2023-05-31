using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Auto
{
    public partial class NaprRepository : BaseRepository
    {
        public NaprRepository() : base("napr") { }
        public static string TableName = "napr";
    }

}
