using System.Data;

namespace Interface.View
{
    public partial class Funcionarios : Form
    {
        public Funcionarios(string Usuario)
        {
            InitializeComponent();
            InitializeTabOrder();

            lblUsuario.Text = Usuario;
        }


        /// 
        /// Evento para definir a ordem do TAB
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


        ///
        /// AÇÃO PARA ATUALIZAR O GRID
        /// 
        public void AtualizarDataGridView()
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            dataGridView1.DataSource = acoes.AtualizarDataGrid("funcionarios");
        }


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

        //  Animação do cursor botão "Fechar"
        private void bttFechar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttFechar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


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
            Font newFont = new Font(lblFuncionarios.Font.FontFamily, newSize, lblFuncionarios.Font.Style);
            lblFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 228);
            bttAlterar.Location = new Point(180, 228);
            bttVisualizar.Location = new Point(320, 228);
            dataGridView1.Location = new Point(40, 296);
            picIcone.Location = new Point(42, 61);
            lblFuncionarios.Location = new Point(208, 134);
        }

        //  Animação do cursor botão "Maximizar"
        private void bttMaximizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttMaximizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


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
            Font newFont = new Font(lblFuncionarios.Font.FontFamily, newSize, lblFuncionarios.Font.Style);
            lblFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 153);
            bttAlterar.Location = new Point(180, 153);
            bttVisualizar.Location = new Point(320, 153);
            dataGridView1.Location = new Point(40, 221);
            picIcone.Location = new Point(42, 41);
            lblFuncionarios.Location = new Point(151, 80);
        }

        //  Animação do cursor botão "Restaurar"
        private void bttRestaurar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttRestaurar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void bttMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  Animação do cursor botão "Minimizar"
        private void bttMinimizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttMinimizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO PARA CARREGAR O DATAGRID
        /// 
        private void Funcionarios_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
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

        //  Animação do cursor botão "Voltar"
        private void picVoltar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picVoltar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS DO BOTÃO "INCLUIR"
        /// 
        private void bttIncluir_Click(object sender, EventArgs e)
        {
            CadastroFuncionario telaCadastroFuncionario = new CadastroFuncionario(lblUsuario.Text, this);
            telaCadastroFuncionario.Show();
        }

        //  Animação do cursor botão "Incluir"
        private void bttIncluir_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttIncluir_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS DO BOTÃO "ALTERAR"
        /// 
        private void bttAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string matricula = selectedRow.Cells["matricula"].Value.ToString();

                AlterarFuncionario alterar_funcionario = new AlterarFuncionario(matricula, lblUsuario.Text, this);
                alterar_funcionario.Show();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.");
            }
        }

        //  Animação do cursor botão "Alterar"
        private void bttAlterar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttAlterar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS DO BOTÃO "VISUALIZAR"
        /// 
        private void bttVisualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string matricula = selectedRow.Cells["matricula"].Value.ToString();

                VisualizarFuncionario visualizar_funcionario = new VisualizarFuncionario(matricula, lblUsuario.Text, this);
                visualizar_funcionario.Show();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.");
            }
        }

        //  Animação do cursor botão "Excluir"
        private void bttVisualizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttVisualizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


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
            string pesquisa = "";

            if (selectedItem == "email")
            {
                txtPesquisa.Text.ToLower();
            }

            //  Realizar a pesquisa no banco
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            DataTable dt = new DataTable();

            dt = acoes.Buscar(txtPesquisa.Text, selectedItem, "funcionarios");

            dataGridView1.DataSource = dt;  //  Atualiza o datagrid com o filtro
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
    }
}
