namespace Interface.View
{
    partial class PrimeiroAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeiroAcesso));
            lblPrimeiroAcesso = new Label();
            panel1 = new Panel();
            panelicones = new Panel();
            picOlharSenha = new PictureBox();
            lblCaracteresMax = new Label();
            mskConfirmarSenha = new MaskedTextBox();
            mskNovaSenha = new MaskedTextBox();
            bttDefinirSenha = new Button();
            lblConfirmarSenha = new Label();
            lblNovaSenha = new Label();
            txtUsuario = new TextBox();
            bttCancelar = new Button();
            lblPalavraChave = new Label();
            txtPalavraChave = new TextBox();
            picInfoPalavraChave = new PictureBox();
            label1 = new Label();
            txtDicaSenha = new TextBox();
            lblDicaSenha = new Label();
            picInfoDicaSenha = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfoPalavraChave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfoDicaSenha).BeginInit();
            SuspendLayout();
            // 
            // lblPrimeiroAcesso
            // 
            lblPrimeiroAcesso.AutoSize = true;
            lblPrimeiroAcesso.BackColor = Color.DarkOliveGreen;
            lblPrimeiroAcesso.FlatStyle = FlatStyle.System;
            lblPrimeiroAcesso.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimeiroAcesso.Location = new Point(28, 31);
            lblPrimeiroAcesso.Name = "lblPrimeiroAcesso";
            lblPrimeiroAcesso.Size = new Size(186, 31);
            lblPrimeiroAcesso.TabIndex = 0;
            lblPrimeiroAcesso.Text = "Primeiro Acesso";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(lblPrimeiroAcesso);
            panel1.Controls.Add(panelicones);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 100);
            panel1.TabIndex = 11;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(1591, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // picOlharSenha
            // 
            picOlharSenha.Image = (Image)resources.GetObject("picOlharSenha.Image");
            picOlharSenha.Location = new Point(368, 253);
            picOlharSenha.Name = "picOlharSenha";
            picOlharSenha.Size = new Size(30, 20);
            picOlharSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picOlharSenha.TabIndex = 18;
            picOlharSenha.TabStop = false;
            picOlharSenha.MouseLeave += picOlharSenha_MouseLeave;
            picOlharSenha.MouseHover += picOlharSenha_MouseHover;
            // 
            // lblCaracteresMax
            // 
            lblCaracteresMax.AutoSize = true;
            lblCaracteresMax.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteresMax.ForeColor = SystemColors.ControlDarkDark;
            lblCaracteresMax.Location = new Point(236, 301);
            lblCaracteresMax.Name = "lblCaracteresMax";
            lblCaracteresMax.Size = new Size(119, 15);
            lblCaracteresMax.TabIndex = 27;
            lblCaracteresMax.Text = "*Mínimo 4 caracteres";
            // 
            // mskConfirmarSenha
            // 
            mskConfirmarSenha.Location = new Point(236, 269);
            mskConfirmarSenha.Name = "mskConfirmarSenha";
            mskConfirmarSenha.PasswordChar = '*';
            mskConfirmarSenha.Size = new Size(125, 27);
            mskConfirmarSenha.TabIndex = 26;
            mskConfirmarSenha.KeyDown += mskConfirmarSenha_KeyDown;
            // 
            // mskNovaSenha
            // 
            mskNovaSenha.Location = new Point(236, 229);
            mskNovaSenha.Name = "mskNovaSenha";
            mskNovaSenha.PasswordChar = '*';
            mskNovaSenha.Size = new Size(125, 27);
            mskNovaSenha.TabIndex = 25;
            mskNovaSenha.KeyDown += mskNovaSenha_KeyDown;
            // 
            // bttDefinirSenha
            // 
            bttDefinirSenha.FlatStyle = FlatStyle.System;
            bttDefinirSenha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bttDefinirSenha.Location = new Point(273, 450);
            bttDefinirSenha.Name = "bttDefinirSenha";
            bttDefinirSenha.Size = new Size(126, 31);
            bttDefinirSenha.TabIndex = 24;
            bttDefinirSenha.Text = "Definir Senha";
            bttDefinirSenha.UseVisualStyleBackColor = true;
            bttDefinirSenha.Click += bttDefinirSenha_Click;
            bttDefinirSenha.MouseLeave += bttDefinirSenha_MouseLeave;
            bttDefinirSenha.MouseHover += bttDefinirSenha_MouseHover;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(77, 272);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(153, 20);
            lblConfirmarSenha.TabIndex = 23;
            lblConfirmarSenha.Text = "Confirme Nova Senha";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(142, 232);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(88, 20);
            lblNovaSenha.TabIndex = 22;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.ControlLightLight;
            txtUsuario.Location = new Point(649, 374);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(10, 5);
            txtUsuario.TabIndex = 36;
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bttCancelar.Location = new Point(99, 450);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(126, 31);
            bttCancelar.TabIndex = 31;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            bttCancelar.Click += bttCancelar_Click;
            bttCancelar.MouseLeave += bttCancelar_MouseLeave;
            bttCancelar.MouseHover += bttCancelar_MouseHover;
            // 
            // lblPalavraChave
            // 
            lblPalavraChave.AutoSize = true;
            lblPalavraChave.Location = new Point(55, 148);
            lblPalavraChave.Name = "lblPalavraChave";
            lblPalavraChave.Size = new Size(150, 20);
            lblPalavraChave.TabIndex = 32;
            lblPalavraChave.Text = "Palavra de Segurança";
            // 
            // txtPalavraChave
            // 
            txtPalavraChave.Location = new Point(214, 144);
            txtPalavraChave.MaxLength = 25;
            txtPalavraChave.Name = "txtPalavraChave";
            txtPalavraChave.Size = new Size(170, 27);
            txtPalavraChave.TabIndex = 33;
            txtPalavraChave.KeyDown += mskConfirmarSenha_KeyDown;
            // 
            // picInfoPalavraChave
            // 
            picInfoPalavraChave.Image = Properties.Resources.interrogation_3916712;
            picInfoPalavraChave.Location = new Point(390, 148);
            picInfoPalavraChave.Name = "picInfoPalavraChave";
            picInfoPalavraChave.Size = new Size(20, 20);
            picInfoPalavraChave.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoPalavraChave.TabIndex = 34;
            picInfoPalavraChave.TabStop = false;
            picInfoPalavraChave.Click += picInfoPalavraChave_Click;
            picInfoPalavraChave.MouseLeave += picInfoPalavraChave_MouseLeave;
            picInfoPalavraChave.MouseHover += picInfoPalavraChave_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(236, 319);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 35;
            label1.Text = "*Máximo 11 caracteres";
            // 
            // txtDicaSenha
            // 
            txtDicaSenha.Location = new Point(143, 376);
            txtDicaSenha.MaxLength = 30;
            txtDicaSenha.Name = "txtDicaSenha";
            txtDicaSenha.Size = new Size(282, 27);
            txtDicaSenha.TabIndex = 37;
            txtDicaSenha.KeyDown += mskConfirmarSenha_KeyDown;
            // 
            // lblDicaSenha
            // 
            lblDicaSenha.AutoSize = true;
            lblDicaSenha.Location = new Point(32, 379);
            lblDicaSenha.Name = "lblDicaSenha";
            lblDicaSenha.Size = new Size(104, 20);
            lblDicaSenha.TabIndex = 38;
            lblDicaSenha.Text = "Dica da Senha";
            // 
            // picInfoDicaSenha
            // 
            picInfoDicaSenha.Image = Properties.Resources.interrogation_3916712;
            picInfoDicaSenha.Location = new Point(431, 379);
            picInfoDicaSenha.Name = "picInfoDicaSenha";
            picInfoDicaSenha.Size = new Size(20, 20);
            picInfoDicaSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoDicaSenha.TabIndex = 39;
            picInfoDicaSenha.TabStop = false;
            picInfoDicaSenha.Click += picInfoDicaSenha_Click;
            picInfoDicaSenha.MouseLeave += picInfoDicaSenha_MouseLeave;
            picInfoDicaSenha.MouseHover += picInfoDicaSenha_MouseHover;
            // 
            // PrimeiroAcesso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(481, 524);
            Controls.Add(picInfoDicaSenha);
            Controls.Add(lblDicaSenha);
            Controls.Add(txtDicaSenha);
            Controls.Add(label1);
            Controls.Add(picInfoPalavraChave);
            Controls.Add(txtPalavraChave);
            Controls.Add(lblPalavraChave);
            Controls.Add(bttCancelar);
            Controls.Add(txtUsuario);
            Controls.Add(lblCaracteresMax);
            Controls.Add(mskConfirmarSenha);
            Controls.Add(mskNovaSenha);
            Controls.Add(bttDefinirSenha);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblNovaSenha);
            Controls.Add(picOlharSenha);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrimeiroAcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeiroAcesso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfoPalavraChave).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfoDicaSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimeiroAcesso;
        private Panel panel1;
        private Panel panelicones;
        private PictureBox picOlharSenha;
        private Label lblCaracteresMax;
        private MaskedTextBox mskConfirmarSenha;
        private MaskedTextBox mskNovaSenha;
        private Button bttDefinirSenha;
        private Label lblConfirmarSenha;
        private Label lblNovaSenha;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private PictureBox picInfoUsuario;
        private Button bttCancelar;
        private Label lblPalavraChave;
        private TextBox txtPalavraChave;
        private PictureBox picInfoPalavraChave;
        private Label label1;
        private TextBox txtDicaSenha;
        private Label lblDicaSenha;
        private PictureBox picInfoDicaSenha;
    }
}