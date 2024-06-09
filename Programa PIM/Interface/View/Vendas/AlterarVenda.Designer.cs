namespace Interface.View.Vendas
{
    partial class AlterarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarVenda));
            txtIdVenda = new TextBox();
            picIcone = new PictureBox();
            faixadaVerde = new Panel();
            bttCancelar = new Button();
            bttConfirmar = new Button();
            panel3 = new Panel();
            bttMinimizar = new PictureBox();
            lblAlterarProduto = new Label();
            panel1 = new Panel();
            panelicones = new Panel();
            panel2 = new Panel();
            lblIdProduto = new Label();
            lblDescProduto = new Label();
            lblInformaçõesFornecedor = new Label();
            lblRisco3 = new Label();
            lblObrigatoriedade = new Label();
            lblUsuario = new Label();
            lblMatriculaInicial = new Label();
            lblDescSubcategoria = new Label();
            txtNomeCliente = new TextBox();
            txtCodCliente = new TextBox();
            lblCodSubcategoria = new Label();
            picBuscaCliente = new PictureBox();
            lblEstoque = new Label();
            label2 = new Label();
            mskDtVenda = new MaskedTextBox();
            lblCodProduto = new Label();
            txtCodProduto = new TextBox();
            picBuscaProduto = new PictureBox();
            txtProduto = new TextBox();
            label1 = new Label();
            bttAdicionarProduto = new Button();
            dataGridProdutos = new DataGridView();
            lblQntd = new Label();
            txtQntdProduto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtValorTotal = new TextBox();
            label7 = new Label();
            label8 = new Label();
            checkA_Vista = new CheckBox();
            checkParcelado = new CheckBox();
            txtQntdParcelas = new TextBox();
            lblQntdParcelas = new Label();
            label6 = new Label();
            txtValorParcela = new TextBox();
            txtQntdEstoque = new TextBox();
            label9 = new Label();
            checkCrédito = new CheckBox();
            checkPix = new CheckBox();
            checkBoleto = new CheckBox();
            checkDebito = new CheckBox();
            bttRetirarItem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            faixadaVerde.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtIdVenda
            // 
            txtIdVenda.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdVenda.Location = new Point(101, 322);
            txtIdVenda.MaxLength = 6;
            txtIdVenda.Name = "txtIdVenda";
            txtIdVenda.ReadOnly = true;
            txtIdVenda.Size = new Size(82, 34);
            txtIdVenda.TabIndex = 41;
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.alterar_vendas_branco;
            picIcone.Location = new Point(42, 61);
            picIcone.Name = "picIcone";
            picIcone.Size = new Size(155, 139);
            picIcone.SizeMode = PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 4;
            picIcone.TabStop = false;
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttCancelar);
            faixadaVerde.Controls.Add(bttConfirmar);
            faixadaVerde.Controls.Add(panel3);
            faixadaVerde.Controls.Add(lblAlterarProduto);
            faixadaVerde.Controls.Add(picIcone);
            faixadaVerde.Controls.Add(panel1);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Controls.Add(panel2);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(1920, 200);
            faixadaVerde.TabIndex = 43;
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttCancelar.Location = new Point(1633, 134);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(120, 46);
            bttCancelar.TabIndex = 0;
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
            bttConfirmar.TabIndex = 1;
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
            panel3.TabIndex = 2;
            // 
            // bttMinimizar
            // 
            bttMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttMinimizar.Image = Properties.Resources.output_onlinepngtools__17_;
            bttMinimizar.Location = new Point(99, 12);
            bttMinimizar.Name = "bttMinimizar";
            bttMinimizar.Size = new Size(20, 20);
            bttMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            bttMinimizar.TabIndex = 1;
            bttMinimizar.TabStop = false;
            bttMinimizar.Click += bttMinimizar_Click;
            bttMinimizar.MouseLeave += MouseLeave;
            bttMinimizar.MouseHover += MouseHover;
            // 
            // lblAlterarProduto
            // 
            lblAlterarProduto.AutoSize = true;
            lblAlterarProduto.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlterarProduto.ForeColor = SystemColors.ControlLightLight;
            lblAlterarProduto.Location = new Point(208, 134);
            lblAlterarProduto.Name = "lblAlterarProduto";
            lblAlterarProduto.Size = new Size(239, 46);
            lblAlterarProduto.TabIndex = 3;
            lblAlterarProduto.Text = "Alterar Venda";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(5209, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 40);
            panel1.TabIndex = 5;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(5991, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Location = new Point(3509, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(128, 40);
            panel2.TabIndex = 7;
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProduto.Location = new Point(60, 325);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(35, 28);
            lblIdProduto.TabIndex = 40;
            lblIdProduto.Text = "Id:";
            // 
            // lblDescProduto
            // 
            lblDescProduto.AutoSize = true;
            lblDescProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescProduto.Location = new Point(410, 325);
            lblDescProduto.Name = "lblDescProduto";
            lblDescProduto.Size = new Size(164, 28);
            lblDescProduto.TabIndex = 39;
            lblDescProduto.Text = "*Data da Venda:";
            // 
            // lblInformaçõesFornecedor
            // 
            lblInformaçõesFornecedor.AutoSize = true;
            lblInformaçõesFornecedor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesFornecedor.Location = new Point(60, 239);
            lblInformaçõesFornecedor.Name = "lblInformaçõesFornecedor";
            lblInformaçõesFornecedor.Size = new Size(311, 37);
            lblInformaçõesFornecedor.TabIndex = 38;
            lblInformaçõesFornecedor.Text = "INFORMAÇÕES GERAIS";
            // 
            // lblRisco3
            // 
            lblRisco3.AutoSize = true;
            lblRisco3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco3.Location = new Point(60, 259);
            lblRisco3.Name = "lblRisco3";
            lblRisco3.Size = new Size(1805, 38);
            lblRisco3.TabIndex = 42;
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
            lblObrigatoriedade.TabIndex = 37;
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
            lblUsuario.TabIndex = 36;
            // 
            // lblMatriculaInicial
            // 
            lblMatriculaInicial.AutoSize = true;
            lblMatriculaInicial.ForeColor = SystemColors.ControlLightLight;
            lblMatriculaInicial.Location = new Point(1853, 1065);
            lblMatriculaInicial.Name = "lblMatriculaInicial";
            lblMatriculaInicial.Size = new Size(0, 20);
            lblMatriculaInicial.TabIndex = 35;
            // 
            // lblDescSubcategoria
            // 
            lblDescSubcategoria.AutoSize = true;
            lblDescSubcategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescSubcategoria.Location = new Point(1319, 325);
            lblDescSubcategoria.Name = "lblDescSubcategoria";
            lblDescSubcategoria.Size = new Size(146, 28);
            lblDescSubcategoria.TabIndex = 30;
            lblDescSubcategoria.Text = "Nome Cliente:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.CharacterCasing = CharacterCasing.Upper;
            txtNomeCliente.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.Location = new Point(1471, 322);
            txtNomeCliente.MaxLength = 35;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.ReadOnly = true;
            txtNomeCliente.Size = new Size(381, 34);
            txtNomeCliente.TabIndex = 31;
            // 
            // txtCodCliente
            // 
            txtCodCliente.CharacterCasing = CharacterCasing.Upper;
            txtCodCliente.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodCliente.Location = new Point(1060, 323);
            txtCodCliente.MaxLength = 6;
            txtCodCliente.Name = "txtCodCliente";
            txtCodCliente.Size = new Size(81, 34);
            txtCodCliente.TabIndex = 32;
            txtCodCliente.TextChanged += txtCodCliente_TextChanged;
            txtCodCliente.Leave += txtCodCliente_Leave;
            // 
            // lblCodSubcategoria
            // 
            lblCodSubcategoria.AutoSize = true;
            lblCodSubcategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodSubcategoria.Location = new Point(919, 325);
            lblCodSubcategoria.Name = "lblCodSubcategoria";
            lblCodSubcategoria.Size = new Size(139, 28);
            lblCodSubcategoria.TabIndex = 33;
            lblCodSubcategoria.Text = "*Cód. Cliente:";
            // 
            // picBuscaCliente
            // 
            picBuscaCliente.Image = Properties.Resources.search_3917132;
            picBuscaCliente.Location = new Point(1148, 330);
            picBuscaCliente.Name = "picBuscaCliente";
            picBuscaCliente.Size = new Size(20, 25);
            picBuscaCliente.SizeMode = PictureBoxSizeMode.Zoom;
            picBuscaCliente.TabIndex = 34;
            picBuscaCliente.TabStop = false;
            picBuscaCliente.Click += picBuscaCliente_Click;
            picBuscaCliente.MouseLeave += MouseLeave;
            picBuscaCliente.MouseHover += MouseHover;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstoque.Location = new Point(54, 408);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(162, 37);
            lblEstoque.TabIndex = 28;
            lblEstoque.Text = "PRODUTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 428);
            label2.Name = "label2";
            label2.Size = new Size(1805, 38);
            label2.TabIndex = 29;
            label2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // mskDtVenda
            // 
            mskDtVenda.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskDtVenda.Location = new Point(580, 322);
            mskDtVenda.Mask = "00/00/0000";
            mskDtVenda.Name = "mskDtVenda";
            mskDtVenda.Size = new Size(125, 34);
            mskDtVenda.TabIndex = 27;
            mskDtVenda.Leave += mskDtVenda_Leave;
            // 
            // lblCodProduto
            // 
            lblCodProduto.AutoSize = true;
            lblCodProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodProduto.Location = new Point(60, 508);
            lblCodProduto.Name = "lblCodProduto";
            lblCodProduto.Size = new Size(140, 28);
            lblCodProduto.TabIndex = 26;
            lblCodProduto.Text = "Cód. Produto:";
            // 
            // txtCodProduto
            // 
            txtCodProduto.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodProduto.Location = new Point(205, 505);
            txtCodProduto.MaxLength = 6;
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(81, 34);
            txtCodProduto.TabIndex = 25;
            txtCodProduto.TextChanged += txtCodProduto_TextChanged;
            txtCodProduto.Leave += txtCodProduto_Leave;
            // 
            // picBuscaProduto
            // 
            picBuscaProduto.Image = Properties.Resources.search_3917132;
            picBuscaProduto.Location = new Point(292, 511);
            picBuscaProduto.Name = "picBuscaProduto";
            picBuscaProduto.Size = new Size(20, 25);
            picBuscaProduto.SizeMode = PictureBoxSizeMode.Zoom;
            picBuscaProduto.TabIndex = 24;
            picBuscaProduto.TabStop = false;
            picBuscaProduto.Click += picBuscaProduto_Click;
            picBuscaProduto.MouseLeave += MouseLeave;
            picBuscaProduto.MouseHover += MouseHover;
            // 
            // txtProduto
            // 
            txtProduto.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProduto.Location = new Point(493, 505);
            txtProduto.Name = "txtProduto";
            txtProduto.ReadOnly = true;
            txtProduto.Size = new Size(381, 34);
            txtProduto.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(394, 508);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 22;
            label1.Text = "Produto:";
            // 
            // bttAdicionarProduto
            // 
            bttAdicionarProduto.BackColor = Color.FromArgb(72, 44, 30);
            bttAdicionarProduto.ForeColor = Color.Cornsilk;
            bttAdicionarProduto.Image = Properties.Resources.sinal_mais_branco_resized__2_;
            bttAdicionarProduto.Location = new Point(1683, 504);
            bttAdicionarProduto.Name = "bttAdicionarProduto";
            bttAdicionarProduto.Size = new Size(40, 40);
            bttAdicionarProduto.TabIndex = 21;
            bttAdicionarProduto.UseVisualStyleBackColor = false;
            bttAdicionarProduto.Click += bttAdicionarProduto_Click;
            bttAdicionarProduto.MouseLeave += MouseLeave;
            bttAdicionarProduto.MouseHover += MouseHover;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(60, 575);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.RowHeadersWidth = 51;
            dataGridProdutos.RowTemplate.Height = 29;
            dataGridProdutos.Size = new Size(1663, 188);
            dataGridProdutos.TabIndex = 20;
            // 
            // lblQntd
            // 
            lblQntd.AutoSize = true;
            lblQntd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQntd.Location = new Point(1330, 508);
            lblQntd.Name = "lblQntd";
            lblQntd.Size = new Size(136, 28);
            lblQntd.TabIndex = 19;
            lblQntd.Text = "*Quantidade:";
            // 
            // txtQntdProduto
            // 
            txtQntdProduto.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntdProduto.Location = new Point(1472, 505);
            txtQntdProduto.MaxLength = 4;
            txtQntdProduto.Name = "txtQntdProduto";
            txtQntdProduto.Size = new Size(125, 34);
            txtQntdProduto.TabIndex = 18;
            txtQntdProduto.Leave += txtQntdProduto_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 808);
            label3.Name = "label3";
            label3.Size = new Size(185, 37);
            label3.TabIndex = 16;
            label3.Text = "PAGAMENTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 828);
            label4.Name = "label4";
            label4.Size = new Size(1805, 38);
            label4.TabIndex = 17;
            label4.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(921, 911);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 15;
            label5.Text = "Valor total:";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(1043, 908);
            txtValorTotal.MaxLength = 10;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(125, 34);
            txtValorTotal.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(55, 887);
            label7.Name = "label7";
            label7.Size = new Size(218, 28);
            label7.TabIndex = 13;
            label7.Text = "Forma de Pagamento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(370, 887);
            label8.Name = "label8";
            label8.Size = new Size(214, 28);
            label8.TabIndex = 12;
            label8.Text = "Modo de Pagamento:";
            // 
            // checkA_Vista
            // 
            checkA_Vista.AutoSize = true;
            checkA_Vista.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkA_Vista.Location = new Point(377, 927);
            checkA_Vista.Name = "checkA_Vista";
            checkA_Vista.Size = new Size(86, 28);
            checkA_Vista.TabIndex = 11;
            checkA_Vista.Text = "À vista";
            checkA_Vista.UseVisualStyleBackColor = true;
            checkA_Vista.CheckedChanged += checkA_Vista_CheckedChanged;
            // 
            // checkParcelado
            // 
            checkParcelado.AutoSize = true;
            checkParcelado.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkParcelado.Location = new Point(377, 951);
            checkParcelado.Name = "checkParcelado";
            checkParcelado.Size = new Size(114, 28);
            checkParcelado.TabIndex = 10;
            checkParcelado.Text = "Parcelado";
            checkParcelado.UseVisualStyleBackColor = true;
            checkParcelado.CheckedChanged += checkParcelado_CheckedChanged;
            // 
            // txtQntdParcelas
            // 
            txtQntdParcelas.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntdParcelas.Location = new Point(882, 974);
            txtQntdParcelas.Name = "txtQntdParcelas";
            txtQntdParcelas.ReadOnly = true;
            txtQntdParcelas.Size = new Size(125, 34);
            txtQntdParcelas.TabIndex = 9;
            txtQntdParcelas.TextChanged += txtQntdParcelas_TextChanged;
            txtQntdParcelas.Leave += txtQntdParcelas_Leave;
            // 
            // lblQntdParcelas
            // 
            lblQntdParcelas.AutoSize = true;
            lblQntdParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQntdParcelas.Location = new Point(715, 977);
            lblQntdParcelas.Name = "lblQntdParcelas";
            lblQntdParcelas.Size = new Size(153, 28);
            lblQntdParcelas.TabIndex = 8;
            lblQntdParcelas.Text = "Qntd. Parcelas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1071, 977);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 7;
            label6.Text = "Valor Parcela:";
            // 
            // txtValorParcela
            // 
            txtValorParcela.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorParcela.Location = new Point(1217, 974);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.ReadOnly = true;
            txtValorParcela.Size = new Size(125, 34);
            txtValorParcela.TabIndex = 6;
            // 
            // txtQntdEstoque
            // 
            txtQntdEstoque.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntdEstoque.Location = new Point(1101, 505);
            txtQntdEstoque.MaxLength = 4;
            txtQntdEstoque.Name = "txtQntdEstoque";
            txtQntdEstoque.ReadOnly = true;
            txtQntdEstoque.Size = new Size(125, 34);
            txtQntdEstoque.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(945, 508);
            label9.Name = "label9";
            label9.Size = new Size(150, 28);
            label9.TabIndex = 5;
            label9.Text = "Qntd. Estoque:";
            // 
            // checkCrédito
            // 
            checkCrédito.AutoSize = true;
            checkCrédito.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkCrédito.Location = new Point(63, 927);
            checkCrédito.Name = "checkCrédito";
            checkCrédito.Size = new Size(178, 28);
            checkCrédito.TabIndex = 3;
            checkCrédito.Text = "Cartão de Crédito";
            checkCrédito.UseVisualStyleBackColor = true;
            checkCrédito.CheckedChanged += checkCredito_CheckedChanged;
            // 
            // checkPix
            // 
            checkPix.AutoSize = true;
            checkPix.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkPix.Location = new Point(63, 974);
            checkPix.Name = "checkPix";
            checkPix.Size = new Size(55, 28);
            checkPix.TabIndex = 2;
            checkPix.Text = "Pix";
            checkPix.UseVisualStyleBackColor = true;
            checkPix.CheckedChanged += checkPix_CheckedChanged;
            // 
            // checkBoleto
            // 
            checkBoleto.AutoSize = true;
            checkBoleto.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoleto.Location = new Point(63, 996);
            checkBoleto.Name = "checkBoleto";
            checkBoleto.Size = new Size(85, 28);
            checkBoleto.TabIndex = 1;
            checkBoleto.Text = "Boleto";
            checkBoleto.UseVisualStyleBackColor = true;
            checkBoleto.CheckedChanged += checkBoleto_CheckedChanged;
            // 
            // checkDebito
            // 
            checkDebito.AutoSize = true;
            checkDebito.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkDebito.Location = new Point(63, 951);
            checkDebito.Name = "checkDebito";
            checkDebito.Size = new Size(173, 28);
            checkDebito.TabIndex = 0;
            checkDebito.Text = "Cartão de Débito";
            checkDebito.UseVisualStyleBackColor = true;
            checkDebito.CheckedChanged += checkDebito_CheckedChanged;
            // 
            // bttRetirarItem
            // 
            bttRetirarItem.BackColor = Color.FromArgb(72, 44, 30);
            bttRetirarItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttRetirarItem.ForeColor = SystemColors.ControlLightLight;
            bttRetirarItem.Location = new Point(1742, 643);
            bttRetirarItem.Name = "bttRetirarItem";
            bttRetirarItem.Size = new Size(110, 54);
            bttRetirarItem.TabIndex = 44;
            bttRetirarItem.Text = "Remover item";
            bttRetirarItem.UseVisualStyleBackColor = false;
            bttRetirarItem.Click += bttRetirarItem_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1609, 769);
            button1.Name = "button1";
            button1.Size = new Size(114, 38);
            button1.TabIndex = 47;
            button1.Text = "Limpar itens";
            button1.UseVisualStyleBackColor = false;
            button1.Click += bttRemoverTodosItens_Click;
            // 
            // AlterarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button1);
            Controls.Add(bttRetirarItem);
            Controls.Add(checkDebito);
            Controls.Add(checkBoleto);
            Controls.Add(checkPix);
            Controls.Add(checkCrédito);
            Controls.Add(txtQntdEstoque);
            Controls.Add(label9);
            Controls.Add(txtValorParcela);
            Controls.Add(label6);
            Controls.Add(lblQntdParcelas);
            Controls.Add(txtQntdParcelas);
            Controls.Add(checkParcelado);
            Controls.Add(checkA_Vista);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtValorTotal);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtQntdProduto);
            Controls.Add(lblQntd);
            Controls.Add(dataGridProdutos);
            Controls.Add(bttAdicionarProduto);
            Controls.Add(label1);
            Controls.Add(txtProduto);
            Controls.Add(picBuscaProduto);
            Controls.Add(txtCodProduto);
            Controls.Add(lblCodProduto);
            Controls.Add(mskDtVenda);
            Controls.Add(lblEstoque);
            Controls.Add(label2);
            Controls.Add(lblDescSubcategoria);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtCodCliente);
            Controls.Add(lblCodSubcategoria);
            Controls.Add(picBuscaCliente);
            Controls.Add(lblMatriculaInicial);
            Controls.Add(lblUsuario);
            Controls.Add(lblObrigatoriedade);
            Controls.Add(lblInformaçõesFornecedor);
            Controls.Add(lblDescProduto);
            Controls.Add(lblIdProduto);
            Controls.Add(txtIdVenda);
            Controls.Add(lblRisco3);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AlterarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarFuncionario";
            WindowState = FormWindowState.Maximized;
            FormClosed += _FormClosed;
            Load += CadastrarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdVenda;
        private PictureBox picIcone;
        private Panel faixadaVerde;
        private Label lblAlterarProduto;
        private Panel panel1;
        private Panel panelicones;
        private Panel panel2;
        private Panel panel3;
        private PictureBox bttMinimizar;
        private Label lblIdProduto;
        private Label lblDescProduto;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefone1;
        private MaskedTextBox mskTelefone1;
        private Label lblCodCargo;
        private TextBox txtCodCargo;
        private TextBox txtDescCargo;
        private Label lblDescCargo;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblInformaçõesFornecedor;
        private Label lblRisco3;
        private Label lblObrigatoriedade;
        private Label lblUsuario;
        private Label lblMatriculaInicial;
        private Button bttCancelar;
        private Button bttConfirmar;
        private Label lblDescSubcategoria;
        private TextBox txtNomeCliente;
        private TextBox txtCodCliente;
        private Label lblCodSubcategoria;
        private PictureBox picBuscaCliente;
        private Label lblEstoque;
        private Label label2;
        private MaskedTextBox mskDtVenda;
        private Label lblCodProduto;
        private TextBox txtCodProduto;
        private PictureBox picBuscaProduto;
        private TextBox txtProduto;
        private Label label1;
        private Button bttAdicionarProduto;
        private DataGridView dataGridProdutos;
        private Label lblQntd;
        private TextBox txtQntdProduto;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtValorTotal;
        private Label label7;
        private Label label8;
        private CheckBox checkA_Vista;
        private CheckBox checkParcelado;
        private TextBox txtQntdParcelas;
        private Label lblQntdParcelas;
        private Label label6;
        private TextBox txtValorParcela;
        private TextBox txtQntdEstoque;
        private Label label9;
        private CheckBox checkCrédito;
        private CheckBox checkPix;
        private CheckBox checkBoleto;
        private CheckBox checkDebito;
        private Button bttRetirarItem;
        private Button button1;
    }
}