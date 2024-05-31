using Interface.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View
{
    public partial class RedefinirSenha2 : Form
    {
        public RedefinirSenha2(string email)
        {
            InitializeComponent();
            InitializeTabOrder();   // Inicializar a ação de ordenar a sequência de TAB

            txtEmail.Text = email;  // Importa o email inserido do usuário para fazer alteração da senha
        }


        /// 
        /// Evento para definir a ordem da tecla TAB
        /// 
        private void InitializeTabOrder()
        {
            mskNovaSenha.TabIndex = 0;
            mskConfirmarSenha.TabIndex = 1;
            bttAlterarSenha.TabIndex = 2;
        }


        ///
        /// Eventos icone "Fechar"
        ///
        private void iconFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar redefinição de senha?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
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
                AcoeLogin acoesLogin = new AcoeLogin();
                int result = acoesLogin.AlterarSenha(txtEmail.Text, mskConfirmarSenha.Text);

                if (result == 1)
                {
                    MessageBox.Show("Senha alterada!");
                    Login login = new Login();
                    this.Close();
                    login.Show();
                }
            }
            else
            {
                MessageBox.Show("Senhas divergentes!", "Atenção");
            }
        }

        //Animação cursor botão "Alterar Senha"
        private void bttAlterarSenha_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void bttAlterarSenha_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        // Confirmar com a tecla "Enter"
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttAlterarSenha.PerformClick();
            }
        }

        private void mskNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttAlterarSenha.PerformClick();
            }
        }

        private void mskConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttAlterarSenha.PerformClick();
            }
        }



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

        private void picInfoEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deve colocar o seu email cadastrado no sistema!\n\nCaso não saiba, favor contatar seu superior.", "Ajuda Usuário");
        }
        //  Animação do cursor
        private void picInfoEmail_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picInfoEmail_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "Cancelar"
        ///
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar redefinição de senha?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        //Animação do cursor icone "Fechar"
        private void bttCancelar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void bttCancelar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// Eventos icone "Voltar"
        /// 
        private void picVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            RedefinirSenha redefinirSenha1 = new RedefinirSenha();
            redefinirSenha1.Show();
        }

        //Animação do cursor icone "Voltar"
        private void picVoltar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void picVoltar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


    
    }
}
