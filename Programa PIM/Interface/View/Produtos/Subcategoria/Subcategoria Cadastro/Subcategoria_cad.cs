using Interface.Model;
using Interface.View.Fornecedores;
using Interface.View.Produtos.Subcategoria.Subcategoria_Alteração;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Produtos.Subcategoria.Subcategoria_Cadastro
{
    public partial class Subcategoria_cad : Form
    {
        private CadastrarProduto formPrincipal;

        public Subcategoria_cad(CadastrarProduto cadProd)
        {
            InitializeComponent();
            InitializeTabOrder();
            formPrincipal = cadProd;
        }


        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB
        /// 
        private void InitializeTabOrder()
        {
            bttIncluir.TabIndex = 0;
            bttAlterar.TabIndex = 1;
            picFiltroBuscar.TabIndex = 2;
            txtPesquisa.TabIndex = 3;
            bttBuscar.TabIndex = 4;
            bttSelecionar.TabIndex = 5;
        }


        private CadastrarSubcategoria_cad cadastro;
        private AlterarSubcategoria_cad alterar;

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cadastro != null && !cadastro.IsDisposed)
            {
                cadastro.Close();
            }

            if (alterar != null && !alterar.IsDisposed)
            {
                alterar.Close();
            }
        }



        /// 
        /// EVENTO PARA CARREGAR O DATAGRID
        ///
        public void AtualizarDataGridView()
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            dataGridSubcategoria.DataSource = acoes.AtualizarDataGrid("categorias", "id_categoria");
        }

        private void Subcategoria_Load(object sender, EventArgs e)
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
            else
            {
                selectedItem = "nome_categoria";
            }

            //  Realizar a pesquisa no banco
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            DataTable dt = new DataTable();
            dt = acoes.Buscar(pesquisa, selectedItem, "categorias", "id_categoria");

            dataGridSubcategoria.DataSource = dt;  //  Atualiza o datagrid com o filtro
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
        /// EVENTO BOTÃO "INCLUIR"        
        /// 
        private void bttIncluir_Click(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            string cod = acoes.NovaMatricula("categorias", "id_categoria");
            CadastrarSubcategoria_cad telaCadastroSubcategoria = new CadastrarSubcategoria_cad(cod, this);
            telaCadastroSubcategoria.Show();
        }



        ///
        /// EVENTO BOTÃO "ALTERAR"             
        ///
        private void bttAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridSubcategoria.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridSubcategoria.SelectedRows[0];
                string cod = selectedRow.Cells["id_categoria"].Value.ToString();

                AlterarSubcategoria_cad alterar_subcategoria = new AlterarSubcategoria_cad(cod, this);
                alterar_subcategoria.Show();
            }
            else if (dataGridSubcategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma categoria para editar.");
            }
            else
            {
                MessageBox.Show("Selecione apenas uma categoria para editar.");
            }
        }


        ///
        /// EVENTO BOTÃO "SELECIONAR"             
        ///
        private void bttSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridSubcategoria.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridSubcategoria.SelectedRows[0];
                string cod = selectedRow.Cells["id_categoria"].Value.ToString();

                formPrincipal.SetSubcategoriaCode(cod);
                this.Close();
            }
            else if (dataGridSubcategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma categoria.");
            }
            else
            {
                MessageBox.Show("Selecione apenas uma categoria.");
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