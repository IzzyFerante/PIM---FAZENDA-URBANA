using Interface.Model;

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
                Login login = new Login();
                login.Show();
                this.Close();
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
            AcoeLogin acoesLogin = new AcoeLogin();

            string cpf = acoesLogin.ExtrairCpf(txtEmail.Text);  //  Verificação de comparação com o cpf
            string _cpf = cpf.Replace(".", "").Replace("-", "");
            int comprimentoMin = 4; //  Comprimento minimo da senha
            int comprimentoMax = 11;    //  Comprimento maximo da senha


            if (mskNovaSenha.TextLength >= comprimentoMin)  //  VERIFICAÇÃO TAMANHO MINIMO
            {
                if (mskNovaSenha.TextLength <= comprimentoMax)   //  VERIFICAÇÃO TAMANHO MAXIMO
                {
                    if (mskNovaSenha.Text == mskConfirmarSenha.Text)    //  VERIFICAÇÃO SENHAS IGUAIS
                    {
                        if (mskNovaSenha.Text == _cpf)   //  VERIFICAÇÃO DE COMPARAÇÃO COM O CPF
                        {
                            MessageBox.Show($"A senha não deve ser igual seu CPF.", "Senha invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else     //  VERIFICAÇÃO DE COMPARAÇÃO COM O CPF
                        {
                            int result = acoesLogin.AlterarSenha(txtEmail.Text, mskConfirmarSenha.Text);

                            if (result == 1)
                            {
                                MessageBox.Show("Senha alterada!");
                                Login login = new Login();
                                login.Show();
                                this.Close();
                            }
                        }
                    }
                    else  //  VERIFICAÇÃO SENHAS IGUAIS
                    {
                        MessageBox.Show("Senhas divergentes!", "Atenção");
                    }
                }
                else    //  VERIFICAÇÃO TAMANHO MAXIMO
                {
                    MessageBox.Show($"A senha deve conter no máximo {comprimentoMax} caracteres.", "Comprimento máximo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else    //  VERIFICAÇÃO TAMANHO MINIMO
            {
                MessageBox.Show($"A senha deve conter pelo menos {comprimentoMin} caracteres.", "Comprimento mínimo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Animação cursor botão "Alterar Senha"
        private void bttAlterarSenha_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttAlterarSenha_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        // Confirmar com a tecla "Enter"
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


        ///
        /// Eventos botão "Cancelar"
        ///
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar redefinição de senha?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
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
            RedefinirSenha redefinirSenha1 = new RedefinirSenha();
            redefinirSenha1.Show();
            this.Close();
        }

        //Animação do cursor icone "Voltar"
        private void picVoltar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picVoltar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
    }
}
