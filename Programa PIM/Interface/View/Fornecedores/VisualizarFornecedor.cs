using Interface.Model;
using Interface.View.Funcionarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Fornecedores
{
    public partial class VisualizarFornecedor : Form
    { 
        public VisualizarFornecedor(string idFornecedor, string usuario, TelaFornecedores forn)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtId.Text = idFornecedor.PadLeft(6, '0');
            lblUsuario.Text = usuario;
        }


        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB
        /// 
        private void InitializeTabOrder()
        {
            txtId.TabIndex = 0;
            txtRazaoSocial.TabIndex = 1;
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
            bttFechar.TabIndex = 13;
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
        private void AlterarFornecedor_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            string idFornecedor = txtId.Text.PadLeft(6, '0');

            //  SALVAR O STATUS ORIGINAL DO FORNECEDOR PARA FUTURA VERIFICAÇÃO DE ALTERAÇÃO DE STATUS
            bool? status = acoes.PuxarDadoBOOL("status", "fornecedores", "id_fornecedor", idFornecedor); //  Puxa o status original em formato booleano

            //  PREENCHE O CHECK CONFORME SALVO
            if (status.HasValue && status.Value == true)
            {
                checkFuncAtivo.CheckState = CheckState.Checked;
            }
            else
            {
                checkFuncAtivo.CheckState = CheckState.Unchecked;
            }

            //  PREENCHER OS CAMPOS COM OS DADOS EXISTENTES NO BANCO
            txtRazaoSocial.Text = acoes.preencherDadosExistentes("razao_social", "fornecedores", "id_fornecedor", idFornecedor);
            mskCnpj.Text = acoes.preencherDadosExistentes("cnpj", "fornecedores", "id_fornecedor", idFornecedor);
            txtEmail.Text = acoes.preencherDadosExistentes("email", "fornecedores", "id_fornecedor", idFornecedor);
            mskTelefone1.Text = acoes.preencherDadosExistentes("telefone", "fornecedores", "id_fornecedor", idFornecedor);
            mskTelefone2.Text = acoes.preencherDadosExistentes("telefone_secundario", "fornecedores", "id_fornecedor", idFornecedor);
            mskCep.Text = acoes.preencherDadosExistentes("cep", "fornecedores", "id_fornecedor", idFornecedor);
            txtLogradouro.Text = acoes.preencherDadosExistentes("logradouro", "fornecedores", "id_fornecedor", idFornecedor);
            txtNumero.Text = acoes.preencherDadosExistentes("numero", "fornecedores", "id_fornecedor", idFornecedor);
            txtComplemento.Text = acoes.preencherDadosExistentes("complemento", "fornecedores", "id_fornecedor", idFornecedor);
            txtBairro.Text = acoes.preencherDadosExistentes("bairro", "fornecedores", "id_fornecedor", idFornecedor);
            txtEstado.Text = acoes.preencherDadosExistentes("estado", "fornecedores", "id_fornecedor", idFornecedor);
            txtCidade.Text = acoes.preencherDadosExistentes("cidade", "fornecedores", "id_fornecedor", idFornecedor);
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
