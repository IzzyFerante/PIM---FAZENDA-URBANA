using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class DAL
    {
        private NpgsqlConnection conn;
        string connString = String.Format("Server={0};Port={1};User Id={2};Password{3};Database{4};", "localhost", "5432", "postgres", "bella123", "fazenda_urbana");
        private NpgsqlCommand cmd;
        private string sql = null;
    }


    /*public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DbConnection()
        {
            Connection = new NpgsqlConnection("Server=192.168.0.49;Port=5432;Database=Fazend_urbana;User Id=postgres;Password=;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }*/
}
