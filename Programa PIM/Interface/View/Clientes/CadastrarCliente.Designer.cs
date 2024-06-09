namespace Interface.View.Clientes
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            txtId = new TextBox();
            picIcone = new PictureBox();
            faixadaVerde = new Panel();
            bttCancelar = new Button();
            bttConfirmar = new Button();
            panel3 = new Panel();
            bttMinimizar = new PictureBox();
            lblCadastrarCliente = new Label();
            panel1 = new Panel();
            panelicones = new Panel();
            panel2 = new Panel();
            lblId = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            checkClienteAtivo = new CheckBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCnpj = new Label();
            mskCnpj = new MaskedTextBox();
            lblTelefone1 = new Label();
            mskTelefone1 = new MaskedTextBox();
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
            lblInformaçõesEndereço = new Label();
            lblRisco = new Label();
            lblInformaçõesContato = new Label();
            lblRisco2 = new Label();
            lblInformaçõesFornecedor = new Label();
            lblRisco3 = new Label();
            lblObrigatoriedade = new Label();
            lblUsuario = new Label();
            lblMatriculaInicial = new Label();
            mskTelefone2 = new MaskedTextBox();
            lblTelefone2 = new Label();
            checkCpf = new CheckBox();
            checkCnpj = new CheckBox();
            mskCpf = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            faixadaVerde.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(101, 347);
            txtId.MaxLength = 6;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(82, 34);
            txtId.TabIndex = 0;
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.adicionar_pessoa_branco;
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
            faixadaVerde.Controls.Add(lblCadastrarCliente);
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.Controls.Add(bttMinimizar);
            panel3.Location = new Point(1789, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 40);
            panel3.TabIndex = 19;
            // 
            // bttMinimizar
            // 
            bttMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttMinimizar.Image = Properties.Resources.output_onlinepngtools__17_;
            bttMinimizar.Location = new Point(99, 12);
            bttMinimizar.Name = "bttMinimizar";
            bttMinimizar.Size = new Size(20, 20);
            bttMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            bttMinimizar.TabIndex = 3;
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
            lblCadastrarCliente.Location = new Point(208, 134);
            lblCadastrarCliente.Name = "lblCadastrarCliente";
            lblCadastrarCliente.Size = new Size(281, 46);
            lblCadastrarCliente.TabIndex = 18;
            lblCadastrarCliente.Text = "Cadastro Cliente";
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
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(60, 350);
            lblId.Name = "lblId";
            lblId.Size = new Size(35, 28);
            lblId.TabIndex = 21;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(501, 350);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(83, 28);
            lblNome.TabIndex = 22;
            lblNome.Text = "*Nome:";
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(590, 347);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(640, 34);
            txtNome.TabIndex = 23;
            txtNome.Tag = "";
            // 
            // checkClienteAtivo
            // 
            checkClienteAtivo.AutoSize = true;
            checkClienteAtivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkClienteAtivo.Location = new Point(1694, 244);
            checkClienteAtivo.Name = "checkClienteAtivo";
            checkClienteAtivo.Size = new Size(157, 32);
            checkClienteAtivo.TabIndex = 25;
            checkClienteAtivo.Text = "Cliente Ativo";
            checkClienteAtivo.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(60, 567);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 28);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "*Email:";
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(144, 563);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(500, 34);
            txtEmail.TabIndex = 29;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCnpj.Location = new Point(1704, 363);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(0, 28);
            lblCnpj.TabIndex = 30;
            // 
            // mskCnpj
            // 
            mskCnpj.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCnpj.Location = new Point(1633, 387);
            mskCnpj.Mask = "00,000,000/0000-00";
            mskCnpj.Name = "mskCnpj";
            mskCnpj.ReadOnly = true;
            mskCnpj.Size = new Size(210, 34);
            mskCnpj.TabIndex = 31;
            mskCnpj.Leave += mskCnpj_Leave;
            // 
            // lblTelefone1
            // 
            lblTelefone1.AutoSize = true;
            lblTelefone1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone1.Location = new Point(802, 567);
            lblTelefone1.Name = "lblTelefone1";
            lblTelefone1.Size = new Size(271, 28);
            lblTelefone1.TabIndex = 32;
            lblTelefone1.Text = "*Telefone/Celular Principal:";
            // 
            // mskTelefone1
            // 
            mskTelefone1.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskTelefone1.Location = new Point(1079, 563);
            mskTelefone1.Mask = "(00) 00000-0000";
            mskTelefone1.Name = "mskTelefone1";
            mskTelefone1.Size = new Size(159, 34);
            mskTelefone1.TabIndex = 33;
            mskTelefone1.Leave += mskTelefone1_Leave;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCep.Location = new Point(60, 782);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(52, 28);
            lblCep.TabIndex = 40;
            lblCep.Text = "CEP:";
            // 
            // mskCep
            // 
            mskCep.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCep.Location = new Point(118, 780);
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
            label1.Location = new Point(540, 782);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 42;
            label1.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(672, 780);
            txtLogradouro.MaxLength = 50;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(650, 34);
            txtLogradouro.TabIndex = 43;
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(1733, 780);
            txtNumero.MaxLength = 10;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(127, 34);
            txtNumero.TabIndex = 44;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.Location = new Point(1633, 782);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(94, 28);
            lblNumero.TabIndex = 45;
            lblNumero.Text = "Número:";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblComplemento.Location = new Point(60, 921);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(149, 28);
            lblComplemento.TabIndex = 46;
            lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(215, 919);
            txtComplemento.MaxLength = 20;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(240, 34);
            txtComplemento.TabIndex = 47;
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(612, 919);
            txtBairro.MaxLength = 30;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(440, 34);
            txtBairro.TabIndex = 48;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBairro.Location = new Point(531, 921);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(75, 28);
            lblBairro.TabIndex = 49;
            lblBairro.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(1427, 919);
            txtCidade.MaxLength = 30;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(433, 34);
            txtCidade.TabIndex = 50;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.Location = new Point(1340, 921);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(81, 28);
            lblCidade.TabIndex = 51;
            lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(1123, 921);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(80, 28);
            lblEstado.TabIndex = 52;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.CharacterCasing = CharacterCasing.Upper;
            txtEstado.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(1209, 919);
            txtEstado.MaxLength = 2;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(43, 34);
            txtEstado.TabIndex = 53;
            // 
            // lblInformaçõesEndereço
            // 
            lblInformaçõesEndereço.AutoSize = true;
            lblInformaçõesEndereço.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesEndereço.Location = new Point(60, 662);
            lblInformaçõesEndereço.Name = "lblInformaçõesEndereço";
            lblInformaçõesEndereço.Size = new Size(154, 37);
            lblInformaçõesEndereço.TabIndex = 56;
            lblInformaçõesEndereço.Text = "ENDEREÇO";
            // 
            // lblRisco
            // 
            lblRisco.AutoSize = true;
            lblRisco.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco.Location = new Point(60, 682);
            lblRisco.Name = "lblRisco";
            lblRisco.Size = new Size(1805, 38);
            lblRisco.TabIndex = 57;
            lblRisco.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblInformaçõesContato
            // 
            lblInformaçõesContato.AutoSize = true;
            lblInformaçõesContato.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesContato.Location = new Point(55, 454);
            lblInformaçõesContato.Name = "lblInformaçõesContato";
            lblInformaçõesContato.Size = new Size(382, 37);
            lblInformaçõesContato.TabIndex = 58;
            lblInformaçõesContato.Text = "INFORMAÇÕES DE CONTATO";
            // 
            // lblRisco2
            // 
            lblRisco2.AutoSize = true;
            lblRisco2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco2.Location = new Point(55, 474);
            lblRisco2.Name = "lblRisco2";
            lblRisco2.Size = new Size(1805, 38);
            lblRisco2.TabIndex = 59;
            lblRisco2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblInformaçõesFornecedor
            // 
            lblInformaçõesFornecedor.AutoSize = true;
            lblInformaçõesFornecedor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesFornecedor.Location = new Point(60, 239);
            lblInformaçõesFornecedor.Name = "lblInformaçõesFornecedor";
            lblInformaçõesFornecedor.Size = new Size(242, 37);
            lblInformaçõesFornecedor.TabIndex = 58;
            lblInformaçõesFornecedor.Text = "DADOS PESSOAIS";
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
            // mskTelefone2
            // 
            mskTelefone2.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskTelefone2.Location = new Point(1694, 563);
            mskTelefone2.Mask = "(00) 00000-0000";
            mskTelefone2.Name = "mskTelefone2";
            mskTelefone2.Size = new Size(159, 34);
            mskTelefone2.TabIndex = 64;
            mskTelefone2.Leave += mskTelefone2_Leave;
            // 
            // lblTelefone2
            // 
            lblTelefone2.AutoSize = true;
            lblTelefone2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone2.Location = new Point(1404, 567);
            lblTelefone2.Name = "lblTelefone2";
            lblTelefone2.Size = new Size(284, 28);
            lblTelefone2.TabIndex = 63;
            lblTelefone2.Text = "Telefone/Celular Secundário:";
            // 
            // checkCpf
            // 
            checkCpf.AutoSize = true;
            checkCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkCpf.Location = new Point(1544, 344);
            checkCpf.Name = "checkCpf";
            checkCpf.Size = new Size(77, 32);
            checkCpf.TabIndex = 65;
            checkCpf.Text = "*CPF";
            checkCpf.UseVisualStyleBackColor = true;
            checkCpf.CheckedChanged += checkCpf_CheckedChanged;
            // 
            // checkCnpj
            // 
            checkCnpj.AutoSize = true;
            checkCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkCnpj.Location = new Point(1544, 389);
            checkCnpj.Name = "checkCnpj";
            checkCnpj.Size = new Size(91, 32);
            checkCnpj.TabIndex = 66;
            checkCnpj.Text = "*CNPJ";
            checkCnpj.UseVisualStyleBackColor = true;
            checkCnpj.CheckedChanged += checkCnpj_CheckedChanged;
            // 
            // mskCpf
            // 
            mskCpf.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskCpf.Location = new Point(1633, 344);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.ReadOnly = true;
            mskCpf.Size = new Size(210, 34);
            mskCpf.TabIndex = 67;
            mskCpf.Leave += mskCpf_Leave;
            // 
            // CadastrarCliente
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
            Name = "CadastrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarFuncionario";
            WindowState = FormWindowState.Maximized;
            Load += CadastrarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private PictureBox picIcone;
        private Panel faixadaVerde;
        private Label lblCadastrarCliente;
        private Panel panel1;
        private Panel panelicones;
        private Panel panel2;
        private Panel panel3;
        private PictureBox bttMinimizar;
        private Label lblId;
        private Label lblNome;
        private TextBox txtNome;
        private CheckBox checkClienteAtivo;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCnpj;
        private MaskedTextBox mskCnpj;
        private Label lblTelefone1;
        private MaskedTextBox mskTelefone1;
        private Label lblCodCargo;
        private TextBox txtCodCargo;
        private TextBox txtDescCargo;
        private Label lblDescCargo;
        private Label lblSalario;
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
        private Label lblInformaçõesContato;
        private Label lblRisco2;
        private Label lblInformaçõesFornecedor;
        private Label lblRisco3;
        private Label lblObrigatoriedade;
        private Label lblUsuario;
        private Label lblMatriculaInicial;
        private MaskedTextBox mskTelefone2;
        private Label lblTelefone2;
        private CheckBox checkCpf;
        private CheckBox checkCnpj;
        private MaskedTextBox mskCpf;
        private Button bttCancelar;
        private Button bttConfirmar;
    }
}