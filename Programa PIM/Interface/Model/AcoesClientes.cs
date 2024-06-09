using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class AcoesClientes
    {
        /// 
        /// CONEXÃO COM O BANCO
        /// 
        private string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "bella123", "fazenda_urbana");
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private string sql = null;



        ///
        /// AÇÕES PARA CADASTRAR DADOS NO BANCO
        ///
        public void CadastrarDados(bool status, string id, string nome, string cpf, string cnpj, string email, string telefone1, string telefone2, string cep, string logradouro, string numero, string complemento, string bairro, string estado, string cidade)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"INSERT INTO clientes (status, id_cliente, nome, cpf, cnpj, email, telefone, telefone_secundario, cep, logradouro, numero, complemento, bairro, estado, cidade) VALUES  ({status}, '{id}', '{nome}', '{cpf}', '{cnpj}', '{email}', '{telefone1}', '{telefone2}', '{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{estado}', '{cidade}');";

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
        public void AtualizaDados(string id, bool status, string nome, string cpf, string cnpj, string email, string telefone1, string telefone2, string cep, string logradouro, string numero, string complemento, string bairro, string estado, string cidade)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString)) //  Garante que a conexão com o banco seja fechada
                {
                    conn.Open();
                    sql = $"UPDATE clientes SET status = {status}, nome = '{nome}', cpf = '{cpf}', cnpj = '{cnpj}', email = '{email}', telefone = '{telefone1}', telefone_secundario = '{telefone2}', cep = '{cep}', logradouro = '{logradouro}', numero = '{numero}', complemento = '{complemento}', bairro = '{bairro}', estado = '{estado}', cidade = '{cidade}' WHERE id_cliente = '{id}';";

                    var cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
