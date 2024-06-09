using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class AcoesProducao
    {
        /// 
        /// CONEXÃO COM O BANCO
        /// 
        private string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "bella123", "fazenda_urbana");
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private string sql = null;




        public int NovoCodigo(string tabela, string coluna)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT MAX({coluna}) AS ultima_matricula FROM {tabela};";
                    cmd = new NpgsqlCommand(sql, conn);

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
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n NOVO CODIGO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }



        ///
        /// AÇÕES PARA CADASTRAR DADOS NO BANCO
        ///
        public void CadastrarDados(string id_producao, string id_produto, DateTime dtPlantio, DateTime dtColheita, string quantidade, string area)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"INSERT INTO producao (id_producao, id_produto, data_plantio, data_prevista_colheita, qntd_plantada, area) VALUES ({id_producao}, '{id_produto}', {dtPlantio}, {dtColheita}, {quantidade}, '{area}');";

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
        public void AtualizarDados(string id_producao, string id_produto, DateTime dtPlantio, DateTime dtColheita, string quantidade, string area)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"UPDATE produtos SET id_produto = '{id_produto}', data_plantio = {dtPlantio}, data_prevista_colheita = {dtColheita}, qntd_plantada = {quantidade}, area = '{area}' WHERE id_producao = '{id_producao}';";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        public string PuxarDescArea(string id)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT nome FROM area WHERE id_area = {id};";

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
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR NOME ÁREA:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public void AtualizaDadosArea(string tabela, string coluna, string dado, string colunaFixa, string id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"UPDATE {tabela} SET {coluna} = '{dado}' WHERE {colunaFixa} = {id};";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS AREA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CadastrarArea(string id_area, string nome_area)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"INSERT INTO area (id_area, nome) VALUES ('{id_area}', '{nome_area}');";

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n CADASTRAR AREA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
