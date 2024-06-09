using Interface.Model;
using Interface.View.Produção.Tela_Extras.Area.Area_alt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Produção
{
    public partial class VisualizarProducao : Form
    {
        public VisualizarProducao(string id, string usuario)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtIdProducao.Text = id;
            lblUsuario.Text = usuario;
        }



        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            mskDtPlantio.TabIndex = 0;
            txtArea.TabIndex = 1;
            txtCodProduto.TabIndex = 2;
            txtQntdPlantada.TabIndex = 3;
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
        /// EVENTO PARA QUANDO A TELA CARREGAR
        /// 
        private void VisualizarProducao_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            AcoesVendas acoesVendas = new AcoesVendas();

            mskDtPlantio.Text = acoes.preencherDadosExistentesDATA("data_plantio", "producao", "id_producao", txtIdProducao.Text).ToString();
            mskDtColheita.Text = acoes.preencherDadosExistentesDATA("data_prevista_colheita", "producao", "id_producao", txtIdProducao.Text).ToString();

            txtArea.Text = acoes.preencherDadosExistentes("area", "producao", "id_producao", txtIdProducao.Text);
            txtNomeArea.Text = acoes.preencherDadosExistentes("nome", "area", "id_area", txtArea.Text);

            txtCodProduto.Text = acoes.preencherDadosExistentes("id_produto", "producao", "id_producao", txtIdProducao.Text);
            txtProduto.Text = acoes.preencherDadosExistentes("desc_produto", "produtos", "id_produto", txtCodProduto.Text);
            txtQntdEstoque.Text = acoesVendas.preencherDadosExistentesINT("qntd_estoque", "produtos", "id_produto", txtCodProduto.Text).ToString();

            txtQntdPlantada.Text = acoesVendas.preencherDadosExistentesINT("qntd_plantada", "producao", "id_producao", txtIdProducao.Text).ToString();
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