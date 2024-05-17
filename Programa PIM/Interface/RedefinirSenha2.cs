using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class RedefinirSenha2 : Form
    {
        public RedefinirSenha2()
        {
            InitializeComponent();
        }

        private void iconefechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.Show();
        }

        private void bttAlterarSenha_Click(object sender, EventArgs e)
        {
            if (mskNovaSenha.Text == mskConfirmarSenha.Text)
            {
                DadosLogin DadosLogin1 = new DadosLogin();
                DadosLogin1.password = mskNovaSenha.Text;
                MessageBox.Show("Senha alterada!");
                Login Login2 = new Login();
                this.Close();
                Login2.Show();
            }
            else
            {
                MessageBox.Show("Senhas divergentes!", "Atenção");
            }

        }

        private void bttAlterarSenha_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bttAlterarSenha_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void bttAlterar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bttAlterar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picOlhaSenha_MouseHover(object sender, EventArgs e)
        {
            mskNovaSenha.PasswordChar = '\u0000';
            mskConfirmarSenha.PasswordChar = '\u0000';
        }

        private void picOlhaSenha_MouseLeave(object sender, EventArgs e)
        {
            mskNovaSenha.PasswordChar = '*';
            mskConfirmarSenha.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A senha deve ter até 8 caracteres");
        }
    }
}
