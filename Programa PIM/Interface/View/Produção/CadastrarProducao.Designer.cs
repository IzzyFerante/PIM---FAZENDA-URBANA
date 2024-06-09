using Interface.View.Vendas;

namespace Interface.View.Produção
{
    partial class CadastrarProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProducao));
            txtIdProducao = new TextBox();
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
            lblDtPlantio = new Label();
            lblInformaçõesFornecedor = new Label();
            lblRisco3 = new Label();
            lblObrigatoriedade = new Label();
            lblUsuario = new Label();
            lblMatriculaInicial = new Label();
            txtArea = new TextBox();
            lblArea = new Label();
            picBuscaArea = new PictureBox();
            mskDtPlantio = new MaskedTextBox();
            lblCodProduto = new Label();
            txtCodProduto = new TextBox();
            picBuscaProduto = new PictureBox();
            txtProduto = new TextBox();
            label1 = new Label();
            lblQntd = new Label();
            txtQntdPlantada = new TextBox();
            txtQntdEstoque = new TextBox();
            label9 = new Label();
            mskDtColheita = new MaskedTextBox();
            lblDtColheita = new Label();
            lblEstoque = new Label();
            label2 = new Label();
            txtNomeArea = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            faixadaVerde.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaProduto).BeginInit();
            SuspendLayout();
            // 
            // txtIdProducao
            // 
            txtIdProducao.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdProducao.Location = new Point(101, 322);
            txtIdProducao.MaxLength = 6;
            txtIdProducao.Name = "txtIdProducao";
            txtIdProducao.ReadOnly = true;
            txtIdProducao.Size = new Size(82, 34);
            txtIdProducao.TabIndex = 41;
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.cadastrar_producao_branco;
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
            lblAlterarProduto.Size = new Size(334, 46);
            lblAlterarProduto.TabIndex = 3;
            lblAlterarProduto.Text = "Cadastrar Produção";
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
            // lblDtPlantio
            // 
            lblDtPlantio.AutoSize = true;
            lblDtPlantio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDtPlantio.Location = new Point(362, 325);
            lblDtPlantio.Name = "lblDtPlantio";
            lblDtPlantio.Size = new Size(174, 28);
            lblDtPlantio.TabIndex = 39;
            lblDtPlantio.Text = "*Data do Plantio:";
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
            // txtArea
            // 
            txtArea.CharacterCasing = CharacterCasing.Upper;
            txtArea.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtArea.Location = new Point(1413, 321);
            txtArea.MaxLength = 6;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(81, 34);
            txtArea.TabIndex = 32;
            txtArea.TextChanged += txtCodArea_TextChanged;
            txtArea.Leave += txtCodArea_Leave;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblArea.Location = new Point(1337, 325);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(70, 28);
            lblArea.TabIndex = 33;
            lblArea.Text = "*Área:";
            // 
            // picBuscaArea
            // 
            picBuscaArea.Image = Properties.Resources.search_3917132;
            picBuscaArea.Location = new Point(1500, 327);
            picBuscaArea.Name = "picBuscaArea";
            picBuscaArea.Size = new Size(20, 25);
            picBuscaArea.SizeMode = PictureBoxSizeMode.Zoom;
            picBuscaArea.TabIndex = 34;
            picBuscaArea.TabStop = false;
            picBuscaArea.Click += picBuscaArea_Click;
            picBuscaArea.MouseLeave += MouseLeave;
            picBuscaArea.MouseHover += MouseHover;
            // 
            // mskDtPlantio
            // 
            mskDtPlantio.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskDtPlantio.Location = new Point(542, 321);
            mskDtPlantio.Mask = "00/00/0000";
            mskDtPlantio.Name = "mskDtPlantio";
            mskDtPlantio.Size = new Size(125, 34);
            mskDtPlantio.TabIndex = 27;
            mskDtPlantio.Leave += mskDtPlantio_Leave;
            // 
            // lblCodProduto
            // 
            lblCodProduto.AutoSize = true;
            lblCodProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodProduto.Location = new Point(60, 522);
            lblCodProduto.Name = "lblCodProduto";
            lblCodProduto.Size = new Size(140, 28);
            lblCodProduto.TabIndex = 26;
            lblCodProduto.Text = "Cód. Produto:";
            // 
            // txtCodProduto
            // 
            txtCodProduto.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodProduto.Location = new Point(205, 519);
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
            picBuscaProduto.Location = new Point(292, 525);
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
            txtProduto.Location = new Point(493, 519);
            txtProduto.Name = "txtProduto";
            txtProduto.ReadOnly = true;
            txtProduto.Size = new Size(381, 34);
            txtProduto.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(394, 522);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 22;
            label1.Text = "Produto:";
            // 
            // lblQntd
            // 
            lblQntd.AutoSize = true;
            lblQntd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQntd.Location = new Point(1497, 522);
            lblQntd.Name = "lblQntd";
            lblQntd.Size = new Size(225, 28);
            lblQntd.TabIndex = 19;
            lblQntd.Text = "*Quantidade plantada:";
            // 
            // txtQntdPlantada
            // 
            txtQntdPlantada.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntdPlantada.Location = new Point(1728, 519);
            txtQntdPlantada.MaxLength = 4;
            txtQntdPlantada.Name = "txtQntdPlantada";
            txtQntdPlantada.Size = new Size(125, 34);
            txtQntdPlantada.TabIndex = 18;
            txtQntdPlantada.Leave += txtQntdProduto_Leave;
            // 
            // txtQntdEstoque
            // 
            txtQntdEstoque.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQntdEstoque.Location = new Point(1195, 519);
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
            label9.Location = new Point(1039, 522);
            label9.Name = "label9";
            label9.Size = new Size(150, 28);
            label9.TabIndex = 5;
            label9.Text = "Qntd. Estoque:";
            // 
            // mskDtColheita
            // 
            mskDtColheita.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskDtColheita.Location = new Point(1043, 321);
            mskDtColheita.Mask = "00/00/0000";
            mskDtColheita.Name = "mskDtColheita";
            mskDtColheita.Size = new Size(125, 34);
            mskDtColheita.TabIndex = 47;
            // 
            // lblDtColheita
            // 
            lblDtColheita.AutoSize = true;
            lblDtColheita.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDtColheita.Location = new Point(820, 325);
            lblDtColheita.Name = "lblDtColheita";
            lblDtColheita.Size = new Size(217, 28);
            lblDtColheita.TabIndex = 48;
            lblDtColheita.Text = "*Previsão de colheita:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstoque.Location = new Point(60, 432);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(147, 37);
            lblEstoque.TabIndex = 49;
            lblEstoque.Text = "PRODUTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 452);
            label2.Name = "label2";
            label2.Size = new Size(1805, 38);
            label2.TabIndex = 50;
            label2.Text = "_____________________________________________________________________________________________________________________________________________________";
            // 
            // txtNomeArea
            // 
            txtNomeArea.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeArea.Location = new Point(1724, 321);
            txtNomeArea.MaxLength = 4;
            txtNomeArea.Name = "txtNomeArea";
            txtNomeArea.ReadOnly = true;
            txtNomeArea.Size = new Size(125, 34);
            txtNomeArea.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1594, 325);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 52;
            label3.Text = "Nome Área:";
            // 
            // CadastrarProducao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1920, 1080);
            Controls.Add(txtNomeArea);
            Controls.Add(label3);
            Controls.Add(lblEstoque);
            Controls.Add(label2);
            Controls.Add(mskDtColheita);
            Controls.Add(lblDtColheita);
            Controls.Add(txtQntdEstoque);
            Controls.Add(label9);
            Controls.Add(txtQntdPlantada);
            Controls.Add(lblQntd);
            Controls.Add(label1);
            Controls.Add(txtProduto);
            Controls.Add(picBuscaProduto);
            Controls.Add(txtCodProduto);
            Controls.Add(lblCodProduto);
            Controls.Add(mskDtPlantio);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(picBuscaArea);
            Controls.Add(lblMatriculaInicial);
            Controls.Add(lblUsuario);
            Controls.Add(lblObrigatoriedade);
            Controls.Add(lblInformaçõesFornecedor);
            Controls.Add(lblDtPlantio);
            Controls.Add(lblIdProduto);
            Controls.Add(txtIdProducao);
            Controls.Add(lblRisco3);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarProducao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarFuncionario";
            WindowState = FormWindowState.Maximized;
            FormClosed += _FormClosed;
            Load += CadastrarProducao_Load;
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProducao;
        private PictureBox picIcone;
        private Panel faixadaVerde;
        private Label lblAlterarProduto;
        private Panel panel1;
        private Panel panelicones;
        private Panel panel2;
        private Panel panel3;
        private PictureBox bttMinimizar;
        private Label lblIdProduto;
        private Label lblDtPlantio;
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
        private TextBox txtArea;
        private Label lblArea;
        private PictureBox picBuscaArea;
        private MaskedTextBox mskDtPlantio;
        private Label lblCodProduto;
        private TextBox txtCodProduto;
        private PictureBox picBuscaProduto;
        private TextBox txtProduto;
        private Label label1;
        private Label lblQntd;
        private TextBox txtQntdPlantada;
        private TextBox txtQntdEstoque;
        private Label label9;
        private MaskedTextBox mskDtColheita;
        private Label lblDtColheita;
        private Label lblEstoque;
        private Label label2;
        private TextBox txtNomeArea;
        private Label label3;
    }
}