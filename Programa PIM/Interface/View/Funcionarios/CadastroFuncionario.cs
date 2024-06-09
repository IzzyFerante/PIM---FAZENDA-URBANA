using Interface.Model;
using Refit;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using Testes;

namespace Interface.View.Funcionarios
{
    public partial class CadastroFuncionario : Form
    {
        private TelaFuncionarios formPrincipal;
        private TelaFuncionarios funcionarios;
        private Cargo cargo;

        public CadastroFuncionario(string usuario, TelaFuncionarios func)
        {
            InitializeComponent();
            InitializeTabOrder();

            lblUsuario.Text = usuario;
            formPrincipal = func;
        }


        /// 
        /// Evento para definir a ordem do TAB
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



        private void CadastrarFuncionario_FormClosed(object sender, FormClosedEventArgs e)
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
            if (MessageBox.Show("Tem certeza que deseja cancelar inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //  Animação do cursor botão "Cancelar"
        private void bttCancelar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttCancelar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


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
                && !string.IsNullOrWhiteSpace(mskDtNasc.Text);
        }


        /// 
        /// EVENTO DO BOTÃO "CONFIRMAR"
        /// 
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObrigatorios())
            {
                AcoesFuncionarios acoes = new AcoesFuncionarios();

                //  Verificar se funcionario é ativo ou não
                bool funcAtivo = false;

                //  Definir bool de status do funcionario conforme preenchido
                if (checkFuncAtivo.CheckState == CheckState.Checked)
                {
                    funcAtivo = true;
                }
                else
                {
                    MessageBox.Show("Usuário sinalizado como inativo, então acesso ao sistema não está permitido");
                }

                string matricula = txtMatricula.Text.PadLeft(6, '0');
                DateTime dataNascimento = DateTime.ParseExact(mskDtNasc.Text, "dd/MM/yyyy", null);
                string salario = txtSalario.Text.Replace(',', '.');

                //  Insere cadastro no banco
                acoes.CadastrarDado(funcAtivo, txtMatricula.Text, txtNome.Text, dataNascimento, txtEmail.Text, mskCpf.Text, mskTelefone.Text, txtCodCargo.Text, salario, mskCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtEstado.Text, txtCidade.Text);

                string senha = acoes.senhaUsuario(mskCpf.Text);
                string usuario = acoes.usuario(txtNome.Text);

                MessageBox.Show($"Usuário criado para acesso ao sistema.\n\nUsuário: {usuario}\nSenha: {senha}");

                formPrincipal.AtualizarDataGridView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Algum dado obrigatório não foi preenchido, favor verificar se todos os campos com asterisco (*) foram preenchidos.", "Erro de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Animação do cursor botão "Confirmar"
        private void bttConfirmar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttConfirmar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO PARA PUXAR CEP DA API
        /// 
        private void mskCep_Leave(object sender, EventArgs e)
        {
            string cep = mskCep.Text;

            string cepNumerico = new string(cep.Where(char.IsDigit).ToArray());

            // Se o campo CEP estiver vazio, considera como válido
            if (!string.IsNullOrWhiteSpace(cepNumerico))
            {
                bool validacao = ValidarCampoCep();
                if (validacao == false)
                {
                    MessageBox.Show("Está faltando dígito(s)!", "Cep inválido");
                    mskCep.Focus();
                }
                else
                {
                    BuscarCep(mskCep.Text);
                }
            }
        }

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
        /// EVENTO DA BUSCA CARGO
        /// 
        private void picBuscaCargo_Click(object sender, EventArgs e)
        {
            Cargo telaCargo = new Cargo(this);
            telaCargo.Show();
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
        /// EVENTOS PARA AVISAR QUE O CAMPO ESTA INCORRETO
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
                    MessageBox.Show("Está faltando dígito(s)!", "Cpf inválido");
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
                    MessageBox.Show("Está faltando dígito(s)!", "Telefone inválido");
                    mskTelefone.Focus();
                }
            }
        }

        private void txtCodCargo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCargo.Text) != true)
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

            string parteDecimal = "";
            if (partes.Length > 1)
            {
                // Verificar se a parte decimal tem até 2 dígitos
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




        public void SetCargoCode(string codigo)
        {
            txtCodCargo.Text = codigo;
        }


        private void txtCodCargo_TextChanged(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            txtDescCargo.Text = acoes.PuxarDescCargo(txtCodCargo.Text);
        }








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

        //  Animação do cursor botão "Maximizar"
        private void bttMaximizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttMaximizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


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

        //  Animação do cursor botão "Restaurar"
        private void bttRestaurar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttRestaurar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void bttMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  Animação do cursor botão "Minimizar"
        private void bttMinimizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttMinimizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO PARA QUANDO ABRIR TELA O CHECK DE FUNCIONARIO ATIVO JÁ ESTAR ASSINALADO
        ///
        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            checkFuncAtivo.CheckState = CheckState.Checked;

            string ultimoId = acoes.NovaMatricula("funcionarios", "matricula");
            string novaMatricula = "";

            if (!string.IsNullOrEmpty(ultimoId))
            {
                int conversaoId = int.Parse(ultimoId);
                novaMatricula = (conversaoId + 1).ToString().PadLeft(6, '0');
            }
            else
            {
                novaMatricula = "000001";
            }

            txtMatricula.Text = novaMatricula;
        }





    }
}
