namespace Interface.View.Produtos
{
    partial class VisualizarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarProduto));
            txtIdProduto = new TextBox();
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
            txtDescProduto = new TextBox();
            checkProdutoAtivo = new CheckBox();
            lblInformaçõesContato = new Label();
            lblRisco2 = new Label();
            lblInformaçõesFornecedor = new Label();
            lblRisco3 = new Label();
            lblObrigatoriedade = new Label();
            lblUsuario = new Label();
            lblMatriculaInicial = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            lblDescSubcategoria = new Label();
            txtDescSubcategoria = new TextBox();
            txtCodSubcategoria = new TextBox();
            lblCodSubcategoria = new Label();
            picBuscaSubcategoria = new PictureBox();
            lblEstoque = new Label();
            label2 = new Label();
            lblQntdEstoque = new Label();
            txtQntdEstoque = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            faixadaVerde.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaSubcategoria).BeginInit();
            SuspendLayout();
            // 
            // txtIdProduto
            // 
            txtIdProduto.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdProduto.Location = new Point(101, 347);
            txtIdProduto.MaxLength = 6;
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.ReadOnly = true;
            txtIdProduto.Size = new Size(82, 34);
            txtIdProduto.TabIndex = 0;
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.visualizar_produto_branco;
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
            faixadaVerde.Controls.Add(lblAlterarProduto);
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
            // 
            // lblAlterarProduto
            // 
            lblAlterarProduto.AutoSize = true;
            lblAlterarProduto.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlterarProduto.ForeColor = SystemColors.ControlLightLight;
            lblAlterarProduto.Location = new Point(208, 134);
            lblAlterarProduto.Name = "lblAlterarProduto";
            lblAlterarProduto.Size = new Size(316, 46);
            lblAlterarProduto.TabIndex = 18;
            lblAlterarProduto.Text = "Visualizar Produto";
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
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProduto.Location = new Point(60, 350);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(35, 28);
            lblIdProduto.TabIndex = 21;
            lblIdProduto.Text = "Id:";
            // 
            // lblDescProduto
            // 
            lblDescProduto.AutoSize = true;
            lblDescProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescProduto.Location = new Point(672, 351);
            lblDescProduto.Name = "lblDescProduto";
            lblDescProduto.Size = new Size(118, 28);
            lblDescProduto.TabIndex = 22;
            lblDescProduto.Text = "*Descrição:";
            // 
            // txtDescProduto
            // 
            txtDescProduto.CharacterCasing = CharacterCasing.Upper;
            txtDescProduto.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescProduto.Location = new Point(796, 347);
            txtDescProduto.MaxLength = 25;
            txtDescProduto.Name = "txtDescProduto";
            txtDescProduto.ReadOnly = true;
            txtDescProduto.Size = new Size(364, 34);
            txtDescProduto.TabIndex = 23;
            txtDescProduto.Tag = "";
            // 
            // checkProdutoAtivo
            // 
            checkProdutoAtivo.AutoSize = true;
            checkProdutoAtivo.Enabled = false;
            checkProdutoAtivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkProdutoAtivo.Location = new Point(1694, 244);
            checkProdutoAtivo.Name = "checkProdutoAtivo";
            checkProdutoAtivo.Size = new Size(167, 32);
            checkProdutoAtivo.TabIndex = 25;
            checkProdutoAtivo.Text = "Produto Ativo";
            checkProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // lblInformaçõesContato
            // 
            lblInformaçõesContato.AutoSize = true;
            lblInformaçõesContato.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformaçõesContato.Location = new Point(55, 464);
            lblInformaçõesContato.Name = "lblInformaçõesContato";
            lblInformaçõesContato.Size = new Size(166, 37);
            lblInformaçõesContato.TabIndex = 58;
            lblInformaçõesContato.Text = "CATEGORIA";
            // 
            // lblRisco2
            // 
            lblRisco2.AutoSize = true;
            lblRisco2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRisco2.Location = new Point(55, 484);
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
            lblInformaçõesFornecedor.Size = new Size(118, 37);
            lblInformaçõesFornecedor.TabIndex = 58;
            lblInformaçõesFornecedor.Text = "DADOS ";
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
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.Location = new Point(1565, 351);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(155, 28);
            lblValor.TabIndex = 65;
            lblValor.Text = "*Valor unitário:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(1726, 347);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(125, 34);
            txtValor.TabIndex = 66;
            // 
            // lblDescSubcategoria
            // 
            lblDescSubcategoria.AutoSize = true;
            lblDescSubcategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescSubcategoria.Location = new Point(457, 568);
            lblDescSubcategoria.Name = "lblDescSubcategoria";
            lblDescSubcategoria.Size = new Size(206, 28);
            lblDescSubcategoria.TabIndex = 70;
            lblDescSubcategoria.Text = "Descrição Categoria:";
            // 
            // txtDescSubcategoria
            // 
            txtDescSubcategoria.CharacterCasing = CharacterCasing.Upper;
            txtDescSubcategoria.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescSubcategoria.Location = new Point(669, 567);
            txtDescSubcategoria.MaxLength = 35;
            txtDescSubcategoria.Name = "txtDescSubcategoria";
            txtDescSubcategoria.ReadOnly = true;
            txtDescSubcategoria.Size = new Size(381, 34);
            txtDescSubcategoria.TabIndex = 69;
            // 
            // txtCodSubcategoria
            // 
            txtCodSubcategoria.CharacterCasing = CharacterCasing.Upper;
            txtCodSubcategoria.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodSubcategoria.Location = new Point(227, 562);
            txtCodSubcategoria.MaxLength = 5;
            txtCodSubcategoria.Name = "txtCodSubcategoria";
            txtCodSubcategoria.ReadOnly = true;
            txtCodSubcategoria.Size = new Size(67, 34);
            txtCodSubcategoria.TabIndex = 68;
            // 
            // lblCodSubcategoria
            // 
            lblCodSubcategoria.AutoSize = true;
            lblCodSubcategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodSubcategoria.Location = new Point(57, 565);
            lblCodSubcategoria.Name = "lblCodSubcategoria";
            lblCodSubcategoria.Size = new Size(164, 28);
            lblCodSubcategoria.TabIndex = 67;
            lblCodSubcategoria.Text = "*Cód. Categoria:";
            // 
            // picBuscaSubcategoria
            // 
            picBuscaSubcategoria.Image = Properties.Resources.search_3917132;
            picBuscaSubcategoria.Location = new Point(300, 568);
            picBuscaSubcategoria.Name = "picBuscaSubcategoria";
            picBuscaSubcategoria.Size = new Size(20, 25);
            picBuscaSubcategoria.SizeMode = PictureBoxSizeMode.Zoom;
            picBuscaSubcategoria.TabIndex = 71;
            picBuscaSubcategoria.TabStop = false;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstoque.Location = new Point(57, 684);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(366, 37);
            lblEstoque.TabIndex = 72;
            lblEstoque.Text = "QUANTIDADE EM ESTOQUE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 704);
            label2.Name = "label2";
            label2.Size = new Size(1805, 38);
            label2.TabIndex = 73;
            label2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // lblQntdEstoque
            // 
            lblQntdEstoque.AutoSize = true;
            lblQntdEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQntdEstoque.Location = new Point(61, 793);
            lblQntdEstoque.Name = "lblQntdEstoque";
            lblQntdEstoque.Size = new Size(136, 28);
            lblQntdEstoque.TabIndex = 74;
            lblQntdEstoque.Text = "*Quantidade:";
            // 
            // txtQntdEstoque
            // 
            txtQntdEstoque.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntdEstoque.Location = new Point(203, 789);
            txtQntdEstoque.MaxLength = 4;
            txtQntdEstoque.Name = "txtQntdEstoque";
            txtQntdEstoque.ReadOnly = true;
            txtQntdEstoque.Size = new Size(125, 34);
            txtQntdEstoque.TabIndex = 75;
            // 
            // VisualizarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1920, 1080);
            Controls.Add(txtQntdEstoque);
            Controls.Add(lblQntdEstoque);
            Controls.Add(lblEstoque);
            Controls.Add(label2);
            Controls.Add(lblDescSubcategoria);
            Controls.Add(txtDescSubcategoria);
            Controls.Add(txtCodSubcategoria);
            Controls.Add(lblCodSubcategoria);
            Controls.Add(picBuscaSubcategoria);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblMatriculaInicial);
            Controls.Add(lblUsuario);
            Controls.Add(lblObrigatoriedade);
            Controls.Add(lblInformaçõesFornecedor);
            Controls.Add(checkProdutoAtivo);
            Controls.Add(txtDescProduto);
            Controls.Add(lblDescProduto);
            Controls.Add(lblIdProduto);
            Controls.Add(txtIdProduto);
            Controls.Add(lblRisco3);
            Controls.Add(lblInformaçõesContato);
            Controls.Add(lblRisco2);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisualizarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarFuncionario";
            WindowState = FormWindowState.Maximized;
            Load += Tela_Load;
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaSubcategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProduto;
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
        private TextBox txtDescProduto;
        private CheckBox checkProdutoAtivo;
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
        private Label lblInformaçõesContato;
        private Label lblRisco2;
        private Label lblInformaçõesFornecedor;
        private Label lblRisco3;
        private Label lblObrigatoriedade;
        private Label lblUsuario;
        private Label lblMatriculaInicial;
        private Button bttCancelar;
        private Button bttConfirmar;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblDescSubcategoria;
        private TextBox txtDescSubcategoria;
        private TextBox txtCodSubcategoria;
        private Label lblCodSubcategoria;
        private PictureBox picBuscaSubcategoria;
        private Label lblEstoque;
        private Label label2;
        private Label lblQntdEstoque;
        private TextBox txtQntdEstoque;
    }
}