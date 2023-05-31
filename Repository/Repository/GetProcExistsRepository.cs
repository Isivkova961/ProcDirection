using Assistant.Utils;

namespace Repository.Repository
{
    public partial class GetProcExistsRepository
    {
        public static bool FindProc(string procName)
        {
            return ($"SELECT 1 FROM pg_proc where proname = '{procName}'".Query().ToArray().Length > 0);
        }
    }
}
