namespace Interface.View
{
    partial class RedefinirSenha2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha2));
            lblNovaSenha = new Label();
            lblConfirmarSenha = new Label();
            lblTexto = new Label();
            bttAlterarSenha = new Button();
            panel1 = new Panel();
            picOlharSenha = new PictureBox();
            mskNovaSenha = new MaskedTextBox();
            mskConfirmarSenha = new MaskedTextBox();
            lblCaracteresMax = new Label();
            picInfoEmail = new PictureBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            bttCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfoEmail).BeginInit();
            SuspendLayout();
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(200, 199);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(88, 20);
            lblNovaSenha.TabIndex = 12;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(135, 239);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(153, 20);
            lblConfirmarSenha.TabIndex = 13;
            lblConfirmarSenha.Text = "Confirme Nova Senha";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.BackColor = Color.DarkOliveGreen;
            lblTexto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.Location = new Point(31, 31);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(183, 31);
            lblTexto.TabIndex = 14;
            lblTexto.Text = "Redefinir Senha";
            // 
            // bttAlterarSenha
            // 
            bttAlterarSenha.FlatStyle = FlatStyle.System;
            bttAlterarSenha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bttAlterarSenha.Location = new Point(375, 310);
            bttAlterarSenha.Name = "bttAlterarSenha";
            bttAlterarSenha.Size = new Size(126, 31);
            bttAlterarSenha.TabIndex = 15;
            bttAlterarSenha.Text = "Alterar Senha";
            bttAlterarSenha.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 100);
            panel1.TabIndex = 16;
            // 
            // picOlharSenha
            // 
            picOlharSenha.Image = (Image)resources.GetObject("picOlharSenha.Image");
            picOlharSenha.InitialImage = (Image)resources.GetObject("picOlharSenha.InitialImage");
            picOlharSenha.Location = new Point(426, 220);
            picOlharSenha.Name = "picOlharSenha";
            picOlharSenha.Size = new Size(30, 20);
            picOlharSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picOlharSenha.TabIndex = 17;
            picOlharSenha.TabStop = false;
            // 
            // mskNovaSenha
            // 
            mskNovaSenha.Location = new Point(294, 196);
            mskNovaSenha.Name = "mskNovaSenha";
            mskNovaSenha.PasswordChar = '*';
            mskNovaSenha.Size = new Size(125, 27);
            mskNovaSenha.TabIndex = 18;
            // 
            // mskConfirmarSenha
            // 
            mskConfirmarSenha.Location = new Point(294, 236);
            mskConfirmarSenha.Name = "mskConfirmarSenha";
            mskConfirmarSenha.PasswordChar = '*';
            mskConfirmarSenha.Size = new Size(125, 27);
            mskConfirmarSenha.TabIndex = 19;
            // 
            // lblCaracteresMax
            // 
            lblCaracteresMax.AutoSize = true;
            lblCaracteresMax.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteresMax.ForeColor = SystemColors.ControlDarkDark;
            lblCaracteresMax.Location = new Point(294, 268);
            lblCaracteresMax.Name = "lblCaracteresMax";
            lblCaracteresMax.Size = new Size(116, 15);
            lblCaracteresMax.TabIndex = 21;
            lblCaracteresMax.Text = "Máximo 8 caracteres";
            // 
            // picInfoEmail
            // 
            picInfoEmail.Image = (Image)resources.GetObject("picInfoEmail.Image");
            picInfoEmail.Location = new Point(507, 144);
            picInfoEmail.Name = "picInfoEmail";
            picInfoEmail.Size = new Size(20, 20);
            picInfoEmail.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoEmail.TabIndex = 33;
            picInfoEmail.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(136, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 32;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(201, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 31;
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bttCancelar.Location = new Point(172, 311);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(126, 31);
            bttCancelar.TabIndex = 34;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            // 
            // RedefinirSenha2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(659, 379);
            Controls.Add(bttCancelar);
            Controls.Add(picInfoEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblCaracteresMax);
            Controls.Add(mskConfirmarSenha);
            Controls.Add(mskNovaSenha);
            Controls.Add(picOlharSenha);
            Controls.Add(bttAlterarSenha);
            Controls.Add(lblTexto);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblNovaSenha);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RedefinirSenha2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RedefinirSenha2";
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfoEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNovaSenha;
        private Label lblConfirmarSenha;
        private Label lblTexto;
        private Button bttAlterarSenha;
        private Panel panel1;
        private PictureBox picOlharSenha;
        private MaskedTextBox mskNovaSenha;
        private MaskedTextBox mskConfirmarSenha;
        private Label lblCaracteresMax;
        private PictureBox picInfoEmail;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button bttCancelar;
    }
}