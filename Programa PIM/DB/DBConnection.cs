using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbConnection : IDisposable
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

    }
}
