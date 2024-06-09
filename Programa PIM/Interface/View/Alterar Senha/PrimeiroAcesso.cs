using Interface.Model;

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
            txtPalavraChave.TabIndex = 0;
            mskNovaSenha.TabIndex = 1;
            mskConfirmarSenha.TabIndex = 2;
            txtDicaSenha.TabIndex = 3;
            bttDefinirSenha.TabIndex = 4;
            bttCancelar.TabIndex = 5;
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
                Login login = new Login();
                login.Show();
                this.Close();
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
            AcoeLogin acoesLogin = new AcoeLogin();

            string email = acoesLogin.ExtrairEmail(txtUsuario.Text);    //  Extrair email através do usuario

            string cpf = acoesLogin.ExtrairCpf(email);  //  Verificação de comparação com o cpf
            string _cpf = cpf.Replace(".", "").Replace("-", "");
            int comprimentoMin = 4; //  Comprimento minimo da senha
            int comprimentoMax = 11;    //  Comprimento maximo da senha

            if (!String.IsNullOrWhiteSpace(txtPalavraChave.Text))
            {
                if (!String.IsNullOrWhiteSpace(txtDicaSenha.Text))
                {
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
                                    //  CONFIRMAÇÃO DE PALAVRA CHAVE
                                    if (MessageBox.Show("Garanta que sua palavra de segurança seja uma palavra da qual você se lembre, pois é através dela que você poderá alterar sua senha em caso de esquecimento!\n\nDeseja continuar com a alteração com essa palavra de segurança?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        int result = acoesLogin.AlterarSenha(email, mskConfirmarSenha.Text);    //  Alterar senha no banco
                                        acoesLogin.AlterarTabelaLogin("palavra_chave", txtPalavraChave.Text, txtUsuario.Text);  //  Salvar palavra chave no banco
                                        acoesLogin.AlterarTabelaLogin("dica_senha", txtDicaSenha.Text, txtUsuario.Text);    //  Salvar dica de senha no banco


                                        if (result == 1)
                                        {
                                            MessageBox.Show("Alteração feita com sucesso!", "Senha definida");
                                            Login login = new Login();
                                            login.Show();
                                            this.Close();
                                        }
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
                else
                {
                    MessageBox.Show("O campo Dica da Senha não foi preenchido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("O campo Palavra de Segurança não foi preenchido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        private void mskConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
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
        /// EVENTOS BOTÃO "INFO PALAVRA CHAVE" 
        ///
        private void picInfoPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deve colocar uma palavra da qual você irá lembrar para quando esquecer a senha, pois você poderá redefinir utilizando a palavra de segurança.", "Ajuda Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //  Animação do cursor
        private void picInfoPalavraChave_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picInfoPalavraChave_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTOS BOTÃO "INFO DICA SENHA" 
        ///
        private void picInfoDicaSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deve colocar uma dica para caso de esquecimento de senha, te ajudar a lembrá-la sem precisar redefiní-la.", "Ajuda Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //  Animação do cursor
        private void picInfoDicaSenha_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picInfoDicaSenha_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO BOTÃO "CANCELAR"
        ///
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar definição de senha?\n\nLembrando que você só poderá acessar o sistema após definir sua senha oficial", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        //Animação do cursor icone "Fechar"
        private void bttCancelar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttCancelar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
    }
}
