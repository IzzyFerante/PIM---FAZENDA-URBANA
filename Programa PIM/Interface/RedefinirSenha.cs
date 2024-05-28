using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }


        ///
        /// Eventos botão "InfoEmail"
        ///
        private void picInfoEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coloque o seu email cadastrado no sistema!\n\nCaso não se lembre, favor contatar seu Superior.");
        }

            //Animação do cursor em cima do "InfoEmail"
        private void picInfoEmail_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void picInfoEmail_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "InfoPalavraChave"
        ///
        private void picInfoPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite a sua Palavra de Segurança que foi cadastrada no momento de criação da senha.");
        }

            //Animação do cursor em cima do "InfoPalavraChave"
        private void picInfoPalavraChave_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void picInfoPalavraChave_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "Confirmar"
        ///
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            String Email = "teste@gmail.com";
            String PalavraChave = "Teste";

            if (txtEmail.Text == Email & txtPalavraChave.Text == PalavraChave)
            {
                MessageBox.Show("Dados corretos!");
                RedefinirSenha2 RedefinirSenha2 = new RedefinirSenha2();
                RedefinirSenha2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou Palavra de Segurança incorretos!\n\nVerifique as letras maiúsculas ou minúsculas.");
            }
        }

            //Animação do cursor em cima do "Confirmar"
        private void bttConfirmar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void bttConfirmar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "Fechar"
        ///
        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.Show();
        }

            //Animação do cursor em cima do "Fechar"
        private void iconFechar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void iconFechar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "Esqueci Minha Senha"
        ///
        private void lblEsqueciPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor entrar em contato com o seu Superior, para redefiniçao de Senha e Palavra de Segurança.", "Redefinir Palavra de Segurança");
        }
            
            //Animação do cursor e letra em cima do "Esqueci Minha Palavra Chave"
        private void lblEsqueciPalavraChave_MouseHover(object sender, EventArgs e)
        {
            lblEsqueciPalavraChave.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            Cursor = Cursors.Hand;
        }

        private void lblEsqueciPalavraChave_MouseLeave(object sender, EventArgs e)
        {
            lblEsqueciPalavraChave.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Cursor = Cursors.Default;
        }   
    }
}
