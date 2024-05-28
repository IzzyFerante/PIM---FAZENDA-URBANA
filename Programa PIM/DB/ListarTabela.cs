using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FAZER ISSO PARA TODAS AS TABELAS

namespace DB
{
    public class ListarTabela
    {
        public bool Insert (/*objeto="tabela"*/ /*nome objeto*/)
        {
            using var conn = new DbConnection();

            string query = @"";

            var result = conn.Connection.Execute(sql: query, param: /*nome do objeto acima*/);

            return result == 1;
        }

        public List</*nome tabela*/> Get()
        {
            using var conn = new DBConnection();

            string query = @"SELECT * FROM /*nome tabela*/;";

            var /*nome objeto*/ = conn.Connection.Query</*nome tabela*/>(sql: query);

            return /*nome var acima*/.ToList();
        }


    }
}
