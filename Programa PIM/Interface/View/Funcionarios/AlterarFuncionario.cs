using Interface.Model;
using Interface.View.Funcionarios;
using Refit;
using System.Text.RegularExpressions;
using Testes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Interface.View
{
    public partial class AlterarFuncionario : Form
    {
        private TelaFuncionarios formPrincipal;
        private string? matricula;
        private TelaFuncionarios funcionarios;
        private Cargo_AlterarFunc cargo;

        public AlterarFuncionario(string matricula, string usuario, TelaFuncionarios func)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtMatricula.Text = matricula.PadLeft(6, '0');
            lblUsuario.Text = usuario;
            lblMatriculaInicial.Text = matricula.ToString();
            formPrincipal = func;
        }


        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB
        /// 
        private void InitializeTabOrder()
        {
            txtNome.TabIndex = 0;
            mskDtNasc.TabIndex = 1;
            txtEmail.TabIndex = 2;
            mskCpf.TabIndex = 3;
            mskTelefone.TabIndex = 4;
            txtCodCargo.TabIndex = 5;
            txtSalario.TabIndex = 6;
            mskCep.TabIndex = 7;
            txtLogradouro.TabIndex = 8;
            txtNumero.TabIndex = 9;
            txtComplemento.TabIndex = 10;
            txtBairro.TabIndex = 11;
            txtEstado.TabIndex = 12;
            txtCidade.TabIndex = 13;
            bttConfirmar.TabIndex = 14;
            bttCancelar.TabIndex = 15;
            txtMatricula.TabIndex = 16;
        }



        private void AlterarFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cargo != null && !cargo.IsDisposed)
            {
                cargo.Close();
            }
        }




        /// 
        /// EVENTO DO BOTÃO "CANCELAR"
        /// 
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        /// 
        /// EVENTO DO BOTÃO "CONFIRMAR"
        /// 
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            if (ValidarCamposObrigatorios())
            {
                if (MessageBox.Show("Tem certeza que deseja confirmar alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {

                    //  Verificar se funcionario é ativo ou não
                    bool funcAtivo = false;

                    //  Definir bool de status do funcionario conforme preenchido
                    if (checkFuncAtivo.CheckState == CheckState.Checked)
                    {
                        funcAtivo = true;
                    }


                    string matricula = txtMatricula.Text.PadLeft(6, '0');
                    string matriculaInicial = txtMatricula.Text.PadLeft(6, '0');
                    DateTime novaData = DateTime.ParseExact(mskDtNasc.Text, "dd/MM/yyyy", null);
                    string salario = txtSalario.Text.Replace(',', '.');


                    acoes.AtualizaDados(txtMatricula.Text, funcAtivo, txtNome.Text, txtEmail.Text, mskCpf.Text, mskTelefone.Text, txtCodCargo.Text, salario, mskCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtEstado.Text, txtCidade.Text);


                    //  Preencher os dados existentes DATAS
                    acoes.AtualizaDadosDATA("funcionarios", "data_nascimento", novaData, "matricula", matricula);



                    // VERIFICAÇÕES DE ALTERAÇÕES QUE IMPACTAM O LOGIN
                    bool? loginAtivo = acoes.PuxarDadoBOOL("status", "login", "email", txtEmail.Text);  //  Pegando bool salvo no login do func

                    //  Criação do novo usuario
                    string[] partes = txtNome.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Separa o nome por espaços, e tira os espaços em branco

                    string primeiroNome = partes[0].ToLower();  //  Salva o primeiro nome com letra minuscula
                    string ultimoNome = partes[partes.Length - 1].ToLower();    //  Salva ultimo nome com letra minuscula

                    string novoUsuario = $"{primeiroNome}.{ultimoNome}";    //  Cria string do usuario com o primeiro + segundo nome separados por um ponto

                    string usuarioSalvo = acoes.PuxarDado("usuario", "login", "email", txtEmail.Text);

                    if (novoUsuario != usuarioSalvo)
                    {
                        acoes.AtualizarAcessoUsuario("usuario", novoUsuario, txtEmail.Text);
                        MessageBox.Show($"O nome do funcionário foi alterado.\nSeu usuário passou a ser: {novoUsuario}", "Usuário alterado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    if (funcAtivo == loginAtivo && funcAtivo == false)
                    {
                        MessageBox.Show("Usuário continua inativado!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (funcAtivo != loginAtivo && funcAtivo == true)
                    {
                        acoes.AtualizarAcessoUsuarioBOOL("status", funcAtivo, txtEmail.Text);
                        MessageBox.Show("O usuário foi reativado!\nAgora ele poderá acessar o sistema", "Usuário reativado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (funcAtivo != loginAtivo && funcAtivo == false)
                    {
                        acoes.AtualizarAcessoUsuarioBOOL("status", funcAtivo, txtEmail.Text);
                        MessageBox.Show("O usuário foi inativado!\nO acesso ao sistema foi bloqueado", "Usuário inativado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    formPrincipal.AtualizarDataGridView();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Algum dado obrigatório não foi preenchido, favor verificar se todos os campos com asterisco (*) foram preenchidos.", "Erro de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// 
        /// EVENTO PARA PREENCHER OS DADOS PARA ALTERAÇÃO
        /// 
        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            string matricula = txtMatricula.Text.PadLeft(6, '0');   //  Garante que a matrícula seja inserida com os 6 dígitos no banco


            //  Puxa o status salvo no banco
            bool? funcAtivo = acoes.PuxarDadoBOOL("status", "funcionarios", "matricula", matricula); 

            //  Preenche o check conforme salvo no banco
            if (funcAtivo.HasValue && funcAtivo.Value == true)
            {
                checkFuncAtivo.CheckState = CheckState.Checked;
            }
            else
            {
                checkFuncAtivo.CheckState = CheckState.Unchecked;
            }


            //  Converte o salário para string para preencher o campo corretamente
            string salario = acoes.preencherDadosExistentesNUMERIC("salario", "funcionarios", "matricula", matricula).ToString();

            //  Preencher os dados existentes
            txtNome.Text = acoes.preencherDadosExistentes("nome", "funcionarios", "matricula", matricula);
            txtEmail.Text = acoes.preencherDadosExistentes("email", "funcionarios", "matricula", matricula);
            mskCpf.Text = acoes.preencherDadosExistentes("cpf", "funcionarios", "matricula", matricula);
            mskTelefone.Text = acoes.preencherDadosExistentes("telefone", "funcionarios", "matricula", matricula);
            txtCodCargo.Text = acoes.preencherDadosExistentes("cod_cargo", "funcionarios", "matricula", matricula);
            txtSalario.Text = salario;
            mskCep.Text = acoes.preencherDadosExistentes("cep", "funcionarios", "matricula", matricula);
            txtLogradouro.Text = acoes.preencherDadosExistentes("logradouro", "funcionarios", "matricula", matricula);
            txtNumero.Text = acoes.preencherDadosExistentes("numero", "funcionarios", "matricula", matricula);
            txtComplemento.Text = acoes.preencherDadosExistentes("complemento", "funcionarios", "matricula", matricula);
            txtBairro.Text = acoes.preencherDadosExistentes("bairro", "funcionarios", "matricula", matricula);
            txtEstado.Text = acoes.preencherDadosExistentes("estado", "funcionarios", "matricula", matricula);
            txtCidade.Text = acoes.preencherDadosExistentes("cidade", "funcionarios", "matricula", matricula);
            txtDescCargo.Text = acoes.PuxarDescCargo(txtCodCargo.Text);

            //  Preencher os dados existentes DATAS
            DateTime? dataNascimento = acoes.preencherDadosExistentesDATA("data_nascimento", "funcionarios", "matricula", matricula);
            if (dataNascimento.HasValue)
            {
                mskDtNasc.Text = dataNascimento.Value.ToString("dd/MM/yyyy"); // Formata a data conforme necessário
            }
        }



        /// 
        /// AÇÃO PARA GARANTIR QUE O DADOS OBRIGATÓRIOS SEJAM INSERIDOS
        /// 
        private bool ValidarCamposObrigatorios()
        {
            return !string.IsNullOrWhiteSpace(txtMatricula.Text)
                && !string.IsNullOrWhiteSpace(txtNome.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(mskCpf.Text)
                && !string.IsNullOrWhiteSpace(txtCodCargo.Text)
                && !string.IsNullOrWhiteSpace(txtSalario.Text)
                && !string.IsNullOrWhiteSpace(mskDtNasc.Text);
        }



        ///
        /// AÇÕES PARA VALIDAR SE CAMPOS FORAM INSERIDOS CORRETAMENTE
        ///
        private bool ValidarCampoData()
        {
            string dataTexto = mskDtNasc.Text;

            string dataNumerico = new string(dataTexto.Where(char.IsDigit).ToArray());

            if (dataNumerico.Length != 0)
            {
                if (DateTime.TryParse(mskDtNasc.Text, out DateTime data))
                {
                    // Verifica se o ano está dentro de um intervalo aceitável (por exemplo, de 1900 a 2100)
                    if (data.Year >= 1900 && data.Year <= 2006)
                    {
                        // Verifica se o dia corresponde ao mês e ao ano
                        if (data.Day >= 1 && data.Day <= DateTime.DaysInMonth(data.Year, data.Month))
                        {
                            // A data é válida
                            return true;
                        }
                    }
                }
                // Se não for possível converter para DateTime ou se a data não for válida
                return false;
            }
            return true;
        }

        private bool ValidarCampoEmail()
        {
            string email = txtEmail.Text;

            // Se o email for nulo ou vazio, considera como válido
            if (string.IsNullOrWhiteSpace(email))
            {
                return true;
            }

            // Verifica se o email contém o caractere '@' uma única vez e não está no início ou no final
            int atIndex = email.IndexOf('@');
            if (atIndex > 0 && atIndex < email.Length - 1 && email.LastIndexOf('@') == atIndex)
            {
                return true; // Email válido
            }

            return false; // Email inválido
        }

        private bool ValidarCampoCpf()
        {
            string cpf = mskCpf.Text;

            // Remove caracteres não numéricos do CPF
            string cpfNumerico = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpfNumerico.Length != 0)
            {
                // Verifica se o CPF possui 11 dígitos
                if (cpfNumerico.Length != 11)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        private bool ValidarCampoTelefone()
        {
            string telefone = mskTelefone.Text;

            // Remove caracteres não numéricos do telefone
            string telefoneNumerico = new string(telefone.Where(char.IsDigit).ToArray());

            // Se o campo telefone estiver vazio, considera como válido
            if (string.IsNullOrWhiteSpace(telefoneNumerico))
            {
                return true;
            }

            // Verifica se o telefone possui o número correto de dígitos (incluindo o DDD)
            if (telefoneNumerico.Length == 11 || telefoneNumerico.Length == 10)
            {
                return true; // Telefone válido
            }

            return false; // Telefone inválido
        }

        private bool ValidarCampoCep()
        {
            string cep = mskCep.Text;

            // Remove caracteres não numéricos do CEP
            string cepNumerico = new string(cep.Where(char.IsDigit).ToArray());

            // Se o campo CEP estiver vazio, considera como válido
            if (string.IsNullOrWhiteSpace(cepNumerico))
            {
                return true;
            }

            // Verifica se o CEP tem o número correto de dígitos
            if (cepNumerico.Length == 8)
            {
                return true; // CEP válido
            }

            return false; // CEP inválido
        }

        private bool ValidarCampoCargo()
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            string tabela = acoes.PuxarDescCargo(txtCodCargo.Text);

            return !string.IsNullOrWhiteSpace(tabela);            
        }



        /// 
        /// EVENTO PARA PUXAR DADOS ENDEREÇO ATRAVÉS DO CEP JUNTO COM A VERIFICAÇÃO DE INSERÇÃO
        /// 
        private void mskCep_Leave(object sender, EventArgs e)
        {
            if (mskCep.Text != null)
            {
                bool validacao = ValidarCampoCep();
                if (validacao == false)
                {
                    MessageBox.Show("Está faltando dígito(s)!","Cep inválido");
                    mskCep.Focus();
                }
                else
                {
                    BuscarCep(mskCep.Text);
                }
            }
        }

        //  Método para os dados da API e preencher os campos
        async Task BuscarCep(string cep)
        {
            try
            {
                var cepBuscar = RestService.For<ICepApiService>("https://viacep.com.br/");
                var endereco = await cepBuscar.GetAddressAsync(cep);

                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Localidade;
                txtEstado.Text = endereco.Uf;
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha! \n" + e);
            }
        }



        ///
        /// EVENTOS PARA NÃO PERMITIR QUE O USUÁRIO INSIRA OS DADOS ERRADOS
        ///
        private void mskDtNasc_Leave(object sender, EventArgs e)
        {
            if (mskDtNasc.Text != null)
            {
                bool validacao = ValidarCampoData();
                if (validacao == false)
                {
                    MessageBox.Show("Data inválida!", "Data inválida");
                    mskDtNasc.Focus();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != null)
            {
                bool validacao = ValidarCampoEmail();
                if (validacao == false)
                {
                    MessageBox.Show("Não tem o caractere '@'\n\nOu ele se encontra mais um caractere '@'", "Email inválido");
                    txtEmail.Focus();
                }
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            if (mskCpf.Text != null)
            { 
                bool validacao = ValidarCampoCpf();
                if (validacao == false)
                {
                    MessageBox.Show("Está faltando dígito(s)!","Cpf inválido");
                    mskCpf.Focus();
                }
            }
        }

        private void mskTelefone_Leave(object sender, EventArgs e)
        {
            if (mskTelefone.Text != null)
            {
                bool validacao = ValidarCampoTelefone();
                if (validacao == false)
                {
                    MessageBox.Show("Está faltando dígito(s)!","Telefone inválido");
                    mskTelefone.Focus();
                }
            }
        }

        private void txtCodCargo_Leave(object sender, EventArgs e)
        {
            if (txtCodCargo.Text != null)
            {
                bool validacao = ValidarCampoCargo();
                if (validacao == false)
                {
                    MessageBox.Show("Cargo inserido não cadastrado!", "Cargo inválido");
                    txtCodCargo.Focus();
                }

            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            // Remover espaços em branco no início e no fim
            string salarioTexto = txtSalario.Text.Trim();

            // Separar a parte inteira da parte decimal
            string[] partes = salarioTexto.Split(new[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Verificar se a parte inteira tem até 8 dígitos
            string parteInteira = partes[0];

            // Verificar se a parte decimal tem até 2 dígitos
            string parteDecimal = "";
            if (partes.Length > 1)
            {
                parteDecimal = partes[1];
            }

            // Verificar se há uma parte inteira
            if (Regex.IsMatch(salarioTexto, @"[a-zA-Z]"))
            {
                MessageBox.Show("Salário não pode conter letras.", "Salário inválido");
                txtSalario.Focus();
            }
            else if (parteInteira.Length > 8)
            {
                MessageBox.Show("O valor de salário não pode ter mais de 8 dígitos antes da vírgula.", "Salário inválido");
                txtSalario.Focus();
            }
            else if (parteDecimal.Length > 2)
            {
                MessageBox.Show("O valor de salário não pode ter mais de 2 dígitos depois da vírgula.", "Erro de validação");
                txtSalario.Focus();
            }
        }



        /// 
        /// EVENTO DA BUSCA CARGO
        /// 
        //  Evento para quando cllicar no botão de busca cargo
        private void picBuscaCargo_Click(object sender, EventArgs e)
        {
            Cargo_AlterarFunc telaCargo = new Cargo_AlterarFunc(this);
            telaCargo.Show();
        }

        //  Método para pegar o código selecionado na tela de busca cargo
        public void SetCargoCode(string codigo)
        {
            txtCodCargo.Text = codigo;
        }

        //  Método para puxar a descrição do cargo quando o código mudas
        private void txtCodCargo_TextChanged(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            txtDescCargo.Text = acoes.PuxarDescCargo(txtCodCargo.Text);
        }



    



        ////////////////////////////////////////////    BOTÕES DE MANIPULAÇÃO DA TELA   ////////////////////////////////////////////



        ///
        /// ANIMAÇÃO DO CURSOR EM CIMA DOS BOTÕES 
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;



        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"
        /// 
        private void bttMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //  Alterar os botões visiveis
            bttRestaurar.Visible = true;
            bttMaximizar.Visible = false;

            /*  Redimensionar icones
            faixadaVerde.Size = new Size(1920, 200);
            dataGridView1.Size = new Size(1840, 740);
            picIcone.Size = new Size(155, 139);

            float newSize = 20.0f;
            Font newFont = new Font(lblAlterarFuncionarios.Font.FontFamily, newSize, lblAlterarFuncionarios.Font.Style);
            lblAlterarFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 228);
            bttAlterar.Location = new Point(180, 228);
            bttDeletar.Location = new Point(320, 228);
            dataGridView1.Location = new Point(40, 296);
            picIcone.Location = new Point(42, 61);
            lblAlterarFuncionarios.Location = new Point(208, 134);*/
        }



        /// 
        /// EVENTO BOTÃO "RESTAURAR"
        /// 
        private void bttRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            //  Altera os botões visiveis
            bttRestaurar.Visible = false;
            bttMaximizar.Visible = true;

            //  Centraliza a tela
            //this.CenterToScreen();

            /*  Redimensionar icones
            ClientSize = new Size(960, 540);
            faixadaVerde.Size = new Size(960, 125);
            dataGridView1.Size = new Size(880, 280);
            picIcone.Size = new Size(100, 84);

            float newSize = 15.0f;
            Font newFont = new Font(lblAlterarFuncionarios.Font.FontFamily, newSize, lblAlterarFuncionarios.Font.Style);
            lblAlterarFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 153);
            bttAlterar.Location = new Point(180, 153);
            bttDeletar.Location = new Point(320, 153);
            dataGridView1.Location = new Point(40, 221);
            picIcone.Location = new Point(42, 41);
            lblAlterarFuncionarios.Location = new Point(151, 80);*/
        }



        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void bttMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
