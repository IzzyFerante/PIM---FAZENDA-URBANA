using Interface.Model;
using Interface.View.Produção.Tela_Extras.Area.Area_cad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Produção.Tela_Extras.Area.Area_alt
{
    public partial class TelaArea_alt : Form
    {
        private AlterarProducao formPrincipal;

        private AlterarArea_alt alterar;
        private CadastrarArea_alt cadastrar;

        public TelaArea_alt(AlterarProducao cadastro)
        {
            InitializeComponent();
            InitializeTabOrder();
            formPrincipal = cadastro;
        }


        /// 
        /// Evento para definir a ordem do TAB
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



        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            if (alterar != null && !alterar.IsDisposed)
            {
                alterar.Close();
            }

            if (cadastrar != null && !cadastrar.IsDisposed)
            {
                cadastrar.Close();
            }
        }




        /// 
        /// EVENTO PARA CARREGAR O DATAGRID
        ///
        public void AtualizarDataGridView()
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            dataGridCargos.DataSource = acoes.AtualizarDataGrid("area", "id_area");
        }

        private void Cargo_Load(object sender, EventArgs e)
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

        //  Animação do cursor botão "Filtro"
        private void picFiltroBuscar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picFiltroBuscar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        //  AÇÃO PARA PESQUISAR NO BANCO
        private void bttBuscar_Click(object sender, EventArgs e)
        {
            string selectedItem = getTextoSelecionado().ToLower();    //  Para puxar qual a coluna desejada para puxar o dado
            string pesquisa = txtPesquisa.Text;

            if (selectedItem == "id area")
            {
                selectedItem = "id_area";
            }
            else
            {
                selectedItem = "nome";
            }

            //  Realizar a pesquisa no banco
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            DataTable dt = new DataTable();
            dt = acoes.Buscar(pesquisa, selectedItem, "area", "id_area");

            dataGridCargos.DataSource = dt;  //  Atualiza o datagrid com o filtro
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

        //  Animação do cursor botão "Filtro"
        private void bttBuscar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttBuscar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

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
            AcoesProducao acoes = new AcoesProducao();

            int ultimoId = acoes.NovoCodigo("area", "id_area");
            string novoID = "";

            if (ultimoId != 0)
            {
                novoID = (ultimoId + 1).ToString();
            }
            else
            {
                novoID = "1";
            }

            CadastrarArea_alt cadastrarArea = new CadastrarArea_alt(novoID, this);
        }



        ///
        /// EVENTO BOTÃO "ALTERAR"
        ///
        private void bttAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridCargos.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridCargos.SelectedRows[0];
                string cod = selectedRow.Cells["is_area"].Value.ToString();

                AlterarArea_alt alterar_cargo = new AlterarArea_alt(cod, this);
                alterar_cargo.Show();
            }
            else if (dataGridCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma área para editar.");
            }
            else if (dataGridCargos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas uma área");
            }
        }


        ///
        /// EVENTO BOTÃO "SELECIONAR"
        ///
        private void bttSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridCargos.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridCargos.SelectedRows[0];
                string cod = selectedRow.Cells["id_area"].Value.ToString();

                formPrincipal.SetAreaCode(cod);
                this.Close();
            }
            else if (dataGridCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma área para editar.");
            }
            else
            {
                MessageBox.Show("Selecione apenas uma área");
            }
        }


        /// 
        /// EVENTO BOTÃO "FECHAR"
        /// 
        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
