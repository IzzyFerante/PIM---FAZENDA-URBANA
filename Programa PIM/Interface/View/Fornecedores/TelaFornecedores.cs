using Interface.Model;
using Interface.View.Clientes;
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
    public partial class TelaFornecedores : Form
    { 
        public TelaFornecedores(string Usuario)
        {
            InitializeComponent();
            InitializeTabOrder();

            lblUsuario.Text = Usuario;
        }


        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB
        /// 
        private void InitializeTabOrder()
        {
            bttIncluir.TabIndex = 0;
            bttAlterar.TabIndex = 1;
            bttVisualizar.TabIndex = 2;
            picFiltroBuscar.TabIndex = 3;
            txtPesquisa.TabIndex = 4;
            bttBuscar.TabIndex = 5;
        }


        private CadastrarFornecedor cadastro;
        private AlterarFornecedor alterar;
        private VisualizarFornecedor visualizar;

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

            if (visualizar != null && !visualizar.IsDisposed)
            {
                visualizar.Close();
            }

        }



        ///
        /// AÇÃO PARA ATUALIZAR O GRID
        /// 
        public void AtualizarDataGridView()
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            dataGridView1.DataSource = acoes.AtualizarDataGrid("fornecedores", "id_fornecedor");
        }


        /// 
        /// EVENTO PARA CARREGAR O DATAGRID
        /// 
        private void Fornecedores_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }


        /// 
        /// EVENTOS PARA BUSCAR
        ///
        //  EVENTO PARA ABRIR/FECHAR O FILTRO
        private void picFiltroBuscar_Click(object sender, EventArgs e)
        {
            checkListBusca.Visible = !checkListBusca.Visible;
        }

        //  EVENTO PARA BUSCAR CLICANDO NO ENTER
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

        //  AÇÃO PARA PESQUISAR NO BANCO
        private void bttBuscar_Click(object sender, EventArgs e)
        {
            string selectedItem = getTextoSelecionado().ToLower();    //    Transformar a opção selecionada em padrão
            string pesquisa = txtPesquisa.Text;

            //  Verifica se vai precisar de alteração 
            if (selectedItem == "id")   
            {
                selectedItem = "id_fornecedor"; //  Aqui altera para pesquisar o código
            }
            else if (selectedItem == "razão social")
            {
                selectedItem = "razao_social";  //  Aqui altera para pesquisar o código
            }
            else if (selectedItem == "email")
            {
                pesquisa = txtPesquisa.Text.ToLower();  //  Aqui altera o tamanho da letra da pesquisa para achar no banco
            }

            //  Realizar a pesquisa no banco
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            DataTable dt = new DataTable();

            dt = acoes.Buscar(pesquisa, selectedItem, "fornecedores", "id_fornecedor");

            dataGridView1.DataSource = dt;  //  Atualiza o datagrid com o filtro
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
        /// EVENTOS DO BOTÃO "INCLUIR"
        /// 
        private void bttIncluir_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor telaCadastroFornecedor = new CadastrarFornecedor(lblUsuario.Text, this);
            telaCadastroFornecedor.Show();
        }



        /// 
        /// EVENTOS DO BOTÃO "ALTERAR"
        /// 
        private void bttAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um fornecedor.");
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string idFornecedor = selectedRow.Cells["id_fornecedor"].Value.ToString();

                AlterarFornecedor alterar_fornecedor = new AlterarFornecedor(idFornecedor, lblUsuario.Text, this);
                alterar_fornecedor.Show();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
            }
        }



        /// 
        /// EVENTOS DO BOTÃO "VISUALIZAR"
        /// 
        private void bttVisualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um fornecedor.");
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string idFornecedor = selectedRow.Cells["id_fornecedor"].Value.ToString();

                VisualizarFornecedor visualizar_fornecedor = new VisualizarFornecedor(idFornecedor, lblUsuario.Text, this);
                visualizar_fornecedor.Show();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para visualizar.");
            }
        }




        ////////////////////////////////////////////    BOTÕES DE MANIPULAÇÃO DA TELA   ////////////////////////////////////////////


        ///
        /// ANIMAÇÃO DO CURSOR EM CIMA DOS BOTÕES 
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;



        /// 
        /// EVENTO BOTÃO "FECHAR"
        /// 
        private void bttFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"
        /// 
        private void bttMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //  Alterar os botões visiveis
            bttRestaurar.Visible = true;
            bttMaximizar.Visible = false;

            //  Redimensionar icones
            faixadaVerde.Size = new Size(1920, 200);
            dataGridView1.Size = new Size(1840, 740);
            picIcone.Size = new Size(155, 139);

            float newSize = 20.0f;
            Font newFont = new Font(lblFornecedores.Font.FontFamily, newSize, lblFornecedores.Font.Style);
            lblFornecedores.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 228);
            bttAlterar.Location = new Point(180, 228);
            bttVisualizar.Location = new Point(320, 228);
            dataGridView1.Location = new Point(40, 296);
            picIcone.Location = new Point(42, 61);
            lblFornecedores.Location = new Point(208, 134);
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
            this.CenterToScreen();

            //  Redimensionar icones
            ClientSize = new Size(960, 540);
            faixadaVerde.Size = new Size(960, 125);
            dataGridView1.Size = new Size(880, 280);
            picIcone.Size = new Size(100, 84);

            float newSize = 15.0f;
            Font newFont = new Font(lblFornecedores.Font.FontFamily, newSize, lblFornecedores.Font.Style);
            lblFornecedores.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 153);
            bttAlterar.Location = new Point(180, 153);
            bttVisualizar.Location = new Point(320, 153);
            dataGridView1.Location = new Point(40, 221);
            picIcone.Location = new Point(42, 41);
            lblFornecedores.Location = new Point(151, 80);
        }



        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void bttMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /// 
        /// EVENTOS DO BOTÃO "VOLTAR"
        /// 
        private void picVoltar_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu(lblUsuario.Text);
            this.Close();
            menu1.Show();
        }
    }
}
