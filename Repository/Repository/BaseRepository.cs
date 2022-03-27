using System;
using System.Data.SqlClient;

namespace Repository
{
    public abstract class BaseRepository : IDisposable
    {
        private static string conectionString = @"Server=REVISION-PC;Database=master;Trusted_Connection=True;";

        protected SqlConnection GetConexao()
        {
            var con = new SqlConnection(conectionString);
            con.Open();
            return con;
        }
        public void Dispose()
        {
            GetConexao().Close();
            GetConexao().Dispose();
        }
    }
}
