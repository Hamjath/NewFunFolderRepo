
using System.Data.SqlClient;

namespace Fw.Utils
{

    public static class DbUtils
    {
        private static readonly string connectionString = "Data Source=PRATHISH\\SQLEXPRESS;Initial Catalog=NewTimeTrack;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }

}