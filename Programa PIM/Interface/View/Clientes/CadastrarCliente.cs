using Interface.Model;
using Interface.View.Fornecedores;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Interface.View.Clientes
{
    public partial class CadastrarCliente : Form
    {
        private TelaClientes formPrincipal;
        private TelaClientes funcionarios;

        public CadastrarCliente(string usuarioConectado, TelaClientes clientes)
        {
            InitializeComponent();
            InitializeTabOrder();

            lblUsuario.Text = usuarioConectado;     //  Mantém salvo o usuario que está ativo para a informação não se perder quando voltar ao menu
            formPrincipal = clientes;     // Permite passar informações entre esse form e o form chamado 
        }


        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB
        /// 
        private void InitializeTabOrder()
        {
            txtNome.TabIndex = 0;
            mskCpf.TabIndex = 1;
            mskCnpj.TabIndex = 2;
            txtEmail.TabIndex = 3;
            mskTelefone1.TabIndex = 4;
            mskTelefone2.TabIndex = 5;
            mskCep.TabIndex = 6;
            txtLogradouro.TabIndex = 7;
            txtNumero.TabIndex = 8;
            txtComplemento.TabIndex = 9;
            txtBairro.TabIndex = 10;
            txtEstado.TabIndex = 11;
            txtCidade.TabIndex = 12;
            bttConfirmar.TabIndex = 13;
            bttCancelar.TabIndex = 14;
        }


        /// 
        /// EVENTO PARA QUANDO ABRIR TELA 
        ///
        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            //  ABRIR A TELA COM O CHECK JA SELECIONADO 
            checkClienteAtivo.CheckState = CheckState.Checked;

            string ultimoId = acoes.NovaMatricula("clientes", "id_cliente");
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

            txtId.Text = novaMatricula;
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


        /// 
        /// EVENTO DO BOTÃO "CONFIRMAR"
        /// 
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            AcoesClientes acoes = new AcoesClientes();

            if (ValidarCamposObrigatorios() && ValidarCamposObrigatoriosCPF_CNPJ())    //  Chama o método criado mais abaixo para validar se os campo obrigratórios foram preenchidos
            {
                if (MessageBox.Show("Confirmar inclusão de cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)    //  Garante que o botão não tenha sido apertado por engano
                {
                    //  DEFINIR BOOL DE STATUS CONFORME PREENCHIDO
                    bool clienteAtivo = false; //  Cria variável para salvar a informação
                    if (checkClienteAtivo.CheckState == CheckState.Checked)
                    {
                        clienteAtivo = true;
                    }


                    string idCliente = txtId.Text.PadLeft(6, '0');   //  Garante que a identificação tenha os zeros anteriores


                    acoes.CadastrarDados(clienteAtivo, txtId.Text, txtNome.Text, mskCpf.Text, mskCnpj.Text, txtEmail.Text, mskTelefone1.Text, mskTelefone2.Text, mskCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtEstado.Text, txtCidade.Text);

                    //  Avisa usuário caso o fornecedor tenha sido cadastrado como inativo
                    if (clienteAtivo == false)
                    {
                        MessageBox.Show("Cliente cadastrado como inativo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    formPrincipal.AtualizarDataGridView();  //  Atualiza o datagrid do forms TelaCliente
                    this.Close();   //  Fecha esse forms

                    MessageBox.Show("Cadastro realizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Algum dado obrigatório não foi preenchido, favor verificar se todos os campos com asterisco (*) foram preenchidos.", "Erro de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// 
        /// EVENTO PARA PUXAR OS DADOS DO CEP DA API
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


        ///
        /// EVENTOS PARA VALIDAR SE CAMPOS FORAM INSERIDOS CORRETAMENTE
        ///
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

        private void mskCnpj_Leave(object sender, EventArgs e)
        {
            if (mskCnpj.Text != null)
            {
                bool validacao = ValidarCampoCnpj();
                if (validacao == false)
                {
                    MessageBox.Show("Está faltando dígito(s)!", "Cpf inválido");
                    mskCnpj.Focus();
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

        private void mskTelefone1_Leave(object sender, EventArgs e)
        {
            if (mskTelefone1.Text != null)
            {
                bool validacao = ValidarCampoTelefone();
                if (validacao == false)
                {
                    MessageBox.Show("Está faltando dígito(s)!", "Telefone inválido");
                    mskTelefone1.Focus();
                }
            }
        }

        private void mskTelefone2_Leave(object sender, EventArgs e)
        {
            if (mskTelefone2.Text != null)
            {
                bool validacao = ValidarCampoTelefone2();
                if (validacao == false)
                {
                    MessageBox.Show("Está faltando dígito(s)!", "Telefone inválido");
                    mskTelefone2.Focus();
                }
            }
        }





        //  EVENTO PARA ALTERAR O TIPO DE CLIENTE (CPF, CNPJ)
        private void checkCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCpf.CheckState == CheckState.Checked)
            {
                mskCpf.ReadOnly = false;

                checkCnpj.Checked = false;
                mskCnpj.Text = "";
                mskCnpj.ReadOnly = true;
            }
        }

        private void checkCnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCnpj.CheckState == CheckState.Checked)
            {
                mskCpf.ReadOnly = true;
                mskCpf.Text = "";
                checkCpf.Checked = false;

                mskCnpj.ReadOnly = false;

            }
        }






        ////////////////////////////////////////////    AÇÕES CRIADAS PARA OS EVENTOS   ////////////////////////////////////////////


        /// 
        /// AÇÃO PARA GARANTIR QUE O DADOS OBRIGATÓRIOS SEJAM INSERIDOS
        /// 
        private bool ValidarCamposObrigatorios()
        {
            return !string.IsNullOrWhiteSpace(txtId.Text)
                && !string.IsNullOrWhiteSpace(txtNome.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(mskTelefone1.Text);
        }

        private bool ValidarCamposObrigatoriosCPF_CNPJ()
        {
            string cpf = mskCpf.Text;
            // Remove caracteres não numéricos do CPF
            string cpfNumerico = new string(cpf.Where(char.IsDigit).ToArray());

            string cnpj = mskCnpj.Text;
            // Remove caracteres não numéricos do CPF
            string cnpjNumerico = new string(cnpj.Where(char.IsDigit).ToArray());

            if (checkCpf.Checked == true)
            {
                return !string.IsNullOrWhiteSpace(cpfNumerico);
            }
            else if (checkCnpj.Checked == true)
            {
                return !string.IsNullOrWhiteSpace(cnpjNumerico);
            }
            return false;
        }


        ///
        /// AÇÕES PARA VALIDAR SE CAMPOS FORAM INSERIDOS CORRETAMENTE
        ///
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

        private bool ValidarCampoCnpj()
        {
            string cnpj = mskCnpj.Text;
            // Remove caracteres não numéricos do CPF
            string cnpjNumerico = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cnpjNumerico.Length != 0)
            {
                // Verifica se o CPF possui 11 dígitos
                if (cnpjNumerico.Length != 14)
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

        private bool ValidarCampoTelefone()
        {
            string telefone = mskTelefone1.Text;
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

        private bool ValidarCampoTelefone2()
        {
            string telefone = mskTelefone2.Text;
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


        /// 
        /// AÇÃO QUE PUXA OS DADOS DA API ATRAVÉS DO CEP
        /// 
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






        ////////////////////////////////////////////    BOTÕES DE MANIPULAÇÃO DA TELA   ////////////////////////////////////////////


        ///
        /// ANIMAÇÃO DO CURSOR EM CIMA DOS BOTÕES 
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;



        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"    /////////////////////////////////////////// PRECISA SER AJUSTADO AINDA
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
        /// EVENTO BOTÃO "RESTAURAR"    /////////////////////////////////////////// PRECISA SER AJUSTADO AINDA
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
