namespace Interface.View.Clientes
{
    partial class AtualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarCliente));
            mskCpf = new MaskedTextBox();
            checkCnpj = new CheckBox();
            checkCpf = new CheckBox();
            mskTelefone2 = new MaskedTextBox();
            lblTelefone2 = new Label();
            lblMatriculaInicial = new Label();
            lblUsuario = new Label();
            lblObrigatoriedade = new Label();
            lblInformaçõesFornecedor = new Label();
            lblInformaçõesEndereço = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            label1 = new Label();
            mskCep = new MaskedTextBox();
            lblCep = new Label();
            mskTelefone1 = new MaskedTextBox();
            lblTelefone1 = new Label();
            mskCnpj = new MaskedTextBox();
            lblCnpj = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            checkClienteAtivo = new CheckBox();
            txtNome = new TextBox();
            lblNome = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblRisco = new Label();
            lblRisco3 = new Label();
            lblInformaçõesContato = new Label();
            lblRisco2 = new Label();
            faixadaVerde = new Panel();
            bttMinimizar = new PictureBox();
            lblCadastrarCliente = new Label();
            picIcone = new PictureBox();
            bttCancelar = new Button();
            bttConfirmar = new Button();
            panel2 = new Panel();
            panelicones = new Panel();
            panel4 = new Panel();
            faixadaVerde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            SuspendLayout();
            // 
            // mskCpf
            // 
            mskCpf.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCpf.Location = new Point(1633, 343);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.ReadOnly = true;
            mskCpf.Size = new Size(210, 34);
            mskCpf.TabIndex = 107;
            mskCpf.Leave += mskCpf_Leave;
            // 
            // checkCnpj
            // 
            checkCnpj.AutoSize = true;
            checkCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkCnpj.Location = new Point(1544, 388);
            checkCnpj.Name = "checkCnpj";
            checkCnpj.Size = new Size(91, 32);
            checkCnpj.TabIndex = 106;
            checkCnpj.Text = "*CNPJ";
            checkCnpj.UseVisualStyleBackColor = true;
            checkCnpj.CheckedChanged += checkCnpj_CheckedChanged;
            // 
            // checkCpf
            // 
            checkCpf.AutoSize = true;
            checkCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkCpf.Location = new Point(1544, 343);
            checkCpf.Name = "checkCpf";
            checkCpf.Size = new Size(77, 32);
            checkCpf.TabIndex = 105;
            checkCpf.Text = "*CPF";
            checkCpf.UseVisualStyleBackColor = true;
            checkCpf.CheckedChanged += checkCpf_CheckedChanged;
            // 
            // mskTelefone2
            // 
            mskTelefone2.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskTelefone2.Location = new Point(1694, 562);
            mskTelefone2.Mask = "(00) 00000-0000";
            mskTelefone2.Name = "mskTelefone2";
            mskTelefone2.Size = new Size(159, 34);
            mskTelefone2.TabIndex = 104;
            mskTelefone2.Leave += mskTelefone2_Leave;
            // 
            // lblTelefone2
            // 
            lblTelefone2.AutoSize = true;
            lblTelefone2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone2.Location = new Point(1404, 566);
            lblTelefone2.Name = "lblTelefone2";
            lblTelefone2.Size = new Size(284, 28);
            lblTelefone2.TabIndex = 103;
            lblTelefone2.Text = "Telefone/Celular Secundário:";
            // 
            // lblMatriculaInicial
            // 
            lblMatriculaInicial.AutoSize = true;
            lblMatriculaInicial.ForeColor = SystemColors.ControlLightLight;
            lblMatriculaInicial.Location = new Point(1853, 1064);
            lblMatriculaInicial.Name = "lblMatriculaInicial";
            lblMatriculaInicial.Size = new Size(0, 20);
            lblMatriculaInicial.TabIndex = 102;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = SystemColors.ControlLightLight;
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(1908, 1050);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 101;
            // 
            // lblObrigatoriedade
            // 
            lblObrigatoriedade.AutoSize = true;
            lblObrigatoriedade.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblObrigatoriedade.ForeColor = SystemColors.ControlDark;
            lblObrigatoriedade.Location = new Point(60, 202);
            lblObrigatoriedade.Name = "lblObrigatoriedade";
            lblObrigatoriedade.Size = new Size(219, 24);
            lblObrigatoriedade.TabIndex = 100;
            lblObrigatoriedade.Text = "*Dados Obrigatórios";
            // 
            // lblInformaçõesFornecedor
            // 
            lblInformaçõesFornecedor.AutoSize = true;
            lblInformaçõesFornecedor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesFornecedor.Location = new Point(60, 238);
            lblInformaçõesFornecedor.Name = "lblInformaçõesFornecedor";
            lblInformaçõesFornecedor.Size = new Size(242, 37);
            lblInformaçõesFornecedor.TabIndex = 96;
            lblInformaçõesFornecedor.Text = "DADOS PESSOAIS";
            // 
            // lblInformaçõesEndereço
            // 
            lblInformaçõesEndereço.AutoSize = true;
            lblInformaçõesEndereço.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesEndereço.Location = new Point(60, 661);
            lblInformaçõesEndereço.Name = "lblInformaçõesEndereço";
            lblInformaçõesEndereço.Size = new Size(154, 37);
            lblInformaçõesEndereço.TabIndex = 94;
            lblInformaçõesEndereço.Text = "ENDEREÇO";
            // 
            // txtEstado
            // 
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtEstado.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(1209, 918);
            txtEstado.MaxLength = 2;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(43, 34);
            txtEstado.TabIndex = 93;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(1123, 920);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(80, 28);
            lblEstado.TabIndex = 92;
            lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.Location = new Point(1340, 920);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(81, 28);
            lblCidade.TabIndex = 91;
            lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(1427, 918);
            txtCidade.MaxLength = 30;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(433, 34);
            txtCidade.TabIndex = 90;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBairro.Location = new Point(531, 920);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(75, 28);
            lblBairro.TabIndex = 89;
            lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(612, 918);
            txtBairro.MaxLength = 30;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(440, 34);
            txtBairro.TabIndex = 88;
            // 
            // txtComplemento
            // 
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(215, 918);
            txtComplemento.MaxLength = 20;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(240, 34);
            txtComplemento.TabIndex = 87;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComplemento.Location = new Point(60, 920);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(149, 28);
            lblComplemento.TabIndex = 86;
            lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.Location = new Point(1633, 781);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(94, 28);
            lblNumero.TabIndex = 85;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(1733, 779);
            txtNumero.MaxLength = 10;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(127, 34);
            txtNumero.TabIndex = 84;
            // 
            // txtLogradouro
            // 
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(672, 779);
            txtLogradouro.MaxLength = 50;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(650, 34);
            txtLogradouro.TabIndex = 83;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(540, 781);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 82;
            label1.Text = "Logradouro:";
            // 
            // mskCep
            // 
            mskCep.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCep.Location = new Point(118, 779);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(107, 34);
            mskCep.TabIndex = 81;
            mskCep.Leave += mskCep_Leave;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCep.Location = new Point(60, 781);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(52, 28);
            lblCep.TabIndex = 80;
            lblCep.Text = "CEP:";
            // 
            // mskTelefone1
            // 
            mskTelefone1.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskTelefone1.Location = new Point(1079, 562);
            mskTelefone1.Mask = "(00) 00000-0000";
            mskTelefone1.Name = "mskTelefone1";
            mskTelefone1.Size = new Size(159, 34);
            mskTelefone1.TabIndex = 79;
            mskTelefone1.Leave += mskTelefone1_Leave;
            // 
            // lblTelefone1
            // 
            lblTelefone1.AutoSize = true;
            lblTelefone1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone1.Location = new Point(802, 566);
            lblTelefone1.Name = "lblTelefone1";
            lblTelefone1.Size = new Size(271, 28);
            lblTelefone1.TabIndex = 78;
            lblTelefone1.Text = "*Telefone/Celular Principal:";
            // 
            // mskCnpj
            // 
            mskCnpj.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCnpj.Location = new Point(1633, 386);
            mskCnpj.Mask = "00,000,000/0000-00";
            mskCnpj.Name = "mskCnpj";
            mskCnpj.ReadOnly = true;
            mskCnpj.Size = new Size(210, 34);
            mskCnpj.TabIndex = 77;
            mskCnpj.Leave += mskCnpj_Leave;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCnpj.Location = new Point(1704, 362);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(0, 28);
            lblCnpj.TabIndex = 76;
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(144, 562);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(500, 34);
            txtEmail.TabIndex = 75;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(60, 566);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 28);
            lblEmail.TabIndex = 74;
            lblEmail.Text = "*Email:";
            // 
            // checkClienteAtivo
            // 
            checkClienteAtivo.AutoSize = true;
            checkClienteAtivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkClienteAtivo.Location = new Point(1694, 243);
            checkClienteAtivo.Name = "checkClienteAtivo";
            checkClienteAtivo.Size = new Size(157, 32);
            checkClienteAtivo.TabIndex = 73;
            checkClienteAtivo.Text = "Cliente Ativo";
            checkClienteAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(590, 346);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(640, 34);
            txtNome.TabIndex = 72;
            txtNome.Tag = "";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(501, 349);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(83, 28);
            lblNome.TabIndex = 71;
            lblNome.Text = "*Nome:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(60, 349);
            lblId.Name = "lblId";
            lblId.Size = new Size(35, 28);
            lblId.TabIndex = 70;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(101, 346);
            txtId.MaxLength = 6;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(82, 34);
            txtId.TabIndex = 68;
            // 
            // lblRisco
            // 
            lblRisco.AutoSize = true;
            lblRisco.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco.Location = new Point(60, 681);
            lblRisco.Name = "lblRisco";
            lblRisco.Size = new Size(1805, 38);
            lblRisco.TabIndex = 95;
            lblRisco.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblRisco3
            // 
            lblRisco3.AutoSize = true;
            lblRisco3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco3.Location = new Point(60, 258);
            lblRisco3.Name = "lblRisco3";
            lblRisco3.Size = new Size(1805, 38);
            lblRisco3.TabIndex = 99;
            lblRisco3.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblInformaçõesContato
            // 
            lblInformaçõesContato.AutoSize = true;
            lblInformaçõesContato.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesContato.Location = new Point(55, 453);
            lblInformaçõesContato.Name = "lblInformaçõesContato";
            lblInformaçõesContato.Size = new Size(382, 37);
            lblInformaçõesContato.TabIndex = 97;
            lblInformaçõesContato.Text = "INFORMAÇÕES DE CONTATO";
            // 
            // lblRisco2
            // 
            lblRisco2.AutoSize = true;
            lblRisco2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco2.Location = new Point(55, 473);
            lblRisco2.Name = "lblRisco2";
            lblRisco2.Size = new Size(1805, 38);
            lblRisco2.TabIndex = 98;
            lblRisco2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttMinimizar);
            faixadaVerde.Controls.Add(lblCadastrarCliente);
            faixadaVerde.Controls.Add(picIcone);
            faixadaVerde.Controls.Add(bttCancelar);
            faixadaVerde.Controls.Add(bttConfirmar);
            faixadaVerde.Controls.Add(panel2);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Controls.Add(panel4);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(1920, 199);
            faixadaVerde.TabIndex = 69;
            // 
            // bttMinimizar
            // 
            bttMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttMinimizar.Image = Properties.Resources.output_onlinepngtools__17_;
            bttMinimizar.Location = new Point(1888, 12);
            bttMinimizar.Name = "bttMinimizar";
            bttMinimizar.Size = new Size(20, 20);
            bttMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            bttMinimizar.TabIndex = 26;
            bttMinimizar.TabStop = false;
            bttMinimizar.Click += bttMinimizar_Click;
            bttMinimizar.MouseLeave += MouseLeave;
            bttMinimizar.MouseHover += MouseHover;
            // 
            // lblCadastrarCliente
            // 
            lblCadastrarCliente.AutoSize = true;
            lblCadastrarCliente.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastrarCliente.ForeColor = SystemColors.ControlLightLight;
            lblCadastrarCliente.Location = new Point(221, 134);
            lblCadastrarCliente.Name = "lblCadastrarCliente";
            lblCadastrarCliente.Size = new Size(251, 46);
            lblCadastrarCliente.TabIndex = 24;
            lblCadastrarCliente.Text = "Alterar Cliente";
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.alterar_pessoa_branco;
            picIcone.Location = new Point(55, 61);
            picIcone.Name = "picIcone";
            picIcone.Size = new Size(155, 139);
            picIcone.SizeMode = PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 23;
            picIcone.TabStop = false;
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttCancelar.Location = new Point(1633, 134);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(120, 46);
            bttCancelar.TabIndex = 21;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            bttCancelar.Click += bttCancelar_Click;
            bttCancelar.MouseLeave += MouseLeave;
            bttCancelar.MouseHover += MouseHover;
            // 
            // bttConfirmar
            // 
            bttConfirmar.BackColor = Color.FromArgb(72, 44, 30);
            bttConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttConfirmar.ForeColor = SystemColors.ControlLightLight;
            bttConfirmar.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttConfirmar.Location = new Point(1779, 134);
            bttConfirmar.Name = "bttConfirmar";
            bttConfirmar.Size = new Size(120, 47);
            bttConfirmar.TabIndex = 22;
            bttConfirmar.Text = "Confirmar";
            bttConfirmar.UseVisualStyleBackColor = false;
            bttConfirmar.Click += bttConfirmar_Click;
            bttConfirmar.MouseLeave += MouseLeave;
            bttConfirmar.MouseHover += MouseHover;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Location = new Point(6929, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(128, 40);
            panel2.TabIndex = 6;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(7711, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.AutoScroll = true;
            panel4.Location = new Point(5229, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(128, 40);
            panel4.TabIndex = 17;
            // 
            // AtualizarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1920, 1080);
            Controls.Add(mskCpf);
            Controls.Add(checkCnpj);
            Controls.Add(checkCpf);
            Controls.Add(mskTelefone2);
            Controls.Add(lblTelefone2);
            Controls.Add(lblMatriculaInicial);
            Controls.Add(lblUsuario);
            Controls.Add(lblObrigatoriedade);
            Controls.Add(lblInformaçõesFornecedor);
            Controls.Add(lblInformaçõesEndereço);
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
            Controls.Add(mskTelefone1);
            Controls.Add(lblTelefone1);
            Controls.Add(mskCnpj);
            Controls.Add(lblCnpj);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(checkClienteAtivo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblRisco);
            Controls.Add(lblRisco3);
            Controls.Add(lblInformaçõesContato);
            Controls.Add(lblRisco2);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AtualizarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarFuncionario";
            WindowState = FormWindowState.Maximized;
            Load += AlterarCliente_Load;
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCodCargo;
        private TextBox txtCodCargo;
        private TextBox txtDescCargo;
        private Label lblDescCargo;
        private Label lblSalario;
        private PictureBox picBuscaCargo;
        private TextBox txtSalario;
        private MaskedTextBox mskCpf;
        private CheckBox checkCnpj;
        private CheckBox checkCpf;
        private MaskedTextBox mskTelefone2;
        private Label lblTelefone2;
        private Label lblMatriculaInicial;
        private Label lblUsuario;
        private Label lblObrigatoriedade;
        private Label lblInformaçõesFornecedor;
        private Label lblInformaçõesEndereço;
        private TextBox txtEstado;
        private Label lblEstado;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblBairro;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private Label label1;
        private MaskedTextBox mskCep;
        private Label lblCep;
        private MaskedTextBox mskTelefone1;
        private Label lblTelefone1;
        private MaskedTextBox mskCnpj;
        private Label lblCnpj;
        private TextBox txtEmail;
        private Label lblEmail;
        private CheckBox checkClienteAtivo;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblId;
        private TextBox txtId;
        private Label lblRisco;
        private Label lblRisco3;
        private Label lblInformaçõesContato;
        private Label lblRisco2;
        private Panel faixadaVerde;
        private Label lblCadastrarCliente;
        private PictureBox picIcone;
        private Button bttCancelar;
        private Button bttConfirmar;
        private Panel panel2;
        private Panel panelicones;
        private Panel panel4;
        private PictureBox bttMinimizar;
    }
}