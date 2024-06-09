using Interface.Model;


namespace Interface.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeTabOrder();   // Inicializar a ação de ordenar a sequência de TAB
        }


        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            txtUsuario.TabIndex = 0;
            mskSenha.TabIndex = 1;
            bttAcessar.TabIndex = 2;
        }


        ///
        /// Eventos botão "Acessar"
        ///
        private void bttAcessar_Click(object sender, EventArgs e)
        {
            AcoeLogin AcoesLogin = new AcoeLogin(); // CHAMA A CLASSE DAS AÇÕES DE LOGIN

            // Verificando se os dados estão correto
            int result = AcoesLogin.AcessoLogin(txtUsuario.Text, mskSenha.Text);
            if (result == 1) // Login realizado com sucesso
            {
                bool statusUsuario = AcoesLogin.StatusLogin(txtUsuario.Text);
                if (statusUsuario == true)
                {
                    try
                    {
                        if (mskSenha.Text.Length > 8) //  É O PRIMEIRO ACESSO, pois a senha oficial tem apenas 8 caracteres
                        {
                            PrimeiroAcesso primeiroAcesso = new PrimeiroAcesso(txtUsuario.Text);
                            MessageBox.Show("Olá! Seja bem vindo ao UrbanFarm Manager :)\n\nComo é o seu primeiro acesso, iremos te redirecionar para você criar a sua senha oficial.", "Primeiro Acesso");
                            primeiroAcesso.Show();
                            this.Hide();
                        }
                        else    // NÃO É O PRIMEIRO ACESSO
                        {
                            Menu menu1 = new Menu(txtUsuario.Text);
                            MessageBox.Show("Login realizado com sucesso!", "Acesso permitido");
                            menu1.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Algo deu errado, tente novamente\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Acesso bloqueado!\n\nUsuário está inativado, caso isso seja um erro, favor falar com seu Superior para correção", "Usuário inativo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (result == 0)
            {
                AcoeLogin acoes = new AcoeLogin();
                string dicaSenha = acoes.ExtrairDicaSenha(txtUsuario.Text);
                MessageBox.Show($"Usuário ou senha incorretos!\n\nDica de senha: {dicaSenha}", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //Animação cursor botão "Acessar"
        private void bttAcessar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttAcessar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        // Confirmar com a tecla "Enter"
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttAcessar.PerformClick();
            }
        }
        private void mskSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttAcessar.PerformClick();
            }
        }


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


        /// 
        /// EVENTOS BOTÃO "INFO LOGIN"
        /// 
        private void picInfoLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seu usuário será seu primeiro nome e seu último sobrenome, separados apenas por um ponto final (.) sem espaços \n\n Sua senha é a que você definiu em seu primeiro acesso\n *Caso seja seu primeiro acesso, sua senha será seu CPF sem pontuações e espaços", "Ajuda Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //  Animação do cursor "Info Login"
        private void picInfoLogin_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void picInfoLogin_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
    }
}