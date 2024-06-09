using Interface.Model;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Interface.View.Funcionarios
{
    public partial class Cargo : Form
    {
        private CadastroFuncionario formPrincipal;
        private AlterarCargo alterarCargo;
        private CadastrarCargo cadastrarCargo;

        public Cargo(CadastroFuncionario cadastroFunc)
        {
            InitializeComponent();
            InitializeTabOrder();
            formPrincipal = cadastroFunc;
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



        private void Cargo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (alterarCargo != null && !alterarCargo.IsDisposed)
            {
                alterarCargo.Close();
            }

            if (cadastrarCargo != null && !cadastrarCargo.IsDisposed)
            {
                cadastrarCargo.Close();
            }
        }




        /// 
        /// EVENTO PARA CARREGAR O DATAGRID
        ///
        public void AtualizarDataGridView()
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            dataGridCargos.DataSource = acoes.AtualizarDataGrid("cargo", "cod_cargo");
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

            if (selectedItem == "código cargo")
            {
                selectedItem = "cod_cargo";
            }
            else
            {
                selectedItem = "nome_cargo";
            }

            //  Realizar a pesquisa no banco
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            DataTable dt = new DataTable();
            dt = acoes.Buscar(pesquisa, selectedItem, "cargo", "cod_cargo");

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
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            string cod = acoes.NovaMatricula("cargo", "cod_cargo");
            CadastrarCargo telaCadastroCargo = new CadastrarCargo(cod, this);
            telaCadastroCargo.Show();
        }
    


        ///
        /// EVENTO BOTÃO "ALTERAR"
        ///
        private void bttAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridCargos.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridCargos.SelectedRows[0];
                string cod = selectedRow.Cells["cod_cargo"].Value.ToString();

                AlterarCargo  alterar_cargo = new AlterarCargo(cod, this);
                alterar_cargo.Show();
            }
            else if (dataGridCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cargo para editar.");
            }
            else if (dataGridCargos.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um cargo");
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
                string cod = selectedRow.Cells["cod_cargo"].Value.ToString();

                formPrincipal.SetCargoCode(cod);
                this.Close();
            }
            else if (dataGridCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cargo para editar.");
            }
            else
            {
                MessageBox.Show("Selecione apenas um cargo");
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

