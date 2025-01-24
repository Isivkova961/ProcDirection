using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assistant.Utils;
using Microsoft.Data.SqlClient;
using SqlCommand = System.Data.SqlClient.SqlCommand;

namespace Repository.Repository.Auto
{
    public partial class NaprReestrListRepository : BaseRepository
    {
        public NaprReestrListRepository() : base("napr_reestr") { }
        public static string TableName = "napr_reestr";

        public SqlCommand List(DateTime datein, DateTime dateout)
        {
            return ("exec NAPR_REESTR_LIST @datein, @dateout").Query().Params("@datein", datein).Params("@dateout", dateout);
        }

        public SqlCommand Drop()
        {
            return ("exec DROP_NAPR_REESTR").Query();
        }

        public SqlCommand List2(string status)
        {
            return ("exec NAPR_REESTR_LIST2 @status").Query().Params("@status", status);
        }

        public SqlCommand Update(string kod, string nameXml, string status, string pathPdf, int isLoad, string step)
        {
            return
                ("exec NAPR_REESTR_UPDATE @kod,@name_xml,@status,@pathPdf,@isLoad,@step").Query()
                    .Params("@kod", kod)
                    .Params("@name_xml", nameXml)
                    .Params("@status", status)
                    .Params("@pathPdf", pathPdf)
                    .Params("@isLoad", isLoad)
                    .Params("@step",step);
        }
    }

}
