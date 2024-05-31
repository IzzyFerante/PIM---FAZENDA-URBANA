using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        /// 
        /// EVENTOS ICONE "FUNCIONÁRIO"
        /// 
        private void picFuncionarios_Click(object sender, EventArgs e)
        {
            this.Close();
            Funcionarios telaFuncionarios = new Funcionarios();
            telaFuncionarios.Show();
        }

        //  Animação cursor icone "Funcionário"
        private void picFuncionario_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picFuncionario_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS ICONE "FORNECEDOR"
        /// 
        private void picFornecedores_Click(object sender, EventArgs e)
        {
            this.Close();
            Fornecedores telaFornecedores = new Fornecedores();
            telaFornecedores.Show();
        }

        //  Animação cursor icone "Fornecedor"
        private void picFornecedores_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picFornecedores_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS ICONE "CLIENTE"
        /// 
        private void picClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Clientes telaClientes = new Clientes();
            telaClientes.Show();
        }

        //  Animação cursor icone "Cliente"
        private void picClientes_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picClientes_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS ICONE "PRODUTOS"
        /// 
        private void picProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            Produtos telaProdutos = new Produtos();
            telaProdutos.Show();
        }

        //  Animação cursor icone "Produtos"
        private void picProdutos_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picProdutos_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS ICONE "VENDAS"
        /// 
        private void picVendas_Click(object sender, EventArgs e)
        {
            this.Close();
            Vendas telaVendas = new Vendas();
            telaVendas.Show();
        }

        //  Animação cursor icone "Vendas"
        private void picVendas_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picVendas_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;




        /// 
        /// EVENTO BOTÃO "FECHAR"
        /// 
        private void picFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  Animação do cursor botão "Fechar"
        private void picFechar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picFechar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


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
        private void picMaximizar_Click(object sender, EventArgs e, Panel size)
        {
            this.WindowState = FormWindowState.Maximized;

            //  Alterar os botões visiveis
            picRestaurar.Visible = true;
            picMaximizar.Visible = false;

            //  Redimensionar icones
            ClientSize = new Size(1910, 1080);
            int newSize = Math.Max(this.ClientSize.Width, this.ClientSize.Height) / 8;
            ResizePictureBox(picFuncionario, newSize);
            ResizePictureBox(picFornecedores, newSize);
            ResizePictureBox(picClientes, newSize);
            ResizePictureBox(picProdutos, newSize);
            ResizePictureBox(picVendas, newSize);

            //  Colocar na localização na hora da redimensionação
            picFuncionario.Location = new Point(200, 300);
            picFornecedores.Location = new Point(850, 300);
            picClientes.Location = new Point(1500, 300);
            picProdutos.Location = new Point(520, 680);
            picVendas.Location = new Point(1220, 680);
        }

        //  Animação do cursor botão "Maximizar"
        private void picMaximizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picMaximizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


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

            //  Colocar na localização na hora da redimensionação
            picFuncionario.Location = new Point(130, 160);
            picFornecedores.Location = new Point(440, 160);
            picClientes.Location = new Point(750, 160);
            picProdutos.Location = new Point(290, 360);
            picVendas.Location = new Point(610, 360);
        }

        //  Animação do cursor botão "Restaurar"
        private void picRestaurar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picRestaurar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  Animação do cursor botão "Minimizar"
        private void picMinimizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picMinimizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        
    }
}
