namespace Interface.View.Vendas
{
    partial class VisualizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarVenda));
            txtIdVenda = new TextBox();
            picIcone = new PictureBox();
            faixadaVerde = new Panel();
            bttFechar = new Button();
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
            lblEstoque = new Label();
            label2 = new Label();
            mskDtVenda = new MaskedTextBox();
            dataGridProdutos = new DataGridView();
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
            checkCrédito = new CheckBox();
            checkPix = new CheckBox();
            checkBoleto = new CheckBox();
            checkDebito = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            faixadaVerde.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
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
            txtIdVenda.TabIndex = 30;
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.visualizar_vendas_branco;
            picIcone.Location = new Point(42, 61);
            picIcone.Name = "picIcone";
            picIcone.Size = new Size(155, 139);
            picIcone.SizeMode = PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 3;
            picIcone.TabStop = false;
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttFechar);
            faixadaVerde.Controls.Add(panel3);
            faixadaVerde.Controls.Add(lblAlterarProduto);
            faixadaVerde.Controls.Add(picIcone);
            faixadaVerde.Controls.Add(panel1);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Controls.Add(panel2);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(1920, 200);
            faixadaVerde.TabIndex = 32;
            // 
            // bttFechar
            // 
            bttFechar.BackColor = Color.FromArgb(72, 44, 30);
            bttFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttFechar.ForeColor = SystemColors.ControlLightLight;
            bttFechar.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttFechar.Location = new Point(1779, 134);
            bttFechar.Name = "bttFechar";
            bttFechar.Size = new Size(120, 47);
            bttFechar.TabIndex = 0;
            bttFechar.Text = "Fechar";
            bttFechar.UseVisualStyleBackColor = false;
            bttFechar.Click += bttFechar_Click;
            bttFechar.MouseLeave += MouseLeave;
            bttFechar.MouseHover += MouseHover;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.Controls.Add(bttMinimizar);
            panel3.Location = new Point(1789, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 40);
            panel3.TabIndex = 1;
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
            lblAlterarProduto.Size = new Size(283, 46);
            lblAlterarProduto.TabIndex = 2;
            lblAlterarProduto.Text = "Visualizar Venda";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(5209, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 40);
            panel1.TabIndex = 4;
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
            panel2.TabIndex = 6;
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProduto.Location = new Point(60, 325);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(35, 28);
            lblIdProduto.TabIndex = 29;
            lblIdProduto.Text = "Id:";
            // 
            // lblDescProduto
            // 
            lblDescProduto.AutoSize = true;
            lblDescProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescProduto.Location = new Point(410, 325);
            lblDescProduto.Name = "lblDescProduto";
            lblDescProduto.Size = new Size(164, 28);
            lblDescProduto.TabIndex = 28;
            lblDescProduto.Text = "*Data da Venda:";
            // 
            // lblInformaçõesFornecedor
            // 
            lblInformaçõesFornecedor.AutoSize = true;
            lblInformaçõesFornecedor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesFornecedor.Location = new Point(60, 239);
            lblInformaçõesFornecedor.Name = "lblInformaçõesFornecedor";
            lblInformaçõesFornecedor.Size = new Size(311, 37);
            lblInformaçõesFornecedor.TabIndex = 27;
            lblInformaçõesFornecedor.Text = "INFORMAÇÕES GERAIS";
            // 
            // lblRisco3
            // 
            lblRisco3.AutoSize = true;
            lblRisco3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco3.Location = new Point(60, 259);
            lblRisco3.Name = "lblRisco3";
            lblRisco3.Size = new Size(1805, 38);
            lblRisco3.TabIndex = 31;
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
            lblObrigatoriedade.TabIndex = 26;
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
            lblUsuario.TabIndex = 25;
            // 
            // lblMatriculaInicial
            // 
            lblMatriculaInicial.AutoSize = true;
            lblMatriculaInicial.ForeColor = SystemColors.ControlLightLight;
            lblMatriculaInicial.Location = new Point(1853, 1065);
            lblMatriculaInicial.Name = "lblMatriculaInicial";
            lblMatriculaInicial.Size = new Size(0, 20);
            lblMatriculaInicial.TabIndex = 24;
            // 
            // lblDescSubcategoria
            // 
            lblDescSubcategoria.AutoSize = true;
            lblDescSubcategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescSubcategoria.Location = new Point(1319, 325);
            lblDescSubcategoria.Name = "lblDescSubcategoria";
            lblDescSubcategoria.Size = new Size(146, 28);
            lblDescSubcategoria.TabIndex = 20;
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
            txtNomeCliente.TabIndex = 21;
            // 
            // txtCodCliente
            // 
            txtCodCliente.CharacterCasing = CharacterCasing.Upper;
            txtCodCliente.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodCliente.Location = new Point(1060, 323);
            txtCodCliente.MaxLength = 6;
            txtCodCliente.Name = "txtCodCliente";
            txtCodCliente.ReadOnly = true;
            txtCodCliente.Size = new Size(81, 34);
            txtCodCliente.TabIndex = 22;
            // 
            // lblCodSubcategoria
            // 
            lblCodSubcategoria.AutoSize = true;
            lblCodSubcategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodSubcategoria.Location = new Point(919, 325);
            lblCodSubcategoria.Name = "lblCodSubcategoria";
            lblCodSubcategoria.Size = new Size(139, 28);
            lblCodSubcategoria.TabIndex = 23;
            lblCodSubcategoria.Text = "*Cód. Cliente:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstoque.Location = new Point(54, 408);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(162, 37);
            lblEstoque.TabIndex = 18;
            lblEstoque.Text = "PRODUTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 428);
            label2.Name = "label2";
            label2.Size = new Size(1805, 38);
            label2.TabIndex = 19;
            label2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // mskDtVenda
            // 
            mskDtVenda.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskDtVenda.Location = new Point(580, 322);
            mskDtVenda.Mask = "00/00/0000";
            mskDtVenda.Name = "mskDtVenda";
            mskDtVenda.ReadOnly = true;
            mskDtVenda.Size = new Size(125, 34);
            mskDtVenda.TabIndex = 17;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(60, 500);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.RowHeadersWidth = 51;
            dataGridProdutos.RowTemplate.Height = 29;
            dataGridProdutos.Size = new Size(1663, 263);
            dataGridProdutos.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 808);
            label3.Name = "label3";
            label3.Size = new Size(185, 37);
            label3.TabIndex = 14;
            label3.Text = "PAGAMENTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 828);
            label4.Name = "label4";
            label4.Size = new Size(1805, 38);
            label4.TabIndex = 15;
            label4.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(921, 911);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 13;
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
            txtValorTotal.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(55, 887);
            label7.Name = "label7";
            label7.Size = new Size(218, 28);
            label7.TabIndex = 11;
            label7.Text = "Forma de Pagamento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(370, 887);
            label8.Name = "label8";
            label8.Size = new Size(214, 28);
            label8.TabIndex = 10;
            label8.Text = "Modo de Pagamento:";
            // 
            // checkA_Vista
            // 
            checkA_Vista.AutoSize = true;
            checkA_Vista.Enabled = false;
            checkA_Vista.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkA_Vista.Location = new Point(377, 927);
            checkA_Vista.Name = "checkA_Vista";
            checkA_Vista.Size = new Size(86, 28);
            checkA_Vista.TabIndex = 9;
            checkA_Vista.Text = "À vista";
            checkA_Vista.UseVisualStyleBackColor = true;
            // 
            // checkParcelado
            // 
            checkParcelado.AutoSize = true;
            checkParcelado.Enabled = false;
            checkParcelado.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkParcelado.Location = new Point(377, 951);
            checkParcelado.Name = "checkParcelado";
            checkParcelado.Size = new Size(114, 28);
            checkParcelado.TabIndex = 8;
            checkParcelado.Text = "Parcelado";
            checkParcelado.UseVisualStyleBackColor = true;
            // 
            // txtQntdParcelas
            // 
            txtQntdParcelas.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntdParcelas.Location = new Point(882, 974);
            txtQntdParcelas.Name = "txtQntdParcelas";
            txtQntdParcelas.ReadOnly = true;
            txtQntdParcelas.Size = new Size(125, 34);
            txtQntdParcelas.TabIndex = 7;
            // 
            // lblQntdParcelas
            // 
            lblQntdParcelas.AutoSize = true;
            lblQntdParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQntdParcelas.Location = new Point(715, 977);
            lblQntdParcelas.Name = "lblQntdParcelas";
            lblQntdParcelas.Size = new Size(153, 28);
            lblQntdParcelas.TabIndex = 6;
            lblQntdParcelas.Text = "Qntd. Parcelas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1071, 977);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 5;
            label6.Text = "Valor Parcela:";
            // 
            // txtValorParcela
            // 
            txtValorParcela.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorParcela.Location = new Point(1217, 974);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.ReadOnly = true;
            txtValorParcela.Size = new Size(125, 34);
            txtValorParcela.TabIndex = 4;
            // 
            // checkCrédito
            // 
            checkCrédito.AutoSize = true;
            checkCrédito.Enabled = false;
            checkCrédito.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkCrédito.Location = new Point(63, 927);
            checkCrédito.Name = "checkCrédito";
            checkCrédito.Size = new Size(178, 28);
            checkCrédito.TabIndex = 3;
            checkCrédito.Text = "Cartão de Crédito";
            checkCrédito.UseVisualStyleBackColor = true;
            // 
            // checkPix
            // 
            checkPix.AutoSize = true;
            checkPix.Enabled = false;
            checkPix.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkPix.Location = new Point(63, 974);
            checkPix.Name = "checkPix";
            checkPix.Size = new Size(55, 28);
            checkPix.TabIndex = 2;
            checkPix.Text = "Pix";
            checkPix.UseVisualStyleBackColor = true;
            // 
            // checkBoleto
            // 
            checkBoleto.AutoSize = true;
            checkBoleto.Enabled = false;
            checkBoleto.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoleto.Location = new Point(63, 996);
            checkBoleto.Name = "checkBoleto";
            checkBoleto.Size = new Size(85, 28);
            checkBoleto.TabIndex = 1;
            checkBoleto.Text = "Boleto";
            checkBoleto.UseVisualStyleBackColor = true;
            // 
            // checkDebito
            // 
            checkDebito.AutoSize = true;
            checkDebito.Enabled = false;
            checkDebito.Font = new Font("Microsoft YaHei UI Light", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkDebito.Location = new Point(63, 951);
            checkDebito.Name = "checkDebito";
            checkDebito.Size = new Size(173, 28);
            checkDebito.TabIndex = 0;
            checkDebito.Text = "Cartão de Débito";
            checkDebito.UseVisualStyleBackColor = true;
            // 
            // VisualizarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1920, 1080);
            Controls.Add(checkDebito);
            Controls.Add(checkBoleto);
            Controls.Add(checkPix);
            Controls.Add(checkCrédito);
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
            Controls.Add(dataGridProdutos);
            Controls.Add(mskDtVenda);
            Controls.Add(lblEstoque);
            Controls.Add(label2);
            Controls.Add(lblDescSubcategoria);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtCodCliente);
            Controls.Add(lblCodSubcategoria);
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
            Name = "VisualizarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarFuncionario";
            WindowState = FormWindowState.Maximized;
            Load += CadastrarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
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
        private Button bttFechar;
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
    }
}