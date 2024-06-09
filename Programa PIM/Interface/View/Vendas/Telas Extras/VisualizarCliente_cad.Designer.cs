namespace Interface.View.Vendas.Telas_Extras
{
    partial class VisualizarCliente_cad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarCliente_cad));
            faixadaVerde = new Panel();
            bttFechar = new PictureBox();
            lblSubcategoria = new Label();
            panelicones = new Panel();
            dataGridView = new DataGridView();
            bttSelecionar = new Button();
            bttBuscar = new Button();
            picFiltroBuscar = new Button();
            checkListBusca = new CheckedListBox();
            lblPesquisa = new Label();
            txtPesquisa = new TextBox();
            faixadaVerde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // faixadaVerde
            // 
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttFechar);
            faixadaVerde.Controls.Add(lblSubcategoria);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Dock = DockStyle.Top;
            faixadaVerde.ImeMode = ImeMode.NoControl;
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(664, 100);
            faixadaVerde.TabIndex = 12;
            // 
            // bttFechar
            // 
            bttFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttFechar.Image = Properties.Resources.output_onlinepngtools__14_;
            bttFechar.Location = new Point(632, 12);
            bttFechar.Name = "bttFechar";
            bttFechar.Size = new Size(20, 20);
            bttFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bttFechar.TabIndex = 6;
            bttFechar.TabStop = false;
            bttFechar.Click += bttFechar_Click;
            bttFechar.MouseLeave += MouseLeave;
            bttFechar.MouseHover += MouseHover;
            // 
            // lblSubcategoria
            // 
            lblSubcategoria.AutoSize = true;
            lblSubcategoria.BackColor = Color.DarkOliveGreen;
            lblSubcategoria.FlatStyle = FlatStyle.System;
            lblSubcategoria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubcategoria.ForeColor = SystemColors.ControlLightLight;
            lblSubcategoria.Location = new Point(28, 31);
            lblSubcategoria.Name = "lblSubcategoria";
            lblSubcategoria.Size = new Size(99, 31);
            lblSubcategoria.TabIndex = 0;
            lblSubcategoria.Text = "Clientes";
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(2055, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(49, 183);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(566, 312);
            dataGridView.TabIndex = 13;
            // 
            // bttSelecionar
            // 
            bttSelecionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttSelecionar.ForeColor = SystemColors.ControlLightLight;
            bttSelecionar.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttSelecionar.Location = new Point(517, 506);
            bttSelecionar.Name = "bttSelecionar";
            bttSelecionar.Size = new Size(107, 47);
            bttSelecionar.TabIndex = 16;
            bttSelecionar.Text = "Selecionar";
            bttSelecionar.UseVisualStyleBackColor = true;
            bttSelecionar.Click += bttSelecionar_Click;
            // 
            // bttBuscar
            // 
            bttBuscar.Image = Properties.Resources.search_3917132__1__resized_resized_resized;
            bttBuscar.Location = new Point(586, 132);
            bttBuscar.Name = "bttBuscar";
            bttBuscar.Size = new Size(30, 30);
            bttBuscar.TabIndex = 28;
            bttBuscar.UseVisualStyleBackColor = true;
            bttBuscar.Click += bttBuscar_Click;
            // 
            // picFiltroBuscar
            // 
            picFiltroBuscar.Image = Properties.Resources.output_onlinepngtools__19___1__resized;
            picFiltroBuscar.Location = new Point(380, 129);
            picFiltroBuscar.Name = "picFiltroBuscar";
            picFiltroBuscar.Size = new Size(52, 36);
            picFiltroBuscar.TabIndex = 32;
            picFiltroBuscar.UseVisualStyleBackColor = true;
            picFiltroBuscar.Click += picFiltroBuscar_Click;
            picFiltroBuscar.MouseLeave += MouseLeave;
            picFiltroBuscar.MouseHover += MouseHover;
            // 
            // checkListBusca
            // 
            checkListBusca.FormattingEnabled = true;
            checkListBusca.Items.AddRange(new object[] { "ID Cliente", "Nome", "CPF", "CNPJ", "Email" });
            checkListBusca.Location = new Point(385, 165);
            checkListBusca.Name = "checkListBusca";
            checkListBusca.Size = new Size(198, 114);
            checkListBusca.TabIndex = 31;
            checkListBusca.Visible = false;
            checkListBusca.ItemCheck += CheckListBusca_ItemCheck;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesquisa.Location = new Point(438, 110);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(67, 20);
            lblPesquisa.TabIndex = 30;
            lblPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.CharacterCasing = CharacterCasing.Upper;
            txtPesquisa.Location = new Point(438, 134);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(145, 27);
            txtPesquisa.TabIndex = 29;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // VisualizarCliente_cad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(664, 572);
            Controls.Add(bttBuscar);
            Controls.Add(picFiltroBuscar);
            Controls.Add(checkListBusca);
            Controls.Add(lblPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(bttSelecionar);
            Controls.Add(dataGridView);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisualizarCliente_cad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargo";
            Load += Visualizar_Load;
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel faixadaVerde;
        private Label lblSubcategoria;
        private Panel panelicones;
        private DataGridView dataGridView;
        private Button bttIncluir;
        private Button bttAlterar;
        private Button bttSelecionar;
        private Button bttBuscar;
        private Button picFiltroBuscar;
        private CheckedListBox checkListBusca;
        private Label lblPesquisa;
        private TextBox txtPesquisa;
        private PictureBox bttFechar;
    }
}