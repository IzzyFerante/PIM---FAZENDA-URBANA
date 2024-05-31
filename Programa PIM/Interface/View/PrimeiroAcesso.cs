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
    public partial class PrimeiroAcesso : Form
    {
        public PrimeiroAcesso(string inUsuario)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtUsuario.Text = inUsuario;
        }


        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            mskNovaSenha.TabIndex = 0;
            mskConfirmarSenha.TabIndex = 1;
            bttDefinirSenha.TabIndex = 2;
        }


        ///
        /// EVENTOS BOTÃO "OLHAR SENHA"
        ///
            //  Animação das senhas
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


        /// 
        /// EVENTOS BOTÃO FECHAR
        /// 
        private void iconFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar definição de senha?\n\nLembrando que você só poderá acessar o sistema após definir sua senha oficial", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
        /// EVENTOS BOTÃO "DEFINIR SENHA"
        /// 
        private void bttDefinirSenha_Click(object sender, EventArgs e)
        {
            if (mskNovaSenha.Text == mskConfirmarSenha.Text)
            {
                AcoeLogin acoesLogin = new AcoeLogin(); //  CHAMANDO A CLASSE DE AÇÕES
                string email = acoesLogin.ExtrairEmail(txtUsuario.Text);
                int result = acoesLogin.AlterarSenha(email, mskConfirmarSenha.Text);    //  UTILIZANDO METODO ALTERAR SENHA
                if (result == 1)
                {
                    MessageBox.Show("Senha alterada!");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Senhas divergentes!", "Atenção");
            }
        }

        //Animação do cursor icone "Definir Senha"
        private void bttDefinirSenha_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttDefinirSenha_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        // Confirmar com a tecla "Enter"
        private void mskNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttDefinirSenha.PerformClick();
            }
        }

        private void mskConfimarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttDefinirSenha.PerformClick();
            }
        }


        /// 
        /// EVENTOS BOTÃO "INFO USUARIO" 
        ///
        private void picInfoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deve colocar o seu usuário cadastrado no sistema!\n\nSeu usuário é o seu primeiro nome e seu ultímo sobrenome, separados por um ponto final (.). Sem espaços.", "Ajuda Usuário");
        }
        //  Animação do cursor
        private void picInfoUsuario_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picInfoUsuario_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar definição de senha?\n\nLembrando que você só poderá acessar o sistema após definir sua senha oficial", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }
        //Animação do cursor icone "Fechar"
        private void bttCancelar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttCancelar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
    }
}
