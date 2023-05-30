using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assistant.Utils;

namespace Assistant.Repository.Repository
{
    public partial class GetProcExistsRepository
    {
        public static bool FindProc(string procName)
        {
            return ($"SELECT 1 FROM pg_proc where proname = '{procName}'".Query().ToArray().Length > 0);
        }
    }
}
