using Interface.Model;
using Interface.View.Clientes;
using Interface.View.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Vendas
{
    public partial class VisualizarVenda : Form
    {
        private TelaVendas formPrincipal;
        private string? id;
        private string statusOriginal = "";

        public VisualizarVenda(string id, string usuarioConectado, TelaVendas prod)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtIdVenda.Text = id.PadLeft(6, '0');  //  Preenche o campo de identificação automaticamente
            lblUsuario.Text = usuarioConectado;     //  Mantém salvo o usuario que está ativo para a informação não se perder quando voltar ao menu
            formPrincipal = prod;     // Permite passar informações entre esse form e o form chamado 
        }


        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            mskDtVenda.TabIndex = 0;
            txtCodCliente.TabIndex = 1;
            checkCrédito.TabIndex = 5;
            checkDebito.TabIndex = 6;
            checkPix.TabIndex = 7;
            checkBoleto.TabIndex = 8;
            checkA_Vista.TabIndex = 9;
            checkParcelado.TabIndex = 10;
            txtQntdParcelas.TabIndex = 11;
            bttFechar.TabIndex = 12;
        }



        ///
        /// EVENTO PARA QUANDO A TELA CARREGAR
        /// 
        private void CadastrarVenda_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            AcoesVendas acoesVendas = new AcoesVendas();

            mskDtVenda.Text = acoes.preencherDadosExistentesDATA("data_venda", "vendas", "id_venda", txtIdVenda.Text).ToString();
            txtCodCliente.Text = acoes.preencherDadosExistentes("id_cliente", "vendas", "id_venda", txtIdVenda.Text);
            txtNomeCliente.Text = acoes.preencherDadosExistentes("nome", "clientes", "id_cliente", txtCodCliente.Text);
            txtValorTotal.Text = acoes.preencherDadosExistentesNUMERIC("valor_total", "vendas", "id_venda", txtIdVenda.Text).ToString();

            //  Preencher a forma de pagamento
            int forma_pagamento = acoesVendas.preencherDadosExistentesINT("forma_pagamento", "vendas", "id_venda", txtIdVenda.Text);
            if (forma_pagamento == 1)
            {
                checkCrédito.CheckState = CheckState.Checked;
            }
            else if (forma_pagamento == 2)
            {
                checkDebito.CheckState = CheckState.Checked;
            }
            else if (forma_pagamento == 3)
            {
                checkBoleto.CheckState = CheckState.Checked;
            }
            else if (forma_pagamento == 4)
            {
                checkPix.CheckState = CheckState.Checked;
            }

            //  Preencher o modo de pagamento
            int modo_pagamento = acoesVendas.preencherDadosExistentesINT("qntd_parcelas", "vendas", "id_venda", txtIdVenda.Text);
            if (modo_pagamento != 0)
            {
                checkParcelado.CheckState = CheckState.Checked;
                txtQntdParcelas.Text = acoesVendas.preencherDadosExistentesINT("qntd_parcelas", "vendas", "id_venda", txtIdVenda.Text).ToString();
                txtValorParcela.Text = acoes.preencherDadosExistentesNUMERIC("valor_parcelas", "vendas", "id_venda", txtIdVenda.Text).ToString();
            }
            else
            {
                checkA_Vista.CheckState = CheckState.Checked;
            }

            IniciarDataGridView();
        }



        public void IniciarDataGridView()
        {
            AcoesVendas acoes = new AcoesVendas();

            dataGridProdutos.DataSource = acoes.AtualizarDataGrid(txtIdVenda.Text);
        }




        ///
        /// EVENTO DO BOTÃO "FECHAR"
        ///
        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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