using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DBConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DBConnection()
        {
            Connection = new NpgsqlConnection("Server=IP_FELIPE;Port=5432;Database=fazenda_urbana;User Id=postgres;Password=;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }

    }
}
