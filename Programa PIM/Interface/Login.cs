using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.Common;

namespace Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        ///
        /// Eventos botão "Acessar"
        ///
        private void bttAcessar_Click(object sender, EventArgs e)
        {
            //String User = "admin";
            //String Password = "admin";
            DadosLogin DadosLogin1 = new DadosLogin();
            DadosLogin1.user = "admin";
            DadosLogin1.password = "admin";


            if (txtUsuario.Text == DadosLogin1.user & mskSenha.Text == DadosLogin1.password)
            {
                MessageBox.Show("Acesso Liberado!");
                Menu_Principal1 Menu_Principal1 = new Menu_Principal1();
                Menu_Principal1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha Incorretos!");
            }
        }

            //Animação cursor botão "Acessar"
        private void bttAcessar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void bttAcessar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos do botão "Esqueci Minha Senha"
        ///
        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            RedefinirSenha RedefinirSenha1 = new RedefinirSenha();
            RedefinirSenha1.Show();
            this.Hide();
        }

        //Animação cursor e letra do botão "Esqueci Minha Senha"
        private void lblEsqueciSenha_MouseHover(object sender, EventArgs e)
        {
            lblEsqueciSenha.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            Cursor = Cursors.Hand;
        }

        private void lblEsqueciSenha_MouseLeave(object sender, EventArgs e)
        {
            lblEsqueciSenha.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Cursor = Cursors.Default;
        }


        ///
        /// Eventos botão "Fechar"
        ///
        private void iconFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            //Animação cursor icone "Fechar"
        private void iconFechar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void iconFechar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "Olhar Senha"
        ///

        //Animação do botão "Olhar Senha"
        private void picOlharSenha_MouseHover(object sender, EventArgs e)
        {
            mskSenha.PasswordChar = '\u0000';
        }

        private void picOlharSenha_MouseLeave(object sender, EventArgs e)
        {
            mskSenha.PasswordChar = '*';
        }
    }
}