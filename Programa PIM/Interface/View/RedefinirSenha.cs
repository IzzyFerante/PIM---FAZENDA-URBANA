using Interface.Model;
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
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
            InitializeTabOrder();   // Inicializar a ação de ordenar a sequência de TAB
        }


        /// 
        /// Evento para definir a ordem da tecla TAB
        /// 
        private void InitializeTabOrder()
        {
            txtEmail.TabIndex = 0;
            txtPalavraChave.TabIndex = 1;
            bttConfirmar.TabIndex = 2;
        }


        ///
        /// Eventos botão "InfoEmail"
        ///
        private void picInfoEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coloque o seu email cadastrado no sistema!\n\nCaso não se lembre, favor contatar seu Superior para redefinição.", "Ajuda  Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Animação do cursor em cima do "InfoEmail"
        private void picInfoEmail_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void picInfoEmail_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "InfoPalavraChave"
        ///
        private void picInfoPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite a sua Palavra de Segurança que foi cadastrada no momento de criação da senha.\n\nCaso não se lembre, favor contatar seu Superior para redefinição.", "Ajuda Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        //Animação do cursor em cima do "InfoPalavraChave"
        private void picInfoPalavraChave_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void picInfoPalavraChave_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// Eventos botão "Confirmar"
        ///
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            AcoeLogin acoesLogin = new AcoeLogin();
            int result = acoesLogin.RedefinirSenha(txtEmail.Text, txtPalavraChave.Text);

            

            if (result == 1)  //  DADOS CORRETOS
            {
                MessageBox.Show("Dados corretos!");
                RedefinirSenha2 RedefinirSenha2 = new RedefinirSenha2(txtEmail.Text);
                RedefinirSenha2.Show();
                this.Close();
            }
            else if (result == 0)   //  DADOS ERRADOS
            {
                MessageBox.Show("Email ou Palavra de Segurança incorretos!\n\nVerifique as letras maiúsculas ou minúsculas.");
            }
        }

        //Animação do cursor em cima do "Confirmar"
        private void bttConfirmar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void bttConfirmar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        // Confirmar com a tecla "Enter"
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttConfirmar.PerformClick();
            }
        }

        private void txtPalavraChave_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttConfirmar.PerformClick();
            }
        }


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

        ///
        /// Eventos botão "Cancelar"
        ///
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.Show();
        }

        //Animação do cursor em cima do "Fechar"
        private void bttCancelar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void bttCancelar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        
    }
}
