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
            pictureBox1 = new PictureBox();
            picOlharSenha = new PictureBox();
            lblCaracteresMax = new Label();
            mskConfirmarSenha = new MaskedTextBox();
            mskNovaSenha = new MaskedTextBox();
            bttDefinirSenha = new Button();
            lblConfirmarSenha = new Label();
            lblNovaSenha = new Label();
            txtUsuario = new TextBox();
            bttCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).BeginInit();
            SuspendLayout();
            // 
            // lblPrimeiroAcesso
            // 
            lblPrimeiroAcesso.AutoSize = true;
            lblPrimeiroAcesso.BackColor = Color.DarkOliveGreen;
            lblPrimeiroAcesso.FlatStyle = FlatStyle.System;
            lblPrimeiroAcesso.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimeiroAcesso.Location = new Point(31, 31);
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
            panel1.Size = new Size(659, 100);
            panel1.TabIndex = 11;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(1769, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 467);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // picOlharSenha
            // 
            picOlharSenha.Image = (Image)resources.GetObject("picOlharSenha.Image");
            picOlharSenha.Location = new Point(426, 194);
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
            lblCaracteresMax.Location = new Point(294, 242);
            lblCaracteresMax.Name = "lblCaracteresMax";
            lblCaracteresMax.Size = new Size(116, 15);
            lblCaracteresMax.TabIndex = 27;
            lblCaracteresMax.Text = "Máximo 8 caracteres";
            // 
            // mskConfirmarSenha
            // 
            mskConfirmarSenha.Location = new Point(294, 210);
            mskConfirmarSenha.Name = "mskConfirmarSenha";
            mskConfirmarSenha.PasswordChar = '*';
            mskConfirmarSenha.Size = new Size(125, 27);
            mskConfirmarSenha.TabIndex = 26;
            // 
            // mskNovaSenha
            // 
            mskNovaSenha.Location = new Point(294, 170);
            mskNovaSenha.Name = "mskNovaSenha";
            mskNovaSenha.PasswordChar = '*';
            mskNovaSenha.Size = new Size(125, 27);
            mskNovaSenha.TabIndex = 25;
            // 
            // bttDefinirSenha
            // 
            bttDefinirSenha.FlatStyle = FlatStyle.System;
            bttDefinirSenha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bttDefinirSenha.Location = new Point(358, 292);
            bttDefinirSenha.Name = "bttDefinirSenha";
            bttDefinirSenha.Size = new Size(126, 31);
            bttDefinirSenha.TabIndex = 24;
            bttDefinirSenha.Text = "Definir Senha";
            bttDefinirSenha.UseVisualStyleBackColor = true;
            bttDefinirSenha.Click += bttDefinirSenha_Click;
            bttDefinirSenha.MouseLeave += iconFechar_MouseLeave;
            bttDefinirSenha.MouseHover += iconFechar_MouseHover;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(135, 213);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(153, 20);
            lblConfirmarSenha.TabIndex = 23;
            lblConfirmarSenha.Text = "Confirme Nova Senha";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(200, 173);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(88, 20);
            lblNovaSenha.TabIndex = 22;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(0, 359);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(10, 20);
            txtUsuario.TabIndex = 28;
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bttCancelar.Location = new Point(184, 292);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(126, 31);
            bttCancelar.TabIndex = 31;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            bttCancelar.Click += bttCancelar_Click;
            bttCancelar.MouseLeave += bttCancelar_MouseLeave;
            bttCancelar.MouseHover += bttCancelar_MouseHover;
            // 
            // PrimeiroAcesso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(659, 379);
            Controls.Add(bttCancelar);
            Controls.Add(txtUsuario);
            Controls.Add(lblCaracteresMax);
            Controls.Add(mskConfirmarSenha);
            Controls.Add(mskNovaSenha);
            Controls.Add(bttDefinirSenha);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblNovaSenha);
            Controls.Add(picOlharSenha);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrimeiroAcesso";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeiroAcesso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimeiroAcesso;
        private Panel panel1;
        private Panel panelicones;
        private PictureBox pictureBox1;
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
    }
}