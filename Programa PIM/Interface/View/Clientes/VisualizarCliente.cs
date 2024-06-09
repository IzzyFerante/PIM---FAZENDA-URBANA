using Interface.Model;
using Interface.View.Fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Clientes
{
    public partial class VisualizarCliente : Form
    {
        public VisualizarCliente(string idCliente, string usuario, TelaClientes cliente)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtId.Text = idCliente.PadLeft(6, '0');
            lblUsuario.Text = usuario;
        }


        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB
        /// 
        private void InitializeTabOrder()
        {
            txtId.TabIndex = 0;
            txtNome.TabIndex = 1;
            mskCpf.TabIndex = 2;
            mskCnpj.TabIndex = 3;
            txtEmail.TabIndex = 4;
            mskTelefone1.TabIndex = 5;
            mskTelefone2.TabIndex = 6;
            mskCep.TabIndex = 7;
            txtLogradouro.TabIndex = 8;
            txtNumero.TabIndex = 9;
            txtComplemento.TabIndex = 10;
            txtBairro.TabIndex = 11;
            txtEstado.TabIndex = 12;
            txtCidade.TabIndex = 13;
            bttFechar.TabIndex = 14;
        }


        /// 
        /// EVENTO DO BOTÃO "FECHAR"
        /// 
        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// 
        /// EVENTO PARA PREENCHER OS DADOS PARA ALTERAÇÃO
        /// 
        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            string idCliente = txtId.Text.PadLeft(6, '0');

            //  SALVAR O STATUS ORIGINAL DO FORNECEDOR PARA FUTURA VERIFICAÇÃO DE ALTERAÇÃO DE STATUS
            bool? status = acoes.PuxarDadoBOOL("status", "clientes", "id_cliente", idCliente); //  Puxa o status original em formato booleano

            //  PREENCHE O CHECK CONFORME SALVO
            if (status.HasValue && status.Value == true)
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
            // Remove caracteres não numéricos do CPF
            string cnpjNumerico = new string(cnpj.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrWhiteSpace(cpfNumerico))
            {
                checkCpf.CheckState = CheckState.Checked;
            }
            else if (!string.IsNullOrWhiteSpace(cnpjNumerico))
            {
                checkCnpj.CheckState = CheckState.Checked;
            }
        }






        ////////////////////////////////////////////    BOTÕES DE MANIPULAÇÃO DA TELA   ////////////////////////////////////////////


        ///
        /// ANIMAÇÃO DO CURSOR EM CIMA DOS BOTÕES 
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;



        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"    //////////////////////////////////////  PRECISA SER ALTERADO
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
        /// EVENTO BOTÃO "RESTAURAR"    //////////////////////////////////////  PRECISA SER ALTERADO
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
