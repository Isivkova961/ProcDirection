using System.Data.SqlClient;
using Assistant.Utils;
using Npgsql;
using Repository.Repository;

namespace Assistant.Repository.Repository.Grid
{

    public partial class GridItemRepository : BaseRepository
    {
        public GridItemRepository() : base("grid_item") { }
        public static string TableName = "grid_item";


        public SqlCommand Find(string gridName)
        {
            if (!CheckProcName(StoredProcFind)) return null;
            return StoredProcFind.GetLoadProcedure().Query().Params("@guid", gridName);
        }

    }
}
