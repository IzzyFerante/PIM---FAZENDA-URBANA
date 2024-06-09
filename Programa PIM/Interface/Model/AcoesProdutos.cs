using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class AcoesProdutos
    {
        /// 
        /// CONEXÃO COM O BANCO
        /// 
        private string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "bella123", "fazenda_urbana");
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private string sql = null;






        //////////////////////////////////////////////////    AÇÕES DA TABELA PRINCIPAL   //////////////////////////////////////////////////
       
        
        
        ///
        /// AÇÕES PARA CADASTRAR DADOS NO BANCO
        ///
        public void CadastrarDados(bool status, string id_categoria, string id_produto, string descricao, string valor, string qntdEstoque)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"INSERT INTO produtos (status, id_categoria, id_produto, desc_produto, valor_unitario, qntd_estoque) VALUES ({status}, '{id_categoria}', '{id_produto}', '{descricao}', '{valor}', '{qntdEstoque}');";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n CADASTRAR DADOS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        ///
        /// AÇÕES PARA ATUALIZAR DADOS NO BANCO
        ///
        public void AtualizarDados(string id_produto, bool status, string id_categoria, string descricao, string valor, string qntdEstoque)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"UPDATE produtos SET status = {status}, id_categoria = '{id_categoria}', desc_produto = '{descricao}', valor_unitario = {valor}, qntd_estoque = {qntdEstoque} WHERE id_produto = '{id_produto}';";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// 
        /// AÇÃO PARA ATUALIZAR DATAGRID
        ///
        public DataTable AtualizarDataGrid()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();    //  Conectar com o banco

                    sql = $"SELECT * FROM produtos ORDER BY id_categoria ASC, id_produto ASC;";

                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, conn))
                    {
                        // Cria um DataTable para armazenar os dados
                        DataTable dataTable = new DataTable();

                        // Preenche o DataTable com os dados do banco de dados
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado ao conectar com o banco de dados.\n\n ATUALIZAR DATAGRID: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }





        ////////////////////////////////////////////////////    AÇÕES DE FOREIGN KEY   ////////////////////////////////////////////////////



        ///
        /// AÇÃO PARA PUXAR A DESCRIÇÃO DA FOREING KEY ATRAVÉS DO ID
        ///
        public string PuxarDescFK(string coluna, string tabela, string coluna_fixa, string id)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT {coluna} FROM {tabela} WHERE {coluna_fixa} = '{id}';";

                    cmd = new NpgsqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Verifica se o valor da coluna não é nulo
                        if (!reader.IsDBNull(0))
                        {
                            return reader.GetString(0);
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR DESCRIÇÃO:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }  



        /// 
        /// AÇÃO PARA CADASTRAR NOVA FOREIGN KEY
        /// 
        public void CadastrarNovaFK(string tabela, string colunas, string dados)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"INSERT INTO {tabela} ({colunas}) VALUES ({dados});";

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n CADASTRAR NOVA FK: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        ///
        /// AÇÃO PARA ATUALIZAR CADASTRO DE FOREING KEY
        ///
        public void AtualizarDadosFK(string tabela, string coluna, string dado, string colunaFixa, string id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"UPDATE {tabela} SET {coluna} = '{dado}' WHERE {colunaFixa} = '{id}';";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS DATA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
