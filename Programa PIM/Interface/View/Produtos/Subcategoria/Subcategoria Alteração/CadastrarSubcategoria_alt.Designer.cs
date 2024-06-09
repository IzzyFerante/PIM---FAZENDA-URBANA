
namespace Interface.View.Produtos.Subcategoria.Subcategoria_Alteração
{
    partial class CadastrarSubcategoria_alt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarSubcategoria_alt));
            faixadaVerde = new Panel();
            bttFechar = new PictureBox();
            lblCadastrarSubcategoria = new Label();
            panelicones = new Panel();
            lblCodSubcategoria = new Label();
            txtCodSubcategoria = new TextBox();
            txtDescSubcategoria = new TextBox();
            lblDescSubcategoria = new Label();
            bttCancelar = new Button();
            bttConfirmar = new Button();
            faixadaVerde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).BeginInit();
            SuspendLayout();
            // 
            // faixadaVerde
            // 
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttFechar);
            faixadaVerde.Controls.Add(lblCadastrarSubcategoria);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Dock = DockStyle.Top;
            faixadaVerde.ImeMode = ImeMode.NoControl;
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(733, 70);
            faixadaVerde.TabIndex = 13;
            // 
            // bttFechar
            // 
            bttFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttFechar.Image = Properties.Resources.output_onlinepngtools__14_;
            bttFechar.Location = new Point(632, 12);
            bttFechar.Name = "bttFechar";
            bttFechar.Size = new Size(553, 0);
            bttFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bttFechar.TabIndex = 6;
            bttFechar.TabStop = false;
            // 
            // lblCadastrarSubcategoria
            // 
            lblCadastrarSubcategoria.AutoSize = true;
            lblCadastrarSubcategoria.BackColor = Color.DarkOliveGreen;
            lblCadastrarSubcategoria.FlatStyle = FlatStyle.System;
            lblCadastrarSubcategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastrarSubcategoria.ForeColor = SystemColors.ControlLightLight;
            lblCadastrarSubcategoria.Location = new Point(26, 20);
            lblCadastrarSubcategoria.Name = "lblCadastrarSubcategoria";
            lblCadastrarSubcategoria.Size = new Size(199, 28);
            lblCadastrarSubcategoria.TabIndex = 0;
            lblCadastrarSubcategoria.Text = "Cadastrar Categoria";
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(2588, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // lblCodSubcategoria
            // 
            lblCodSubcategoria.AllowDrop = true;
            lblCodSubcategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodSubcategoria.Location = new Point(57, 105);
            lblCodSubcategoria.Name = "lblCodSubcategoria";
            lblCodSubcategoria.Size = new Size(127, 23);
            lblCodSubcategoria.TabIndex = 14;
            lblCodSubcategoria.Text = "Cód. Categoria";
            // 
            // txtCodSubcategoria
            // 
            txtCodSubcategoria.Font = new Font("Microsoft YaHei UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodSubcategoria.Location = new Point(190, 102);
            txtCodSubcategoria.MaxLength = 5;
            txtCodSubcategoria.Name = "txtCodSubcategoria";
            txtCodSubcategoria.ReadOnly = true;
            txtCodSubcategoria.Size = new Size(61, 29);
            txtCodSubcategoria.TabIndex = 15;
            // 
            // txtDescSubcategoria
            // 
            txtDescSubcategoria.CharacterCasing = CharacterCasing.Upper;
            txtDescSubcategoria.Font = new Font("Microsoft YaHei UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescSubcategoria.Location = new Point(430, 102);
            txtDescSubcategoria.MaxLength = 35;
            txtDescSubcategoria.Name = "txtDescSubcategoria";
            txtDescSubcategoria.Size = new Size(240, 29);
            txtDescSubcategoria.TabIndex = 16;
            txtDescSubcategoria.KeyDown += txtDescSubcategoria_KeyDown;
            txtDescSubcategoria.Leave += txtDescSubcategoria_Leave;
            // 
            // lblDescSubcategoria
            // 
            lblDescSubcategoria.AutoSize = true;
            lblDescSubcategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescSubcategoria.Location = new Point(288, 105);
            lblDescSubcategoria.Name = "lblDescSubcategoria";
            lblDescSubcategoria.Size = new Size(136, 23);
            lblDescSubcategoria.TabIndex = 17;
            lblDescSubcategoria.Text = "*Desc. Categoria";
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttCancelar.Location = new Point(519, 172);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(94, 35);
            bttCancelar.TabIndex = 18;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            bttCancelar.Click += bttCancelar_Click;
            bttCancelar.MouseLeave += MouseLeave;
            bttCancelar.MouseHover += MouseHover;
            // 
            // bttConfirmar
            // 
            bttConfirmar.BackColor = Color.FromArgb(72, 44, 30);
            bttConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttConfirmar.ForeColor = Color.Snow;
            bttConfirmar.Location = new Point(627, 171);
            bttConfirmar.Name = "bttConfirmar";
            bttConfirmar.Size = new Size(94, 37);
            bttConfirmar.TabIndex = 19;
            bttConfirmar.Text = "Confirmar";
            bttConfirmar.UseVisualStyleBackColor = false;
            bttConfirmar.Click += bttConfirmar_Click;
            bttConfirmar.MouseLeave += MouseLeave;
            bttConfirmar.MouseHover += MouseHover;
            // 
            // CadastrarSubcategoria_alt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(733, 219);
            Controls.Add(bttConfirmar);
            Controls.Add(bttCancelar);
            Controls.Add(lblDescSubcategoria);
            Controls.Add(txtDescSubcategoria);
            Controls.Add(txtCodSubcategoria);
            Controls.Add(lblCodSubcategoria);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarSubcategoria_alt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarCargo";
            Load += CadastrarSubcategoria_Load;
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel faixadaVerde;
        private PictureBox bttFechar;
        private Label lblCadastrarSubcategoria;
        private Panel panelicones;
        private Label lblCodSubcategoria;
        private TextBox txtCodSubcategoria;
        private TextBox txtDescSubcategoria;
        private Label lblDescSubcategoria;
        private Button bttCancelar;
        private Button bttConfirmar;
    }
}