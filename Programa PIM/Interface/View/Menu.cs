using Interface.View.Clientes;
using Interface.View.Fornecedores;
using Interface.View.Funcionarios;
using Interface.View.IA;
using Interface.View.Produtos;
using Interface.View.Vendas;

namespace Interface.View
{
    public partial class Menu : Form
    {
        public Menu(string Usuario)
        {
            InitializeComponent();
            lblUsuarioAtivo.Text = Usuario;
        }


        /// 
        /// EVENTOS ICONE "FUNCIONÁRIO"
        /// 
        private void picFuncionarios_Click(object sender, EventArgs e)
        {
            TelaFuncionarios telaFuncionarios = new TelaFuncionarios(lblUsuarioAtivo.Text);
            telaFuncionarios.Show();
            this.Close();
        }


        /// 
        /// EVENTOS ICONE "FORNECEDOR"
        /// 
        private void picFornecedores_Click(object sender, EventArgs e)
        {
            TelaFornecedores telaFornecedores = new TelaFornecedores(lblUsuarioAtivo.Text);
            telaFornecedores.Show();
            this.Close();
        }


        /// 
        /// EVENTOS ICONE "CLIENTE"
        /// 
        private void picClientes_Click(object sender, EventArgs e)
        {
            TelaClientes telaClientes = new TelaClientes(lblUsuarioAtivo.Text);
            telaClientes.Show();
            this.Close();
        }


        /// 
        /// EVENTOS ICONE "PRODUTOS"
        /// 
        private void picProdutos_Click(object sender, EventArgs e)
        {
            TelaProdutos menuProdutos = new TelaProdutos(lblUsuarioAtivo.Text);
            menuProdutos.Show();
            this.Close();
        }


        /// 
        /// EVENTOS ICONE "VENDAS"
        /// 
        private void picVendas_Click(object sender, EventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas(lblUsuarioAtivo.Text);
            telaVendas.Show();
            this.Close();
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
        private void picFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        ///
        /// CLASSE DE REDIMENSIONAR
        ///
        private void ResizePictureBox(PictureBox pictureBox, int size)
        {
            pictureBox.Width = size;
            pictureBox.Height = size;
        }


        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"
        /// 
        private void picMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            //  Alterar os botões visiveis
            picRestaurar.Visible = true;
            picMaximizar.Visible = false;

            //  Redimensionar icones
            ClientSize = new Size(1920, 1080);
            faixadaVerde.Size = new Size(1920, 200);
            int newSize = Math.Max(this.ClientSize.Width, this.ClientSize.Height) / 8;
            ResizePictureBox(picFuncionario, newSize);
            ResizePictureBox(picFornecedores, newSize);
            ResizePictureBox(picClientes, newSize);
            ResizePictureBox(picProdutos, newSize);
            ResizePictureBox(picVendas, newSize);
            ResizePictureBox(picProducao, newSize);

            picLogo.Width = 451;
            picLogo.Height = 177;

            picIA.Width = 80;
            picIA.Height = 80;

            //  Colocar na localização na hora da redimensionação
            picFuncionario.Location = new Point(200, 300);
            picFornecedores.Location = new Point(850, 300);
            picClientes.Location = new Point(1500, 300);
            picProdutos.Location = new Point(200, 680);
            picVendas.Location = new Point(1500, 680);
            picProducao.Location = new Point(850, 685);
            picLogo.Location = new Point(756, 13);

            panel2.Location = new Point(0, 140);

            picIA.Location = new Point(1808, 980);
        }



        /// 
        /// EVENTO BOTÃO "RESTAURAR"
        /// 
        private void picRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            //  Altera os botões visiveis
            picRestaurar.Visible = false;
            picMaximizar.Visible = true;

            //  Centraliza a tela
            this.CenterToScreen();

            //  Redimensionar icones
            ClientSize = new Size(960, 540);
            faixadaVerde.Size = new Size(960, 125);
            int newSize = Math.Max(this.ClientSize.Width, this.ClientSize.Height) / 8;
            ResizePictureBox(picFuncionario, newSize);
            ResizePictureBox(picFornecedores, newSize);
            ResizePictureBox(picClientes, newSize);
            ResizePictureBox(picProdutos, newSize);
            ResizePictureBox(picVendas, newSize);
            ResizePictureBox(picProducao, newSize);

            picLogo.Width = 300;
            picLogo.Height = 200;

            picIA.Width = 50;
            picIA.Height = 50;

            //  Colocar na localização na hora da redimensionação
            picFuncionario.Location = new Point(130, 160);
            picFornecedores.Location = new Point(440, 160);
            picClientes.Location = new Point(750, 160);
            picProdutos.Location = new Point(125, 360);
            picVendas.Location = new Point(745, 360);
            picProducao.Location = new Point(440, 365);
            picLogo.Location = new Point(335, -40);

            panel2.Location = new Point(0, 70);

            picIA.Location = new Point(900, 480);
        }



        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /// 
        /// EVENTOS BOTÃO "DESLOGAR"
        ///
        private void picDeslogar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja desconectar deste usuário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login login1 = new Login();
                login1.Show();
                this.Close();
            }
        }



        /// 
        /// EVENTO BOTÃO "IA"
        /// 
        private void picIA_Click(object sender, EventArgs e)
        {
            var telaIA = new TelaIA();
            telaIA.Show();
        }
    }
}
