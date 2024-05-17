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

namespace Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String User = "admin";
            //String Password = "admin";
            DadosLogin DadosLogin1 = new DadosLogin();
            DadosLogin1.user = "admin";
            DadosLogin1.password = "admin";


            if (Usuario_txt.Text == DadosLogin1.user & senha_msk.Text == DadosLogin1.password)
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

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void esqueceusnh_btn_Click(object sender, EventArgs e)
        {
            RedefinirSenha RedefinirSenha1 = new RedefinirSenha();
            RedefinirSenha1.Show();
            this.Hide();
        }
        private void picOlhaSenha_MouseHover(object sender, EventArgs e)
        {
            senha_msk.PasswordChar = '\u0000';
        }

        private void picOlhaSenha_MouseLeave(object sender, EventArgs e)
        {
            senha_msk.PasswordChar = '*';
        }

        private void iconefechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            RedefinirSenha RedefinirSenha1 = new RedefinirSenha();
            RedefinirSenha1.Show();
            this.Hide();
        }

        private void lblEsqueciSenha_MouseHover(object sender, EventArgs e)
        {
            lblEsqueciSenha.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            Cursor = Cursors.Hand;
        }

        private void lblEsqueciSenha_MouseLeave(object sender, EventArgs e)
        {
            lblEsqueciSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cursor = Cursors.Default;
        }

        private void iconefechar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void iconefechar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void acessar_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void acessar_btn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}