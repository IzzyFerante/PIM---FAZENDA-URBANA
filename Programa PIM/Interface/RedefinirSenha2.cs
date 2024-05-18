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


        ///
        /// Eventos icone "Fechar"
        ///
        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.Show();
        }

            //Animação do cursor icone "Fechar"
        private void iconFechar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void iconFechar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "Alterar Senha"
        ///
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

            //Animação cursor botão "Alterar Senha"
        private void bttAlterarSenha_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void bttAlterarSenha_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// Eventos botão "OlharSenha"
        /// 

        //Animação cursor botão "Olhar Senha"
        private void picOlharSenha_MouseHover(object sender, EventArgs e)
        {
            mskNovaSenha.PasswordChar = '\u0000';
            mskConfirmarSenha.PasswordChar = '\u0000';
        }

        private void picOlharSenha_MouseLeave(object sender, EventArgs e)
        {
            mskNovaSenha.PasswordChar = '*';
            mskConfirmarSenha.PasswordChar = '*';
        }

        
    }
}
