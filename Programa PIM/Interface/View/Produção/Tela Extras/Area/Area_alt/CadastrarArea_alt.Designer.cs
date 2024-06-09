namespace Interface.View.Produção.Tela_Extras.Area.Area_alt
{
    partial class CadastrarArea_alt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarArea_alt));
            faixadaVerde = new Panel();
            bttFechar = new PictureBox();
            lblCadastrarCargo = new Label();
            panelicones = new Panel();
            lblCodCargo = new Label();
            txtCodCargo = new TextBox();
            txtDescCargo = new TextBox();
            lblDescCargo = new Label();
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
            faixadaVerde.Controls.Add(lblCadastrarCargo);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Dock = DockStyle.Top;
            faixadaVerde.ImeMode = ImeMode.NoControl;
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(547, 70);
            faixadaVerde.TabIndex = 13;
            // 
            // bttFechar
            // 
            bttFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttFechar.Image = Properties.Resources.output_onlinepngtools__14_;
            bttFechar.Location = new Point(632, 12);
            bttFechar.Name = "bttFechar";
            bttFechar.Size = new Size(367, 0);
            bttFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bttFechar.TabIndex = 6;
            bttFechar.TabStop = false;
            // 
            // lblCadastrarCargo
            // 
            lblCadastrarCargo.AutoSize = true;
            lblCadastrarCargo.BackColor = Color.DarkOliveGreen;
            lblCadastrarCargo.FlatStyle = FlatStyle.System;
            lblCadastrarCargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastrarCargo.ForeColor = SystemColors.ControlLightLight;
            lblCadastrarCargo.Location = new Point(26, 20);
            lblCadastrarCargo.Name = "lblCadastrarCargo";
            lblCadastrarCargo.Size = new Size(152, 28);
            lblCadastrarCargo.TabIndex = 0;
            lblCadastrarCargo.Text = "Cadastrar Área";
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(2402, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // lblCodCargo
            // 
            lblCodCargo.AutoSize = true;
            lblCodCargo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodCargo.Location = new Point(42, 106);
            lblCodCargo.Name = "lblCodCargo";
            lblCodCargo.Size = new Size(27, 23);
            lblCodCargo.TabIndex = 14;
            lblCodCargo.Text = "ID";
            // 
            // txtCodCargo
            // 
            txtCodCargo.Font = new Font("Microsoft YaHei UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodCargo.Location = new Point(75, 103);
            txtCodCargo.MaxLength = 5;
            txtCodCargo.Name = "txtCodCargo";
            txtCodCargo.ReadOnly = true;
            txtCodCargo.Size = new Size(61, 29);
            txtCodCargo.TabIndex = 15;
            // 
            // txtDescCargo
            // 
            txtDescCargo.CharacterCasing = CharacterCasing.Upper;
            txtDescCargo.Font = new Font("Microsoft YaHei UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescCargo.Location = new Point(258, 103);
            txtDescCargo.MaxLength = 35;
            txtDescCargo.Name = "txtDescCargo";
            txtDescCargo.Size = new Size(240, 29);
            txtDescCargo.TabIndex = 16;
            txtDescCargo.KeyDown += txtDescCargo_KeyDown;
            txtDescCargo.Leave += txtDescCargo_Leave;
            // 
            // lblDescCargo
            // 
            lblDescCargo.AutoSize = true;
            lblDescCargo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescCargo.Location = new Point(195, 106);
            lblDescCargo.Name = "lblDescCargo";
            lblDescCargo.Size = new Size(57, 23);
            lblDescCargo.TabIndex = 17;
            lblDescCargo.Text = "Nome";
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttCancelar.Location = new Point(317, 156);
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
            bttConfirmar.Location = new Point(425, 155);
            bttConfirmar.Name = "bttConfirmar";
            bttConfirmar.Size = new Size(94, 37);
            bttConfirmar.TabIndex = 19;
            bttConfirmar.Text = "Confirmar";
            bttConfirmar.UseVisualStyleBackColor = false;
            bttConfirmar.Click += bttConfirmar_Click;
            bttConfirmar.MouseLeave += MouseLeave;
            bttConfirmar.MouseHover += MouseHover;
            // 
            // CadastrarArea_alt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(547, 199);
            Controls.Add(bttConfirmar);
            Controls.Add(bttCancelar);
            Controls.Add(lblDescCargo);
            Controls.Add(txtDescCargo);
            Controls.Add(txtCodCargo);
            Controls.Add(lblCodCargo);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarArea_alt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarCargo";
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel faixadaVerde;
        private PictureBox bttFechar;
        private Label lblCadastrarCargo;
        private Panel panelicones;
        private Label lblCodCargo;
        private TextBox txtCodCargo;
        private TextBox txtDescCargo;
        private Label lblDescCargo;
        private Button bttCancelar;
        private Button bttConfirmar;
    }
}