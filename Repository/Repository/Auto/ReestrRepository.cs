using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assistant.Utils;

namespace Repository.Repository.Auto
{
    public partial class ReestrRepository : BaseRepository
    {
        public ReestrRepository() : base("reestr") { }
        public static string TableName = "reestr";

        public SqlCommand List(DateTime datein, DateTime dateout)
        {
            return ("exec reestr_list @datein, @dateout").Query().Params("@datein", datein).Params("@dateout", dateout);
        }
    }

}
