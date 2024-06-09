using Interface.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Vendas.Telas_Extras
{
    public partial class VisualizarProduto_cad : Form
    {
        private CadastrarVenda formPrincipal;

        public VisualizarProduto_cad(CadastrarVenda alterar)
        {
            InitializeComponent();
            InitializeTabOrder();
            formPrincipal = alterar;
        }




        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB
        /// 
        private void InitializeTabOrder()
        {
            picFiltroBuscar.TabIndex = 1;
            txtPesquisa.TabIndex = 2;
            bttBuscar.TabIndex = 3;
            bttSelecionar.TabIndex = 4;
        }




        /// 
        /// EVENTO PARA CARREGAR O DATAGRID
        ///
        public void AtualizarDataGridView()
        {
            AcoesVendas acoes = new AcoesVendas();

            dataGridView.DataSource = acoes.AtualizarDataGridATIVOS("produtos", "id_produto");
        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }




        /// 
        /// EVENTOS PARA BUSCAR
        ///
        //  Ação para abrir o filtro
        private void picFiltroBuscar_Click(object sender, EventArgs e)
        {
            checkListBusca.Visible = !checkListBusca.Visible;
        }


        //  AÇÃO PARA PESQUISAR NO BANCO
        private void bttBuscar_Click(object sender, EventArgs e)
        {
            string selectedItem = getTextoSelecionado().ToLower();    //  Para puxar qual a coluna desejada para puxar o dado
            string pesquisa = txtPesquisa.Text;

            if (selectedItem == "id categoria")
            {
                selectedItem = "id_categoria";
            }
            else if (selectedItem == "id produto")
            {
                selectedItem = "id_produto";
            }
            else if (selectedItem == "descrição produto")
            {
                selectedItem = "desc_produto";
            }

            //  Realizar a pesquisa no banco
            AcoesVendas acoes = new AcoesVendas();
            DataTable dt = new DataTable();
            dt = acoes.Buscar(pesquisa, selectedItem, "produtos", "id_produto");

            dataGridView.DataSource = dt;  //  Atualiza o datagrid com o filtro
        }

        //  Ação para buscar clicando no enter
        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttBuscar.PerformClick();
            }
        }


        // EVENTO PARA PERMITIR QUE APENAS UM CHECKBOX SEJA SELECIONADO
        private void CheckListBusca_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarcar todos os outros itens
                for (int i = 0; i < checkListBusca.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkListBusca.SetItemChecked(i, false);
                    }
                }
            }
        }


        // EVENTO PARA PEGAR O NOME DO CHECKBOX SELECIONADO
        private string getTextoSelecionado()
        {
            string selectedItem = "";
            for (int i = 0; i < checkListBusca.Items.Count; i++) // Correção no loop: i < checkListBusca.Items.Count
            {
                if (checkListBusca.GetItemCheckState(i) == CheckState.Checked) // Correção no acesso ao estado do item
                {
                    selectedItem = checkListBusca.Items[i].ToString(); // Correção para pegar o item selecionado corretamente
                    break; // Se você só quer o primeiro item selecionado, pode sair do loop aqui
                }
            }
            return selectedItem;
        }




        ///
        /// EVENTO BOTÃO "SELECIONAR"             
        ///
        private void bttSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                string cod = selectedRow.Cells["id_produto"].Value.ToString();

                formPrincipal.SetProdutoCode(cod);
                this.Close();
            }
            else if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto.");
            }
            else
            {
                MessageBox.Show("Selecione apenas um produto.");
            }
        }




        /// 
        /// EVENTO BOTÃO "FECHAR" 
        /// 
        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }












        ///
        /// ANIMAÇÃO DO CURSOR EM CIMA DOS BOTÕES 
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
    }
}