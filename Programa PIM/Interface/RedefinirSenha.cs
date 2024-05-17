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

        private void picInfoEmail_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picInfoEmail_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picInfoPalavraChave_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picInfoPalavraChave_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void bttConfirmar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bttConfirmar_MouseLeave(object sender, EventArgs e)
        {
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

        private void lblEsqueciPalavraChave_MouseHover(object sender, EventArgs e)
        {
            lblEsqueciPalavraChave.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            Cursor = Cursors.Hand;
        }

        private void lblEsqueciPalavraChave_MouseLeave(object sender, EventArgs e)
        {
            lblEsqueciPalavraChave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cursor = Cursors.Default;
        }

        private void lblEsqueciPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor entrar em contato com o seu Superior, para redefiniçao de Senha e Palavra de Segurança.", "Redefinir Palavra de Segurança");
        }
    }
}
