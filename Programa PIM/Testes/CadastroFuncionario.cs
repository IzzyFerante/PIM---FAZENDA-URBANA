using Refit;
using Testes;

namespace Interface.View.Funcionarios
{
    public partial class CadastroFuncionario : Form
    {
        private Funcionarios formPrincipal;
        private Funcionarios funcionarios;

        public CadastroFuncionario(string usuario, Funcionarios func)
        {
            InitializeComponent();
            InitializeTabOrder();

            lblUsuario.Text = usuario;
            formPrincipal = func;
        }


        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            txtMatricula.TabIndex = 0;
            txtNome.TabIndex = 1;
            mskDtNasc.TabIndex = 2;
            txtEmail.TabIndex = 3;
            mskCpf.TabIndex = 4;
            mskTelefone.TabIndex = 5;
            txtCodCargo.TabIndex = 6;
            txtSalario.TabIndex = 7;
            mskCep.TabIndex = 8;
            txtLogradouro.TabIndex = 9;
            txtNumero.TabIndex = 10;
            txtComplemento.TabIndex = 11;
            txtBairro.TabIndex = 12;
            txtEstado.TabIndex = 13;
            txtCidade.TabIndex = 14;
            bttConfirmar.TabIndex = 15;
            bttCancelar.TabIndex = 16;
            txtMatricula.TabIndex = 17;
        }


        /// 
        /// EVENTO DO BOTÃO "CANCELAR"
        /// 
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //  Animação do cursor botão "Cancelar"
        private void bttCancelar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttCancelar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// AÇÃO PARA GARANTIR QUE O DADOS OBRIGATÓRIOS SEJAM INSERIDOS
        /// 
        private bool ValidarCamposObrigatorios()
        {
            return !string.IsNullOrWhiteSpace(txtMatricula.Text)
                && !string.IsNullOrWhiteSpace(txtNome.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(mskCpf.Text)
                && !string.IsNullOrWhiteSpace(txtCodCargo.Text)
                && !string.IsNullOrWhiteSpace(mskDtNasc.Text);
        }

        /*private bool ValidarCamposData()
        {
        }

        private bool ValidarCamposEmail()
        {
        }

        private bool ValidarCamposCpf()
        {
        }

        private bool ValidarCamposData()
        {
        }*/


        /// 
        /// EVENTO DO BOTÃO "CONFIRMAR"
        /// 
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObrigatorios())
            {
                AcoesFuncionarios acoes = new AcoesFuncionarios();

                //  Verificar se funcionario é ativo ou não
                bool funcAtivo = false;

                //  Definir bool de status do funcionario conforme preenchido
                if (checkFuncAtivo.CheckState == CheckState.Checked)
                {
                    funcAtivo = true;
                }

                string matricula = txtMatricula.Text.PadLeft(6, '0');
                DateTime dataNascimento = DateTime.ParseExact(mskDtNasc.Text, "dd/MM/yyyy", null);
                string salario = txtSalario.Text.Replace(',', '.');

                //  Insere cadastro no banco
                acoes.CadastrarDado(funcAtivo, txtNome.Text, dataNascimento, txtEmail.Text, mskCpf.Text, mskTelefone.Text, txtCodCargo.Text, salario, mskCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtEstado.Text, txtCidade.Text);

                string senha = acoes.senhaUsuario(mskCpf.Text);
                string usuario = acoes.usuario(txtNome.Text);

                MessageBox.Show($"Usuário criado para acesso ao sistema.\n\nUsuário: {usuario}\nSenha: {senha}");

                formPrincipal.AtualizarDataGridView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Algum dado obrigatório não foi preenchido, favor verificar se todos os campos com asterisco (*) foram preenchidos.", "Erro de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Animação do cursor botão "Confirmar"
        private void bttConfirmar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttConfirmar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO PARA PUXAR CEP DA API
        /// 
        private void mskCep_Leave(object sender, EventArgs e)
        {
            BuscarCep(mskCep.Text);
        }

        async Task BuscarCep(string cep)
        {
            try
            {
                var cepBuscar = RestService.For<ICepApiService>("https://viacep.com.br/");
                var endereco = await cepBuscar.GetAddressAsync(cep);

                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Localidade;
                txtEstado.Text = endereco.Uf;
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha! \n" + e);
            }
        }


        ///
        /// EVENTO PARA PUXAR NA TABELA CARGO O NOME
        ///
        private void txtCodCargo_Leave(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            txtDescCargo.Text = acoes.PuxarDescCargo(txtCodCargo.Text);
        }


        /// 
        /// EVENTO DA BUSCA CARGO
        /// 
        private void picBuscaCargo_Click(object sender, EventArgs e)
        {
            View.Funcionarios.Cargo telaCargo = new View.Funcionarios.Cargo();
            telaCargo.Show();
        }









        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"
        /// 
        private void bttMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //  Alterar os botões visiveis
            bttRestaurar.Visible = true;
            bttMaximizar.Visible = false;

            /*  Redimensionar icones
            faixadaVerde.Size = new Size(1920, 200);
            dataGridView1.Size = new Size(1840, 740);
            picIcone.Size = new Size(155, 139);

            float newSize = 20.0f;
            Font newFont = new Font(lblAlterarFuncionarios.Font.FontFamily, newSize, lblAlterarFuncionarios.Font.Style);
            lblAlterarFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 228);
            bttAlterar.Location = new Point(180, 228);
            bttDeletar.Location = new Point(320, 228);
            dataGridView1.Location = new Point(40, 296);
            picIcone.Location = new Point(42, 61);
            lblAlterarFuncionarios.Location = new Point(208, 134);*/
        }

        //  Animação do cursor botão "Maximizar"
        private void bttMaximizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttMaximizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO BOTÃO "RESTAURAR"
        /// 
        private void bttRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            //  Altera os botões visiveis
            bttRestaurar.Visible = false;
            bttMaximizar.Visible = true;

            //  Centraliza a tela
            //this.CenterToScreen();

            /*  Redimensionar icones
            ClientSize = new Size(960, 540);
            faixadaVerde.Size = new Size(960, 125);
            dataGridView1.Size = new Size(880, 280);
            picIcone.Size = new Size(100, 84);

            float newSize = 15.0f;
            Font newFont = new Font(lblAlterarFuncionarios.Font.FontFamily, newSize, lblAlterarFuncionarios.Font.Style);
            lblAlterarFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 153);
            bttAlterar.Location = new Point(180, 153);
            bttDeletar.Location = new Point(320, 153);
            dataGridView1.Location = new Point(40, 221);
            picIcone.Location = new Point(42, 41);
            lblAlterarFuncionarios.Location = new Point(151, 80);*/
        }

        //  Animação do cursor botão "Restaurar"
        private void bttRestaurar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttRestaurar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void bttMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  Animação do cursor botão "Minimizar"
        private void bttMinimizar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttMinimizar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO PARA QUANDO ABRIR TELA O CHECK DE FUNCIONARIO ATIVO JÁ ESTAR ASSINALADO
        ///
        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            checkFuncAtivo.CheckState = CheckState.Checked;

            int ultimaMatricula = int.Parse(acoes.NovaMatricula("funcionarios", "matricula"));
            string matricula = (ultimaMatricula + 1).ToString().PadLeft(6, '0');
            txtMatricula.Text = matricula;
        }



    }
}
