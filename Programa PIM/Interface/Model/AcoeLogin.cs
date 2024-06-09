using Interface.View;
using Npgsql;

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
        /// MÉTODO PARA VERIFICAR SE OS DADOS DE ACESSO ESTÃO CORRETOS OU NÃO
        /// 
        public bool StatusLogin(string inUsuario)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();    //  INICIAR CONEXÃO COM O BANCO

                    sql = $"SELECT status FROM login WHERE usuario = '{inUsuario}'";

                    cmd = new NpgsqlCommand(sql, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Verifica se o valor da coluna não é nulo
                            if (!reader.IsDBNull(0))
                            {
                                return reader.GetBoolean(0);
                            }
                        }
                    }
                }
                return false; // Retorna falso se não encontrar resultado válido
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retorna falso se não encontrar resultado válido
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
                    Menu menu1 = new Menu(inUsuario);
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
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();    //  INICIAR CONEXÃO COM O BANCO

                    string sql = "SELECT email FROM login WHERE usuario = @usuario";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("usuario", inUsuario);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) // Lê a primeira linha do resultado
                    {
                        string email = reader.GetString(0); // SALVA O EMAIL DO LOGIN NA VARIÁVEL
                        return email; // RETORNA O EMAIL PARA FAZER A VERIFICAÇÃO
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        /// 
        /// MÉTODO EXTRAI O CPF DO USUARIO ATRAVÉS DO LOGIN
        /// 
        public string ExtrairCpf(string inEmail)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT cpf FROM funcionarios WHERE email = '{inEmail}'";
                    cmd = new NpgsqlCommand(sql, conn);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) // Lê a primeira linha do resultado
                    {
                        string cpf = reader.GetString(0); // SALVA O EMAIL DO LOGIN NA VARIÁVEL
                        return cpf; // RETORNA O EMAIL PARA FAZER A VERIFICAÇÃO
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        /// 
        /// MÉTODO EXTRAI O DICA SENHA DO USUARIO ATRAVÉS DO LOGIN
        /// 
        public string ExtrairDicaSenha(string usuario)
        {
            using (conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                sql = $"SELECT dica_senha FROM login WHERE usuario = '{usuario}'";
                cmd = new NpgsqlCommand(sql, conn);

                var reader = cmd.ExecuteReader();
                if (reader.Read()) // Lê a primeira linha do resultado
                {
                    if (!reader.IsDBNull(0))
                    {
                        string dicaSenha = reader.GetString(0); // SALVA O VALOR DA PRIMEIRA COLUNA NA VARIÁVEL
                        return dicaSenha; // RETORNA O VALOR PARA FAZER A VERIFICAÇÃO
                    }
                }
            }
            return null;
        }
           

        ///
        /// MÉTODO PARA SALVAR PALAVRA CHAVE
        ///
        public void AlterarTabelaLogin(string coluna, string dado, string usuario)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string _dado = dado.ToUpper();
                    sql = $"UPDATE login SET {coluna} = '{_dado}' WHERE usuario = '{usuario}';";
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        ///
        /// MÉTODO PARA ALTERAR SENHA
        ///
        public int AlterarSenha(string inEmail, string inSenha)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = "SELECT bd_alterar_senha(@_email, @_nova_senha);";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_email", inEmail);
                    cmd.Parameters.AddWithValue("_nova_senha", inSenha);

                    int result = (int)cmd.ExecuteScalar();

                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();    //  INICIAR CONEXÃO COM O BANCO

                    //  FAZ A VERIFICAÇÃO NO BANCO ATRAVÉS DA FUNÇÃO u_redefinirSenha
                    sql = @"SELECT * FROM u_redefinir_Senha(:_email,:_palavra_chave)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_email", inEmail);
                    cmd.Parameters.AddWithValue("_palavra_chave", inPalavraChave);
                    int result = (int)cmd.ExecuteScalar();

                    return result;  //  RETORNA A VERIFICAÇÃO
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}