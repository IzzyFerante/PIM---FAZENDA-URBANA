using Interface.Model;

namespace Interface.View.Funcionarios
{
    public partial class VisualizarFuncionario : Form
    {
        private TelaFuncionarios formPrincipal;
        private string matricula;
        private TelaFuncionarios funcionarios;

        public VisualizarFuncionario(string matricula, string usuario, TelaFuncionarios func)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtMatricula.Text = matricula.PadLeft(6, '0');
            lblUsuario.Text = usuario;
            lblMatriculaInicial.Text = matricula.ToString();
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
            txtDescCargo.TabIndex = 7;
            txtSalario.TabIndex = 8;
            mskCep.TabIndex = 9;
            txtLogradouro.TabIndex = 10;
            txtNumero.TabIndex = 11;
            txtComplemento.TabIndex = 12;
            txtBairro.TabIndex = 13;
            txtEstado.TabIndex = 14;
            txtCidade.TabIndex = 15;
            bttConfirmar.TabIndex = 16;
        }


        /// 
        /// EVENTO DO BOTÃO "FECHAR"
        /// 
        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Animação do cursor botão "Confirmar"
        private void bttFechar_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void bttFechar_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        /// 
        /// EVENTO PARA PREENCHER OS DADOS PARA ALTERAÇÃO
        /// 
        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            string matricula = txtMatricula.Text.PadLeft(6, '0');

            //  CRIAR UMA FORMAR DE PREENCHER DADOS BOOLEANOS
            bool? funcAtivo = acoes.PuxarDadoBOOL("status", "funcionarios", "matricula", matricula); //  Verificar se funcionario esta ativo

            //  Preenche o check conforme salvo no banco
            if (funcAtivo == true)
            {
                checkFuncAtivo.CheckState = CheckState.Checked;
            }
            else
            {
                checkFuncAtivo.CheckState = CheckState.Unchecked;
            }

            string salario = acoes.preencherDadosExistentesNUMERIC("salario", "funcionarios", "matricula", matricula).ToString();

            //  Preencher os dados existentes
            txtNome.Text = acoes.preencherDadosExistentes("nome", "funcionarios", "matricula", matricula);
            txtEmail.Text = acoes.preencherDadosExistentes("email", "funcionarios", "matricula", matricula);
            mskCpf.Text = acoes.preencherDadosExistentes("cpf", "funcionarios", "matricula", matricula);
            mskTelefone.Text = acoes.preencherDadosExistentes("telefone", "funcionarios", "matricula", matricula);
            txtCodCargo.Text = acoes.preencherDadosExistentes("cod_cargo", "funcionarios", "matricula", matricula);
            txtSalario.Text = salario;
            mskCep.Text = acoes.preencherDadosExistentes("cep", "funcionarios", "matricula", matricula);
            txtLogradouro.Text = acoes.preencherDadosExistentes("logradouro", "funcionarios", "matricula", matricula);
            txtNumero.Text = acoes.preencherDadosExistentes("numero", "funcionarios", "matricula", matricula);
            txtComplemento.Text = acoes.preencherDadosExistentes("complemento", "funcionarios", "matricula", matricula);
            txtBairro.Text = acoes.preencherDadosExistentes("bairro", "funcionarios", "matricula", matricula);
            txtEstado.Text = acoes.preencherDadosExistentes("estado", "funcionarios", "matricula", matricula);
            txtCidade.Text = acoes.preencherDadosExistentes("cidade", "funcionarios", "matricula", matricula);

            //  Preencher os dados existentes DATAS
            DateTime? dataNascimento = acoes.preencherDadosExistentesDATA("data_nascimento", "funcionarios", "matricula", matricula);
            if (dataNascimento.HasValue)
            {
                mskDtNasc.Text = dataNascimento.Value.ToString("dd/MM/yyyy"); // Formata a data conforme necessário
            }

            txtDescCargo.Text = acoes.PuxarDescCargo(txtCodCargo.Text);

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
    }
}
