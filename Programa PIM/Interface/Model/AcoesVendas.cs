using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class AcoesVendas
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
        public void CadastrarDados(string id_venda, DateTime dtVenda, string id_cliente, string valor, string forma_pagamento, int qntd_parcelas, string valor_parcelas)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"INSERT INTO vendas (id_venda, data_venda, id_cliente, valor_total, forma_pagamento, qntd_parcelas, valor_parcelas) VALUES ('{id_venda}', '{dtVenda}', '{id_cliente}', '{valor}', {forma_pagamento}, {qntd_parcelas}, {valor_parcelas} ) ";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n CADASTRAR DADOS VENDA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CadastrarDadosItens(string id_item, string id_venda, string id_produto, string quantidade, string valor_unitario, string valor_total)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"INSERT INTO itens_venda (id_item, id_venda, id_produto, quantidade, valor_unitario, valor_total) VALUES ('{id_item}', '{id_venda}', '{id_produto}', '{quantidade}', '{valor_unitario}', '{valor_total}')";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n CADASTRAR DADOS ITENS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        ///
        /// AÇÕES PARA ATUALIZAR DADOS NO BANCO
        ///
        public void AtualizarDados(string id_venda, DateTime dtVenda, string id_cliente, string valor, string forma_pagamento, int qntd_parcelas, string valor_parcelas)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"UPDATE vendas SET data_venda = '{dtVenda}', id_cliente = '{id_cliente}', valor_total = '{valor}', forma_pagamento = '{forma_pagamento}', qntd_parcelas = {qntd_parcelas}, valor_parcelas = '{valor_parcelas}' WHERE id_venda = '{id_venda}';";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS VENDA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public DataTable Buscar(string dadoUsuario, string coluna, string tabela, string id)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();    //  CONECTAR COM O BANCO

                sql = $"SELECT * FROM {tabela} WHERE {coluna} LIKE '%{dadoUsuario}%' AND status = true ORDER BY {id} ASC";
                cmd = new NpgsqlCommand(sql, conn);

                var reader = cmd.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();   //  Fechar conexão com o banco
                return dataTable;   //  Retornar a tabela com as seleções
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n BUSCAR: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public string PuxarDescATIVOS(string coluna, string tabela, string coluna_fixa, string id)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT {coluna} FROM {tabela} WHERE {coluna_fixa} = '{id}' AND status = true";

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
        /// AÇÃO PARA PUXAR O ULTIMO CÓDIGO DE UMA CERTA VENDA
        /// 
        public string NovoCódigo(string id_venda, string tabela, string coluna, string coluna_fixa, string id)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    AcoesProdutos acoesReutilizacao = new AcoesProdutos();

                    conn.Open();

                    string verificacaoDeExistenciaCodigo = acoesReutilizacao.PuxarDescFK("id_item", "itens_venda", "id_venda", id_venda);

                    if (!string.IsNullOrWhiteSpace(verificacaoDeExistenciaCodigo))
                    {

                        sql = $"SELECT MAX({coluna}) AS ultima_matricula FROM {tabela} WHERE {coluna_fixa} = '{id}';";
                        cmd = new NpgsqlCommand(sql, conn);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Verifica se o valor da coluna não é nulo
                                if (!reader.IsDBNull(0))
                                {
                                    return reader.GetString(0);
                                }
                            }
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n NOVO CÓDIGO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        /// 
        /// AÇÃO PARA ATUALIZAR DATAGRID
        ///
        public DataTable AtualizarDataGrid(string dado_fixo)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();    //  Conectar com o banco

                    sql = $"SELECT * FROM itens_venda WHERE id_venda = '{dado_fixo}' ORDER BY id_item ASC";

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


        /// 
        /// AÇÃO PARA ATUALIZAR DATAGRID
        ///
        public DataTable AtualizarDataGridATIVOS(string tabela, string identificacao)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    sql = $"SELECT * FROM {tabela} WHERE status = true ORDER BY {identificacao} ASC;";
                    conn.Open();    //  Conectar com o banco

                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, conn))
                    {
                        // Cria um DataTable para armazenar os dados
                        DataTable dataTable = new DataTable();

                        // Preenche o DataTable com os dados do banco de dados
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado ao conectar com o banco de dados.\n\n ATUALIZAR GRID: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }





        ///
        /// AÇÃO PARA DELETAR ITEM 
        ///
        public void DeletarItem(string tabela, string id_item, string id_venda)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    sql = $"DELETE FROM {tabela} WHERE id_item = '{id_item}' AND id_venda = '{id_venda}';";
                    conn.Open();    //  Conectar com o banco

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado ao conectar com o banco de dados.\n\n DELETAR ITEM: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeletarLinhasInseridas(string codigo)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Cria o comando SQL para deletar as linhas com o código especificado
                    string sql = "DELETE FROM itens_venda WHERE id_venda = @codigo";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Adiciona o parâmetro ao comando
                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro em caso de exceção
                MessageBox.Show("Algo deu errado ao deletar as linhas.\n\n DELETAR LINHAS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        ///
        /// AÇÃO PARA VOLTAR A QUANTIDADE DE PRODUTO
        ///
        public void UpdateQuantidade(string qntd_estoque, string id_produto)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    sql = $"UPDATE produtos SET qntd_estoque = '{qntd_estoque}' WHERE id_produto = '{id_produto}'";
                    conn.Open();    //  Conectar com o banco

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado ao conectar com o banco de dados.\n\n UPDATE QUANTIDADE: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







        ///
        /// AÇÃO PARA PUXAR A DESCRIÇÃO DA FOREING KEY ATRAVÉS DO ID
        ///
        public int PuxarQntdEstoque(string coluna, string tabela, string coluna_fixa, string id)
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
                            return reader.GetInt32(0);
                        }
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR DESCRIÇÃO:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public decimal PuxarNumeric(string coluna, string tabela, string coluna_fixa, string id)
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
                            return reader.GetDecimal(0);
                        }
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR DECIMAL:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int PuxarInt(string coluna, string tabela, string coluna_fixa, string id)
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
                            return reader.GetInt32(0);
                        }
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR DECIMAL:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }


        public int preencherDadosExistentesINT(string coluna, string tabela, string colunaFixa, string id)
        {

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open(); // Conectar com o banco

                    var sql = $"SELECT {coluna} FROM {tabela} WHERE {colunaFixa} = '{id}'";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Verifica se o valor da coluna não é nulo
                                if (!reader.IsDBNull(0))
                                {
                                    return reader.GetInt32(0);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PREENCHER DADOS EXISTENTES:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Lançar a exceção novamente para que o chamador possa lidar com ela
            }

            return 0; // Retornar null se nenhum dado for encontrado
        }


        public void AtualizarDadosItens(string id_item, string id_venda, string id_produto, string quantidade, string valor_unitario, string valor_total)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"UPDATE itens_venda SET id_item = '{id_item}', id_venda = '{id_venda}', id_produto = '{id_produto}', quantidade = {quantidade}, valor_unitario = {valor_unitario}, valor_total = '{valor_total}' WHERE id_venda = '{id_venda}';";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS ITENS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void DeleteItensTotal(string id_venda)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"DELETE FROM itens_venda WHERE id_venda = '{id_venda}';";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n REFRESH ITENS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public DataTable BuscarInt(string dadoUsuario, string coluna, string tabela, string id)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();    //  CONECTAR COM O BANCO

                sql = $"SELECT * FROM {tabela} WHERE {coluna} = {dadoUsuario} ORDER BY {id} ASC";
                cmd = new NpgsqlCommand(sql, conn);

                var reader = cmd.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();   //  Fechar conexão com o banco
                return dataTable;   //  Retornar a tabela com as seleções
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n BUSCAR: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }




    }
}