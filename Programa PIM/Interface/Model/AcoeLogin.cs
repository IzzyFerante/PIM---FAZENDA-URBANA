using Interface.View;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Interface.View.RedefinirSenha;

namespace Interface.Model
{
    public class AcoeLogin
    {
        /// 
        /// CONEXÃO COM O BANCO
        /// 
        private string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "bella123", "fazenda_urbana");
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private string sql = null;
        

        /// 
        /// MÉTODO PARA VERIFICAR SE OS DADOS DE ACESSO ESTÃO CORRETOS OU NÃO
        /// 
        public int AcessoLogin(string inUsuario, string inSenha)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();    //  INICIAR CONEXÃO COM O BANCO

                sql = @"SELECT * FROM u_login(:_usuario,:_senha)";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_usuario", inUsuario);
                cmd.Parameters.AddWithValue("_senha", inSenha);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();   //  FECHAR CONEXÃO COM O BANCO
                return result;  // RETORNA O RESULTADO DA FUNÇÃO
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        ///
        /// MÉTODO PARA VERIFICAR SE É PRIMEIRO ACESSO
        ///  
        public void PrimeiroAcesso(string inUsuario, string inSenha)
        {
            try
            {
                if (inSenha.Length > 8) //  É O PRIMEIRO ACESSO, pois a senha oficial tem apenas 8 caracteres
                {
                    PrimeiroAcesso primeiroAcesso = new PrimeiroAcesso(inUsuario);
                    MessageBox.Show("Olá! Seja bem vindo ao UrbanFarm Manager :)\n\nComo é o seu primeiro acesso, iremos te redirecionar para você criar a sua senha oficial.", "Primeiro Acesso");
                    primeiroAcesso.Show();
                }
                else    // NÃO É O PRIMEIRO ACESSO
                {
                    Menu menu1 = new Menu();
                    MessageBox.Show("Login realizado com sucesso!", "Acesso permitido");
                    menu1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// 
        /// MÉTODO EXTRAI O EMAIL DO USUARIO ATRAVÉS DO LOGIN
        /// 
        public string ExtrairEmail(string inUsuario)
        {
            conn = new NpgsqlConnection(connString);
            conn.Open();    //  INICIAR CONEXÃO COM O BANCO

            string sql = "SELECT e_mail FROM login WHERE usuario = @usuario";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("usuario", inUsuario);

            var reader = cmd.ExecuteReader();
            if (reader.Read()) // Lê a primeira linha do resultado
            {
                string email = reader.GetString(0); // SALVA O EMAIL DO LOGIN NA VARIÁVEL
                return email; // RETORNA O EMAIL PARA FAZER A VERIFICAÇÃO
            }
            
            conn.Close(); // FECHA CONEXÃO COM O BANCO
            return null;
        }


        ///
        /// MÉTODO PARA ALTERAR SENHA
        ///
        public int AlterarSenha(string inEmail, string inSenha)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                sql = "SELECT bd_alterar_senha(@p_email, @p_nova_senha);";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("p_email", inEmail);
                cmd.Parameters.AddWithValue("p_nova_senha", inSenha);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        /// 
        /// MÉTODO PARA VERIFICAÇÃO DE REDEFINIR SENHA
        ///
        public int RedefinirSenha(string inEmail, string inPalavraChave)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();    //  INICIAR CONEXÃO COM O BANCO

                //  FAZ A VERIFICAÇÃO NO BANCO ATRAVÉS DA FUNÇÃO u_redefinirSenha
                sql = @"SELECT * FROM u_redefinir_Senha(:_email,:_palavra_chave)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_email", inEmail);
                cmd.Parameters.AddWithValue("_palavra_chave", inPalavraChave);
                int result = (int)cmd.ExecuteScalar();

                conn.Close();   //  FECHA CONEXÃO COM O BANCO
                return result;  //  RETORNA A VERIFICAÇÃO
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}