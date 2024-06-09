namespace Interface.View.Vendas
{
    partial class TelaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVendas));
            faixadaVerde = new Panel();
            pictureBox1 = new PictureBox();
            lblClientes = new Label();
            picVoltar = new PictureBox();
            picIcone = new PictureBox();
            panel1 = new Panel();
            panelicones = new Panel();
            panel2 = new Panel();
            bttMaximizar = new PictureBox();
            bttFechar = new PictureBox();
            bttMinimizar = new PictureBox();
            bttRestaurar = new PictureBox();
            bttVisualizar = new Button();
            bttAlterar = new Button();
            bttIncluir = new Button();
            dataGridView1 = new DataGridView();
            lblUsuario = new Label();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            checkListBusca = new CheckedListBox();
            picFiltroBuscar = new Button();
            bttBuscar = new Button();
            faixadaVerde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bttFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bttRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(pictureBox1);
            faixadaVerde.Controls.Add(lblClientes);
            faixadaVerde.Controls.Add(picVoltar);
            faixadaVerde.Controls.Add(picIcone);
            faixadaVerde.Controls.Add(panel1);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Controls.Add(panel2);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(1920, 200);
            faixadaVerde.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.output_onlinepngtools__25_;
            pictureBox1.Location = new Point(756, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientes.ForeColor = SystemColors.ControlLightLight;
            lblClientes.Location = new Point(208, 134);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(134, 46);
            lblClientes.TabIndex = 18;
            lblClientes.Text = "Vendas";
            // 
            // picVoltar
            // 
            picVoltar.Image = Properties.Resources.output_onlinepngtools__13_;
            picVoltar.Location = new Point(12, 12);
            picVoltar.Name = "picVoltar";
            picVoltar.Size = new Size(25, 25);
            picVoltar.SizeMode = PictureBoxSizeMode.Zoom;
            picVoltar.TabIndex = 12;
            picVoltar.TabStop = false;
            picVoltar.Click += picVoltar_Click;
            picVoltar.MouseLeave += MouseLeave;
            picVoltar.MouseHover += MouseHover;
            // 
            // picIcone
            // 
            picIcone.Image = Properties.Resources.vendas_branco;
            picIcone.Location = new Point(42, 61);
            picIcone.Name = "picIcone";
            picIcone.Size = new Size(155, 139);
            picIcone.SizeMode = PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 11;
            picIcone.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(3489, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 40);
            panel1.TabIndex = 6;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(4271, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Controls.Add(bttMaximizar);
            panel2.Controls.Add(bttFechar);
            panel2.Controls.Add(bttMinimizar);
            panel2.Controls.Add(bttRestaurar);
            panel2.Location = new Point(1789, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(128, 40);
            panel2.TabIndex = 17;
            // 
            // bttMaximizar
            // 
            bttMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttMaximizar.Image = Properties.Resources.output_onlinepngtools__18_;
            bttMaximizar.Location = new Point(75, 10);
            bttMaximizar.Name = "bttMaximizar";
            bttMaximizar.Size = new Size(20, 20);
            bttMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            bttMaximizar.TabIndex = 4;
            bttMaximizar.TabStop = false;
            bttMaximizar.Visible = false;
            bttMaximizar.Click += bttMaximizar_Click;
            bttMaximizar.MouseLeave += MouseLeave;
            bttMaximizar.MouseHover += MouseHover;
            // 
            // bttFechar
            // 
            bttFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttFechar.Image = Properties.Resources.output_onlinepngtools__14_;
            bttFechar.Location = new Point(101, 10);
            bttFechar.Name = "bttFechar";
            bttFechar.Size = new Size(20, 20);
            bttFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bttFechar.TabIndex = 1;
            bttFechar.TabStop = false;
            bttFechar.Click += bttFechar_Click;
            bttFechar.MouseLeave += MouseLeave;
            bttFechar.MouseHover += MouseHover;
            // 
            // bttMinimizar
            // 
            bttMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttMinimizar.Image = Properties.Resources.output_onlinepngtools__17_;
            bttMinimizar.Location = new Point(49, 10);
            bttMinimizar.Name = "bttMinimizar";
            bttMinimizar.Size = new Size(20, 20);
            bttMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            bttMinimizar.TabIndex = 3;
            bttMinimizar.TabStop = false;
            bttMinimizar.Click += bttMinimizar_Click;
            bttMinimizar.MouseLeave += MouseLeave;
            bttMinimizar.MouseHover += MouseHover;
            // 
            // bttRestaurar
            // 
            bttRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttRestaurar.Image = Properties.Resources.output_onlinepngtools__15_;
            bttRestaurar.Location = new Point(75, 10);
            bttRestaurar.Name = "bttRestaurar";
            bttRestaurar.Size = new Size(20, 20);
            bttRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            bttRestaurar.TabIndex = 2;
            bttRestaurar.TabStop = false;
            bttRestaurar.Click += bttRestaurar_Click;
            bttRestaurar.MouseLeave += MouseLeave;
            bttRestaurar.MouseHover += MouseHover;
            // 
            // bttVisualizar
            // 
            bttVisualizar.BackColor = Color.White;
            bttVisualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttVisualizar.ForeColor = SystemColors.ControlLightLight;
            bttVisualizar.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttVisualizar.Location = new Point(320, 228);
            bttVisualizar.Name = "bttVisualizar";
            bttVisualizar.Size = new Size(107, 47);
            bttVisualizar.TabIndex = 13;
            bttVisualizar.Text = "Visualizar";
            bttVisualizar.UseVisualStyleBackColor = false;
            bttVisualizar.Click += bttVisualizar_Click;
            bttVisualizar.MouseLeave += MouseLeave;
            bttVisualizar.MouseHover += MouseHover;
            // 
            // bttAlterar
            // 
            bttAlterar.BackColor = Color.White;
            bttAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttAlterar.ForeColor = SystemColors.ControlLightLight;
            bttAlterar.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttAlterar.Location = new Point(180, 228);
            bttAlterar.Name = "bttAlterar";
            bttAlterar.Size = new Size(107, 47);
            bttAlterar.TabIndex = 14;
            bttAlterar.Text = "Alterar";
            bttAlterar.UseVisualStyleBackColor = false;
            bttAlterar.Click += bttAlterar_Click;
            bttAlterar.MouseLeave += MouseLeave;
            bttAlterar.MouseHover += MouseHover;
            // 
            // bttIncluir
            // 
            bttIncluir.BackColor = Color.White;
            bttIncluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttIncluir.ForeColor = SystemColors.ControlLightLight;
            bttIncluir.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttIncluir.Location = new Point(40, 228);
            bttIncluir.Name = "bttIncluir";
            bttIncluir.Size = new Size(107, 47);
            bttIncluir.TabIndex = 15;
            bttIncluir.Text = "Incluir";
            bttIncluir.UseVisualStyleBackColor = false;
            bttIncluir.Click += bttIncluir_Click;
            bttIncluir.MouseLeave += MouseLeave;
            bttIncluir.MouseHover += MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1840, 740);
            dataGridView1.TabIndex = 20;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(1908, 1051);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 20);
            lblUsuario.TabIndex = 19;
            // 
            // txtPesquisa
            // 
            txtPesquisa.CharacterCasing = CharacterCasing.Upper;
            txtPesquisa.Location = new Point(1574, 237);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(279, 27);
            txtPesquisa.TabIndex = 21;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesquisa.Location = new Point(1574, 213);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(67, 20);
            lblPesquisa.TabIndex = 23;
            lblPesquisa.Text = "Pesquisa";
            // 
            // checkListBusca
            // 
            checkListBusca.FormattingEnabled = true;
            checkListBusca.Items.AddRange(new object[] { "ID Venda", "ID Cliente", "Forma de Pagamento" });
            checkListBusca.Location = new Point(1521, 268);
            checkListBusca.Name = "checkListBusca";
            checkListBusca.Size = new Size(332, 70);
            checkListBusca.TabIndex = 24;
            checkListBusca.Visible = false;
            checkListBusca.ItemCheck += CheckListBusca_ItemCheck;
            // 
            // picFiltroBuscar
            // 
            picFiltroBuscar.Image = Properties.Resources.output_onlinepngtools__19___1__resized;
            picFiltroBuscar.Location = new Point(1516, 232);
            picFiltroBuscar.Name = "picFiltroBuscar";
            picFiltroBuscar.Size = new Size(52, 36);
            picFiltroBuscar.TabIndex = 27;
            picFiltroBuscar.UseVisualStyleBackColor = true;
            picFiltroBuscar.Click += picFiltroBuscar_Click;
            picFiltroBuscar.MouseLeave += MouseLeave;
            picFiltroBuscar.MouseHover += MouseHover;
            // 
            // bttBuscar
            // 
            bttBuscar.Image = Properties.Resources.search_3917132__1__resized_resized_resized;
            bttBuscar.Location = new Point(1852, 235);
            bttBuscar.Name = "bttBuscar";
            bttBuscar.Size = new Size(30, 30);
            bttBuscar.TabIndex = 19;
            bttBuscar.UseVisualStyleBackColor = true;
            bttBuscar.Click += bttBuscar_Click;
            bttBuscar.MouseLeave += MouseLeave;
            bttBuscar.MouseHover += MouseHover;
            // 
            // TelaVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1920, 1080);
            Controls.Add(bttBuscar);
            Controls.Add(picFiltroBuscar);
            Controls.Add(checkListBusca);
            Controls.Add(lblPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(lblUsuario);
            Controls.Add(dataGridView1);
            Controls.Add(bttIncluir);
            Controls.Add(bttAlterar);
            Controls.Add(bttVisualizar);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedores";
            FormClosed += _FormClosed;
            Load += Tela_Load;
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bttMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bttFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bttMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bttRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel faixadaVerde;
        private Panel panel1;
        private Panel panelicones;
        private PictureBox picIcone;
        private PictureBox picVoltar;
        private Button bttVisualizar;
        private Button bttAlterar;
        private Button bttIncluir;
        private DataGridView dataGridView1;
        private PictureBox bttMaximizar;
        private PictureBox bttFechar;
        private PictureBox bttMinimizar;
        private PictureBox bttRestaurar;
        private Panel panel2;
        private Label lblClientes;
        private Label lblUsuario;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
        private CheckedListBox checkListBusca;
        private Button picFiltroBuscar;
        private Button bttBuscar;
        private PictureBox pictureBox1;
    }
}