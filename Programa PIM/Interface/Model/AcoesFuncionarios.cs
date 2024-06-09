using Npgsql;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.ConstrainedExecution;

namespace Interface.Model
{
    public class AcoesFuncionarios
    {
        /// 
        /// CONEXÃO COM O BANCO
        /// 
        private string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "localhost", 5432, "postgres", "bella123", "fazenda_urbana");
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private string sql = null;


        /// 
        /// AÇÃO PARA PUXAR A ULTIMA MATRICULA E RETORNAR A PRÓXIMA JÁ
        ///
        public string NovaMatricula(string tabela, string coluna)
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
                                return reader.GetString(0);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n NOVA MATRICULA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        /// 
        /// AÇÃO PARA BUSCAR DADO NO BANCO
        ///
        public DataTable Buscar(string dadoUsuario, string coluna, string tabela, string id)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();    //  CONECTAR COM O BANCO

                sql = $"SELECT * FROM {tabela} WHERE {coluna} LIKE '%{dadoUsuario}%' ORDER BY {id} ASC";
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


        /// 
        /// AÇÃO PARA ATUALIZAR DATAGRID
        ///
        public DataTable AtualizarDataGrid(string tabela, string identificacao)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    sql = $"SELECT * FROM {tabela} ORDER BY {identificacao} ASC;";
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
        /// AÇÃO PARA BUSCAR DADOS ESPECIFICOS NO BANCO PARA ALTERAÇÃO
        ///
        public string preencherDadosExistentes(string coluna, string tabela, string colunaFixa, string id)
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
                                    return reader.GetString(0);
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

            return null; // Retornar null se nenhum dado for encontrado
        }

        //  A mesma ação da classe de cima porém para datas
        public DateTime? preencherDadosExistentesDATA(string coluna, string tabela, string colunaFixa, string id)
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
                                    return reader.GetDateTime(0);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PREENCHER DADOS EXISTENTES DATA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Lançar a exceção novamente para que o chamador possa lidar com ela
            }

            return null; // Retornar null se nenhum dado for encontrado ou se a coluna for nula
        }

        //  A mesma ação da classe de cima porém para numeric
        public decimal? preencherDadosExistentesNUMERIC(string coluna, string tabela, string colunaFixa, string id)
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
                                    return reader.GetDecimal(0);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PREENCHER DADOS EXISTENTES NUMERIC: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Lançar a exceção novamente para que o chamador possa lidar com ela
            }

            return null; // Retornar null se nenhum dado for encontrado
        }

        //  A mesma ação da classe de cima porém para numeric
        public bool? preencherDadosExistentesBOOL(string coluna, string tabela, string colunaFixa, string id)
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
                            bool result = reader.GetBoolean(0);
                            MessageBox.Show($"Bool: {result}");
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PREENCHER DADOS EXISTENTES BOOL: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        /// 
        /// AÇÃO PARA ATUALIZAR OS DADOS NO BANCO APÓS A ALTERAÇÃO
        ///
        public void AtualizaDados(string matricula, bool status, string nome, string email, string cpf, string telefone, string cod_cargo, string salario, string cep, string logradouro, string numero, string complemento, string bairro, string estado, string cidade)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"UPDATE funcionarios SET status = {status}, nome = '{nome}', email = '{email}', cpf = '{cpf}', telefone = '{telefone}', cod_cargo = '{cod_cargo}', salario = '{salario}', cep = '{cep}', logradouro = '{logradouro}', numero = '{numero}', complemento = '{complemento}', bairro = '{bairro}', estado = '{estado}', cidade = '{cidade}' WHERE matricula = '{matricula}';";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR DADOS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //  A mesma ação da classe de cima porém para datas
        public void AtualizaDadosDATA(string tabela, string coluna, DateTime dado, string colunaFixa, string id)
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


        ///
        /// AÇÃO PARA ATUALIZAR TABELA CARGO
        ///
        public void AtualizaDadosCARGO(string tabela, string coluna, string dado, string colunaFixa, string id)
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


        /// 
        /// AÇÃO PARA INSERIR OS DADOS NO BANCO APÓS O CADASTRO
        ///
        public void CadastrarDado(bool status, string matricula, string nome, DateTime data_nascimento, string email, string cpf, string telefone, string cod_cargo, string salario, string cep, string logradouro, string numero, string complemento, string bairro, string estado, string cidade)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"INSERT INTO funcionarios (status, matricula, nome, data_nascimento, email, cpf, telefone, cod_cargo, salario, cep, logradouro, numero, complemento, bairro, estado, cidade) VALUES ({status}, '{matricula}', '{nome}', '{data_nascimento}', '{email}', '{cpf}', '{telefone}', '{cod_cargo}', '{salario}', '{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{estado}', '{cidade}');";

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n CADASTRAR DADOS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CadastrarCargo(string id_cargo, string desc)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"INSERT INTO cargo (cod_cargo, nome_cargo) VALUES ('{id_cargo}', '{desc}');";

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n CADASTRAR CARGO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ///
        /// AÇÃO PARA ATIVAR OU INATIVAR ACESSO USUARIO
        ///
        public void StatusUsuario(bool statusFunc, string emailFunc)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    sql = $"UPDATE login SET status = {statusFunc} WHERE email = {emailFunc}";

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\nSTATUS USUARIO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ///
        /// AÇÃO PARA ATUALIZAR ACESSO USUARIO
        ///
        public void AtualizarAcessoUsuario(string coluna, string dado, string email)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"UPDATE login SET {coluna} = '{dado}' WHERE email = '{email}'";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR ACESSO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AtualizarAcessoUsuarioBOOL(string coluna, bool dado, string email)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"UPDATE login SET {coluna} = {dado} WHERE email = '{email}'";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n ATUALIZAR ACESSO BOOL: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ///
        /// AÇÃO PARA PUXAR UM DADO ESPECIFICO DO BANCO
        ///
        public string PuxarDado(string colunaDado, string tabela, string colunaFixa, string dadoFixo)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT {colunaDado} FROM {tabela} WHERE {colunaFixa} = '{dadoFixo}'";
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
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR DADO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //  Mesma coisa que o de cima porem para booleano
        public bool? PuxarDadoBOOL(string colunaDado, string tabela, string colunaFixa, string dadoFixo)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT {colunaDado} FROM {tabela} WHERE {colunaFixa} = '{dadoFixo}'";
                    cmd = new NpgsqlCommand(sql, conn);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Verifica se o valor da coluna não é nulo
                        if (!reader.IsDBNull(0))
                        {
                            return reader.GetBoolean(0);
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR BOOL:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        ///
        /// AÇÃO PARA PUXAR A DESCRIÇÃO DO CARGO ATRAVÉS DO CODIGO
        ///
        public string PuxarDescCargo(string codCargo)
        {
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    sql = $"SELECT nome_cargo FROM cargo WHERE cod_cargo = '{codCargo}';";

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
                MessageBox.Show("Algo deu errado, tente novamente\n\n PUXAR DESCRIÇÃO CARGO:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        ///
        /// AÇÃO PARA DEFINIR USUARIO E SENHA
        ///
        public string senhaUsuario(string cpf)
        {
            return cpf.Replace(".", "").Replace("-", "");
        }

        public string usuario(string nome)
        {
            string[] partes = nome.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Separa o nome por espaços, e tira os espaços em branco

            string primeiroNome = partes[0].ToLower();  //  Salva o primeiro nome com letra minuscula
            string ultimoNome = partes[partes.Length - 1].ToLower();    //  Salva ultimo nome com letra minuscula

            string usuarioAcesso = $"{primeiroNome}.{ultimoNome}";
            return usuarioAcesso;
        }
    }
}
