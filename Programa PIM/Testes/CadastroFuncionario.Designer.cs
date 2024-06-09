namespace Interface.View.Funcionarios
{
    partial class CadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            txtMatricula = new TextBox();
            picIcone = new PictureBox();
            faixadaVerde = new Panel();
            bttCancelar = new Button();
            bttConfirmar = new Button();
            panel3 = new Panel();
            bttMaximizar = new PictureBox();
            bttMinimizar = new PictureBox();
            bttRestaurar = new PictureBox();
            lblCadastroFuncionarios = new Label();
            panel1 = new Panel();
            panelicones = new Panel();
            panel2 = new Panel();
            lblMatricula = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            checkFuncAtivo = new CheckBox();
            lblDtNasc = new Label();
            mskDtNasc = new MaskedTextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCpf = new Label();
            mskCpf = new MaskedTextBox();
            lblTelefone = new Label();
            mskTelefone = new MaskedTextBox();
            lblCodCargo = new Label();
            txtCodCargo = new TextBox();
            txtDescCargo = new TextBox();
            lblDescCargo = new Label();
            lblSalario = new Label();
            lblCep = new Label();
            mskCep = new MaskedTextBox();
            label1 = new Label();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            lblNumero = new Label();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblEstado = new Label();
            txtEstado = new TextBox();
            picBuscaCargo = new PictureBox();
            txtSalario = new TextBox();
            lblInformaçõesEndereço = new Label();
            lblRisco = new Label();
            lblInformaçõesFuncionais = new Label();
            lblRisco2 = new Label();
            lblInformaçõesPessoais = new Label();
            lblRisco3 = new Label();
            lblObrigatoriedade = new Label();
            lblUsuario = new Label();
            lblMatriculaInicial = new Label();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            faixadaVerde.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bttRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaCargo).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatricula.Location = new Point(183, 317);
            txtMatricula.MaxLength = 6;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(82, 34);
            txtMatricula.TabIndex = 0;
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.output_onlinepngtools__23_;
            picIcone.Location = new Point(42, 61);
            picIcone.Name = "picIcone";
            picIcone.Size = new Size(155, 139);
            picIcone.SizeMode = PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 11;
            picIcone.TabStop = false;
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttCancelar);
            faixadaVerde.Controls.Add(bttConfirmar);
            faixadaVerde.Controls.Add(panel3);
            faixadaVerde.Controls.Add(lblCadastroFuncionarios);
            faixadaVerde.Controls.Add(picIcone);
            faixadaVerde.Controls.Add(panel1);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Controls.Add(panel2);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(1920, 200);
            faixadaVerde.TabIndex = 20;
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttCancelar.Location = new Point(1633, 133);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(120, 46);
            bttCancelar.TabIndex = 20;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            bttCancelar.Click += bttCancelar_Click;
            bttCancelar.MouseLeave += bttCancelar_MouseLeave;
            bttCancelar.MouseHover += bttCancelar_MouseHover;
            // 
            // bttConfirmar
            // 
            bttConfirmar.BackColor = Color.FromArgb(72, 44, 30);
            bttConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttConfirmar.ForeColor = SystemColors.ControlLightLight;
            bttConfirmar.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttConfirmar.Location = new Point(1779, 133);
            bttConfirmar.Name = "bttConfirmar";
            bttConfirmar.Size = new Size(120, 47);
            bttConfirmar.TabIndex = 20;
            bttConfirmar.Text = "Confirmar";
            bttConfirmar.UseVisualStyleBackColor = false;
            bttConfirmar.Click += bttConfirmar_Click;
            bttConfirmar.MouseLeave += bttConfirmar_MouseLeave;
            bttConfirmar.MouseHover += bttConfirmar_MouseHover;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.Controls.Add(bttMaximizar);
            panel3.Controls.Add(bttMinimizar);
            panel3.Controls.Add(bttRestaurar);
            panel3.Location = new Point(1789, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 40);
            panel3.TabIndex = 19;
            // 
            // bttMaximizar
            // 
            bttMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttMaximizar.Image = Properties.Resources.output_onlinepngtools__18_;
            bttMaximizar.Location = new Point(99, 12);
            bttMaximizar.Name = "bttMaximizar";
            bttMaximizar.Size = new Size(20, 20);
            bttMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            bttMaximizar.TabIndex = 4;
            bttMaximizar.TabStop = false;
            bttMaximizar.Visible = false;
            bttMaximizar.Click += bttMaximizar_Click;
            bttMaximizar.MouseLeave += bttMaximizar_MouseLeave;
            bttMaximizar.MouseHover += bttMaximizar_MouseHover;
            // 
            // bttMinimizar
            // 
            bttMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttMinimizar.Image = Properties.Resources.output_onlinepngtools__17_;
            bttMinimizar.Location = new Point(73, 12);
            bttMinimizar.Name = "bttMinimizar";
            bttMinimizar.Size = new Size(20, 20);
            bttMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            bttMinimizar.TabIndex = 3;
            bttMinimizar.TabStop = false;
            bttMinimizar.Click += bttMinimizar_Click;
            bttMinimizar.MouseLeave += bttMinimizar_MouseLeave;
            bttMinimizar.MouseHover += bttMinimizar_MouseHover;
            // 
            // bttRestaurar
            // 
            bttRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttRestaurar.Image = Properties.Resources.output_onlinepngtools__15_;
            bttRestaurar.Location = new Point(99, 12);
            bttRestaurar.Name = "bttRestaurar";
            bttRestaurar.Size = new Size(20, 20);
            bttRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            bttRestaurar.TabIndex = 2;
            bttRestaurar.TabStop = false;
            bttRestaurar.Click += bttRestaurar_Click;
            bttRestaurar.MouseLeave += bttRestaurar_MouseLeave;
            bttRestaurar.MouseHover += bttRestaurar_MouseHover;
            // 
            // lblCadastroFuncionarios
            // 
            lblCadastroFuncionarios.AutoSize = true;
            lblCadastroFuncionarios.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroFuncionarios.ForeColor = SystemColors.ControlLightLight;
            lblCadastroFuncionarios.Location = new Point(208, 134);
            lblCadastroFuncionarios.Name = "lblCadastroFuncionarios";
            lblCadastroFuncionarios.Size = new Size(361, 46);
            lblCadastroFuncionarios.TabIndex = 18;
            lblCadastroFuncionarios.Text = "Cadastro Funcionário";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(5209, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 40);
            panel1.TabIndex = 6;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(5991, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Location = new Point(3509, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(128, 40);
            panel2.TabIndex = 17;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatricula.Location = new Point(60, 319);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(117, 28);
            lblMatricula.TabIndex = 21;
            lblMatricula.Text = "*Matrícula:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(535, 319);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(83, 28);
            lblNome.TabIndex = 22;
            lblNome.Text = "*Nome:";
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(624, 316);
            txtNome.MaxLength = 45;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(640, 34);
            txtNome.TabIndex = 23;
            txtNome.Tag = "";
            // 
            // checkFuncAtivo
            // 
            checkFuncAtivo.AutoSize = true;
            checkFuncAtivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkFuncAtivo.Location = new Point(1697, 245);
            checkFuncAtivo.Name = "checkFuncAtivo";
            checkFuncAtivo.Size = new Size(163, 32);
            checkFuncAtivo.TabIndex = 25;
            checkFuncAtivo.Text = "Usuário Ativo";
            checkFuncAtivo.UseVisualStyleBackColor = true;
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDtNasc.Location = new Point(1550, 319);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(190, 28);
            lblDtNasc.TabIndex = 26;
            lblDtNasc.Text = "*Data Nascimento:";
            // 
            // mskDtNasc
            // 
            mskDtNasc.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskDtNasc.Location = new Point(1746, 316);
            mskDtNasc.Mask = "00/00/0000";
            mskDtNasc.Name = "mskDtNasc";
            mskDtNasc.Size = new Size(114, 34);
            mskDtNasc.TabIndex = 27;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(60, 429);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 28);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "*Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(144, 426);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(500, 34);
            txtEmail.TabIndex = 29;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(963, 429);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(60, 28);
            lblCpf.TabIndex = 30;
            lblCpf.Text = "*CPF:";
            // 
            // mskCpf
            // 
            mskCpf.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCpf.Location = new Point(1029, 426);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(156, 34);
            mskCpf.TabIndex = 31;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(1521, 429);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(174, 28);
            lblTelefone.TabIndex = 32;
            lblTelefone.Text = "Telefone/Celular:";
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskTelefone.Location = new Point(1701, 426);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(159, 34);
            mskTelefone.TabIndex = 33;
            // 
            // lblCodCargo
            // 
            lblCodCargo.AutoSize = true;
            lblCodCargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodCargo.Location = new Point(60, 595);
            lblCodCargo.Name = "lblCodCargo";
            lblCodCargo.Size = new Size(128, 28);
            lblCodCargo.TabIndex = 34;
            lblCodCargo.Text = "*Cód. Cargo:";
            // 
            // txtCodCargo
            // 
            txtCodCargo.CharacterCasing = CharacterCasing.Upper;
            txtCodCargo.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodCargo.Location = new Point(192, 593);
            txtCodCargo.MaxLength = 5;
            txtCodCargo.Name = "txtCodCargo";
            txtCodCargo.Size = new Size(67, 34);
            txtCodCargo.TabIndex = 35;
            txtCodCargo.Leave += txtCodCargo_Leave;
            // 
            // txtDescCargo
            // 
            txtDescCargo.CharacterCasing = CharacterCasing.Upper;
            txtDescCargo.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescCargo.Location = new Point(865, 593);
            txtDescCargo.MaxLength = 35;
            txtDescCargo.Name = "txtDescCargo";
            txtDescCargo.ReadOnly = true;
            txtDescCargo.Size = new Size(381, 34);
            txtDescCargo.TabIndex = 36;
            // 
            // lblDescCargo
            // 
            lblDescCargo.AutoSize = true;
            lblDescCargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescCargo.Location = new Point(689, 595);
            lblDescCargo.Name = "lblDescCargo";
            lblDescCargo.Size = new Size(170, 28);
            lblDescCargo.TabIndex = 37;
            lblDescCargo.Text = "Descrição Cargo:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalario.Location = new Point(1641, 595);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(88, 28);
            lblSalario.TabIndex = 39;
            lblSalario.Text = "Salário: ";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCep.Location = new Point(60, 754);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(52, 28);
            lblCep.TabIndex = 40;
            lblCep.Text = "CEP:";
            // 
            // mskCep
            // 
            mskCep.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCep.Location = new Point(118, 752);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(107, 34);
            mskCep.TabIndex = 41;
            mskCep.Leave += mskCep_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(540, 754);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 42;
            label1.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(672, 752);
            txtLogradouro.MaxLength = 50;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(650, 34);
            txtLogradouro.TabIndex = 43;
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(1733, 752);
            txtNumero.MaxLength = 10;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(127, 34);
            txtNumero.TabIndex = 44;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.Location = new Point(1633, 754);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(94, 28);
            lblNumero.TabIndex = 45;
            lblNumero.Text = "Número:";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComplemento.Location = new Point(60, 893);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(149, 28);
            lblComplemento.TabIndex = 46;
            lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(215, 891);
            txtComplemento.MaxLength = 20;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(240, 34);
            txtComplemento.TabIndex = 47;
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(612, 891);
            txtBairro.MaxLength = 30;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(440, 34);
            txtBairro.TabIndex = 48;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBairro.Location = new Point(531, 893);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(75, 28);
            lblBairro.TabIndex = 49;
            lblBairro.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(1427, 891);
            txtCidade.MaxLength = 30;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(433, 34);
            txtCidade.TabIndex = 50;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.Location = new Point(1340, 893);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(81, 28);
            lblCidade.TabIndex = 51;
            lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(1123, 893);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(80, 28);
            lblEstado.TabIndex = 52;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtEstado.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(1209, 891);
            txtEstado.MaxLength = 2;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(43, 34);
            txtEstado.TabIndex = 53;
            // 
            // picBuscaCargo
            // 
            picBuscaCargo.Image = Properties.Resources.search_3917132;
            picBuscaCargo.Location = new Point(265, 599);
            picBuscaCargo.Name = "picBuscaCargo";
            picBuscaCargo.Size = new Size(20, 25);
            picBuscaCargo.SizeMode = PictureBoxSizeMode.Zoom;
            picBuscaCargo.TabIndex = 54;
            picBuscaCargo.TabStop = false;
            picBuscaCargo.Click += picBuscaCargo_Click;
            picBuscaCargo.MouseHover += bttCancelar_MouseHover;
            picBuscaCargo.MouseLeave += bttCancelar_MouseLeave;
            // 
            // txtSalario
            // 
            txtSalario.CharacterCasing = CharacterCasing.Upper;
            txtSalario.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalario.Location = new Point(1735, 593);
            txtSalario.MaxLength = 11;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 34);
            txtSalario.TabIndex = 55;
            txtSalario.Text = "0";
            // 
            // lblInformaçõesEndereço
            // 
            lblInformaçõesEndereço.AutoSize = true;
            lblInformaçõesEndereço.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesEndereço.Location = new Point(60, 672);
            lblInformaçõesEndereço.Name = "lblInformaçõesEndereço";
            lblInformaçõesEndereço.Size = new Size(154, 37);
            lblInformaçõesEndereço.TabIndex = 56;
            lblInformaçõesEndereço.Text = "ENDEREÇO";
            // 
            // lblRisco
            // 
            lblRisco.AutoSize = true;
            lblRisco.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco.Location = new Point(60, 692);
            lblRisco.Name = "lblRisco";
            lblRisco.Size = new Size(1805, 38);
            lblRisco.TabIndex = 57;
            lblRisco.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblInformaçõesFuncionais
            // 
            lblInformaçõesFuncionais.AutoSize = true;
            lblInformaçõesFuncionais.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesFuncionais.Location = new Point(55, 513);
            lblInformaçõesFuncionais.Name = "lblInformaçõesFuncionais";
            lblInformaçõesFuncionais.Size = new Size(283, 37);
            lblInformaçõesFuncionais.TabIndex = 58;
            lblInformaçõesFuncionais.Text = "DADOS FUNCIONAIS";
            // 
            // lblRisco2
            // 
            lblRisco2.AutoSize = true;
            lblRisco2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco2.Location = new Point(55, 533);
            lblRisco2.Name = "lblRisco2";
            lblRisco2.Size = new Size(1805, 38);
            lblRisco2.TabIndex = 59;
            lblRisco2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblInformaçõesPessoais
            // 
            lblInformaçõesPessoais.AutoSize = true;
            lblInformaçõesPessoais.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesPessoais.Location = new Point(60, 239);
            lblInformaçõesPessoais.Name = "lblInformaçõesPessoais";
            lblInformaçõesPessoais.Size = new Size(242, 37);
            lblInformaçõesPessoais.TabIndex = 58;
            lblInformaçõesPessoais.Text = "DADOS PESSOAIS";
            // 
            // lblRisco3
            // 
            lblRisco3.AutoSize = true;
            lblRisco3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco3.Location = new Point(60, 259);
            lblRisco3.Name = "lblRisco3";
            lblRisco3.Size = new Size(1805, 38);
            lblRisco3.TabIndex = 59;
            lblRisco3.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblObrigatoriedade
            // 
            lblObrigatoriedade.AutoSize = true;
            lblObrigatoriedade.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblObrigatoriedade.ForeColor = SystemColors.ControlDark;
            lblObrigatoriedade.Location = new Point(60, 203);
            lblObrigatoriedade.Name = "lblObrigatoriedade";
            lblObrigatoriedade.Size = new Size(219, 24);
            lblObrigatoriedade.TabIndex = 60;
            lblObrigatoriedade.Text = "*Dados Obrigatórios";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.ControlLightLight;
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(1908, 1051);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 61;
            // 
            // lblMatriculaInicial
            // 
            lblMatriculaInicial.AutoSize = true;
            lblMatriculaInicial.ForeColor = SystemColors.ControlLightLight;
            lblMatriculaInicial.Location = new Point(1853, 1065);
            lblMatriculaInicial.Name = "lblMatriculaInicial";
            lblMatriculaInicial.Size = new Size(0, 20);
            lblMatriculaInicial.TabIndex = 62;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1920, 1080);
            Controls.Add(lblMatriculaInicial);
            Controls.Add(lblUsuario);
            Controls.Add(lblObrigatoriedade);
            Controls.Add(lblInformaçõesPessoais);
            Controls.Add(lblInformaçõesFuncionais);
            Controls.Add(lblRisco2);
            Controls.Add(lblInformaçõesEndereço);
            Controls.Add(txtSalario);
            Controls.Add(picBuscaCargo);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(lblCidade);
            Controls.Add(txtCidade);
            Controls.Add(lblBairro);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(label1);
            Controls.Add(mskCep);
            Controls.Add(lblCep);
            Controls.Add(lblSalario);
            Controls.Add(lblDescCargo);
            Controls.Add(txtDescCargo);
            Controls.Add(txtCodCargo);
            Controls.Add(lblCodCargo);
            Controls.Add(mskTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(mskCpf);
            Controls.Add(lblCpf);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(mskDtNasc);
            Controls.Add(lblDtNasc);
            Controls.Add(checkFuncAtivo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblMatricula);
            Controls.Add(faixadaVerde);
            Controls.Add(txtMatricula);
            Controls.Add(lblRisco);
            Controls.Add(lblRisco3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarFuncionario";
            WindowState = FormWindowState.Maximized;
            Load += CadastroFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bttMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bttRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaCargo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private PictureBox picIcone;
        private Panel faixadaVerde;
        private Label lblCadastroFuncionarios;
        private Panel panel1;
        private Panel panelicones;
        private Panel panel2;
        private Panel panel3;
        private PictureBox bttMaximizar;
        private PictureBox bttMinimizar;
        private PictureBox bttRestaurar;
        private Label lblMatricula;
        private Label lblNome;
        private TextBox txtNome;
        private CheckBox checkFuncAtivo;
        private Label lblDtNasc;
        private MaskedTextBox mskDtNasc;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCpf;
        private MaskedTextBox mskCpf;
        private Label lblTelefone;
        private MaskedTextBox mskTelefone;
        private Label lblCodCargo;
        private TextBox txtCodCargo;
        private TextBox txtDescCargo;
        private Label lblDescCargo;
        private Label lblSalario;
        private Button bttCancelar;
        private Button bttConfirmar;
        private Label lblCep;
        private MaskedTextBox mskCep;
        private Label label1;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private Label lblNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblEstado;
        private TextBox txtEstado;
        private PictureBox picBuscaCargo;
        private TextBox txtSalario;
        private Label lblInformaçõesEndereço;
        private Label lblRisco;
        private Label lblInformaçõesFuncionais;
        private Label lblRisco2;
        private Label lblInformaçõesPessoais;
        private Label lblRisco3;
        private Label lblObrigatoriedade;
        private Label lblUsuario;
        private Label lblMatriculaInicial;
    }
}