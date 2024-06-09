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
using System.Threading.Tasks;
using System.Windows.Forms;
using Testes;

namespace Interface.View.Clientes
{
    public partial class AtualizarCliente : Form
    {
        private TelaClientes formPrincipal;
        private string? idClientes;
        private string statusOriginal = "";

        public AtualizarCliente(string idCliente, string usuarioConectado, TelaClientes cliente)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtId.Text = idCliente.PadLeft(6, '0');  //  Preenche o campo de identificação automaticamente
            lblUsuario.Text = usuarioConectado;     //  Mantém salvo o usuario que está ativo para a informação não se perder quando voltar ao menu
            formPrincipal = cliente;     // Permite passar informações entre esse form e o form chamado 
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
        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            string idCliente = txtId.Text.PadLeft(6, '0');

            //  SALVAR O STATUS ORIGINAL DO FORNECEDOR PARA FUTURA VERIFICAÇÃO DE ALTERAÇÃO DE STATUS
            bool? statusOriginalBOOL = acoes.PuxarDadoBOOL("status", "clientes", "id_cliente", idCliente); //  Puxa o status original em formato booleano
            statusOriginal = statusOriginalBOOL.ToString(); //  Transforma em string e salva na variável geral

            //  PREENCHE O CHECK CONFORME SALVO
            if (statusOriginalBOOL.HasValue && statusOriginalBOOL.Value == true)
            {
                checkClienteAtivo.CheckState = CheckState.Checked;
            }
            else
            {
                checkClienteAtivo.CheckState = CheckState.Unchecked;
            }

            //  PREENCHER OS CAMPOS COM OS DADOS EXISTENTES NO BANCO
            txtNome.Text = acoes.preencherDadosExistentes("nome", "clientes", "id_cliente", idCliente);
            mskCpf.Text = acoes.preencherDadosExistentes("cpf", "clientes", "id_cliente", idCliente);
            mskCnpj.Text = acoes.preencherDadosExistentes("cnpj", "clientes", "id_cliente", idCliente);
            txtEmail.Text = acoes.preencherDadosExistentes("email", "clientes", "id_cliente", idCliente);
            mskTelefone1.Text = acoes.preencherDadosExistentes("telefone", "clientes", "id_cliente", idCliente);
            mskTelefone2.Text = acoes.preencherDadosExistentes("telefone_secundario", "clientes", "id_cliente", idCliente);
            mskCep.Text = acoes.preencherDadosExistentes("cep", "clientes", "id_cliente", idCliente);
            txtLogradouro.Text = acoes.preencherDadosExistentes("logradouro", "clientes", "id_cliente", idCliente);
            txtNumero.Text = acoes.preencherDadosExistentes("numero", "clientes", "id_cliente", idCliente);
            txtComplemento.Text = acoes.preencherDadosExistentes("complemento", "clientes", "id_cliente", idCliente);
            txtBairro.Text = acoes.preencherDadosExistentes("bairro", "clientes", "id_cliente", idCliente);
            txtEstado.Text = acoes.preencherDadosExistentes("estado", "clientes", "id_cliente", idCliente);
            txtCidade.Text = acoes.preencherDadosExistentes("cidade", "clientes", "id_cliente", idCliente);

            //  PREENCHER O CHECK REFERENTE AO CPF OU CNPJ
            //  CPF
            string cpf = mskCpf.Text;
            // Remove caracteres não numéricos do CPF
            string cpfNumerico = new string(cpf.Where(char.IsDigit).ToArray());

            //  CNPJ
            string cnpj = mskCnpj.Text;
            // Remove caracteres não numéricos do CNPJ
            string cnpjNumerico = new string(cnpj.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrWhiteSpace(cpfNumerico))
            {
                checkCpf.Checked = true;
                mskCpf.ReadOnly = false;    //  Tranforma o campo cpf em alterável

                checkCnpj.Checked = false;  //  Não permite que ambos os checks fiquem ativos
                mskCnpj.ReadOnly = true;    //  Tranforma o campo cnpj em não alterável
            }
            else if (!string.IsNullOrWhiteSpace(cnpjNumerico))
            {
                checkCnpj.Checked = true;
                mskCnpj.ReadOnly = false;    //  Tranforma o campo cnpj em alterável

                checkCpf.Checked = false;  //  Não permite que ambos os checks fiquem ativos
                mskCpf.ReadOnly = true;    //  Tranforma o campo cpf em não alterável
            }





            //  Ação de redimensionar a tela

            // Obter o tamanho da tela
            Rectangle screenSize = Screen.PrimaryScreen.WorkingArea;

            // Calcular a posição original centralizada
            int x = (screenSize.Width - this.Width) / 2;
            int y = (screenSize.Height - this.Height) / 2;
            originalFormLocation = new Point(x, y);
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
            AcoesClientes acoes = new AcoesClientes();

            if (ValidarCamposObrigatorios() && ValidarCamposObrigatoriosCPF_CNPJ())    //  Chama o método criado mais abaixo para validar se os campo obrigratórios foram preenchidos
            {
                if (MessageBox.Show("Confirmar alteração de cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)    //  Garante que o botão não tenha sido apertado por engano
                {
                    //  DEFINIR BOOL DE STATUS CONFORME PREENCHIDO
                    bool clienteAtivo = false; //  Cria variável para salvar a informação
                    if (checkClienteAtivo.CheckState == CheckState.Checked)
                    {
                        clienteAtivo = true;
                    }


                    string cpf = "";
                    string cnpj = "";

                    if (checkCpf.Checked = true)
                    {
                        cpf = mskCpf.Text;
                        cnpj = null;
                    }
                    else if (checkCnpj.Checked = true)
                    {
                        cnpj = mskCnpj.Text;
                        cpf = null;
                    }


                    string idCliente = txtId.Text.PadLeft(6, '0');   //  Garante que a identificação tenha os zeros anteriores


                    acoes.AtualizaDados(txtId.Text, clienteAtivo, txtNome.Text, cpf, cnpj, txtEmail.Text, mskTelefone1.Text, mskTelefone2.Text, mskCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtEstado.Text, txtCidade.Text);


                    //  TRANSFORMA O STATUS ORIGINAL EM BOOLEANO
                    bool statusOriginalBOOL;
                    bool conversao = Boolean.TryParse(statusOriginal, out statusOriginalBOOL);

                    //  FAZ A VERIFICAÇÃO DE ALTTERAÇÃO DE STATUS E SUAS RESPECTIVAS AÇÕES
                    if (clienteAtivo == statusOriginalBOOL && clienteAtivo == false)
                    {
                        MessageBox.Show("Cliente continua inativo!", "Cliente Ativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (clienteAtivo != statusOriginalBOOL && clienteAtivo == true)
                    {
                        MessageBox.Show("O cliente foi reativado!", "Cliente Reativado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (clienteAtivo != statusOriginalBOOL && clienteAtivo == false)
                    {
                        MessageBox.Show("O cliente foi inativado!", "Cliente Inativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    formPrincipal.AtualizarDataGridView();  //  Atualiza o datagrid do forms TelaCliente
                    this.Close();   //  Fecha esse forms
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
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void bttMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
