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
            picVoltar = new PictureBox();
            picOlharSenha = new PictureBox();
            mskNovaSenha = new MaskedTextBox();
            mskConfirmarSenha = new MaskedTextBox();
            lblCaracteresMax = new Label();
            txtEmail = new TextBox();
            bttCancelar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).BeginInit();
            SuspendLayout();
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(213, 174);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(88, 20);
            lblNovaSenha.TabIndex = 12;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(148, 214);
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
            bttAlterarSenha.Click += bttAlterarSenha_Click;
            bttAlterarSenha.MouseLeave += bttAlterarSenha_MouseLeave;
            bttAlterarSenha.MouseHover += bttAlterarSenha_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(picVoltar);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 100);
            panel1.TabIndex = 16;
            // 
            // picVoltar
            // 
            picVoltar.Image = (Image)resources.GetObject("picVoltar.Image");
            picVoltar.Location = new Point(7, 6);
            picVoltar.Name = "picVoltar";
            picVoltar.Size = new Size(23, 20);
            picVoltar.SizeMode = PictureBoxSizeMode.Zoom;
            picVoltar.TabIndex = 0;
            picVoltar.TabStop = false;
            picVoltar.Click += picVoltar_Click;
            picVoltar.MouseLeave += picVoltar_MouseLeave;
            picVoltar.MouseHover += picVoltar_MouseHover;
            // 
            // picOlharSenha
            // 
            picOlharSenha.Image = (Image)resources.GetObject("picOlharSenha.Image");
            picOlharSenha.InitialImage = (Image)resources.GetObject("picOlharSenha.InitialImage");
            picOlharSenha.Location = new Point(439, 195);
            picOlharSenha.Name = "picOlharSenha";
            picOlharSenha.Size = new Size(30, 20);
            picOlharSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picOlharSenha.TabIndex = 17;
            picOlharSenha.TabStop = false;
            picOlharSenha.MouseLeave += picOlharSenha_MouseLeave;
            picOlharSenha.MouseHover += picOlharSenha_MouseHover;
            // 
            // mskNovaSenha
            // 
            mskNovaSenha.Location = new Point(307, 171);
            mskNovaSenha.Name = "mskNovaSenha";
            mskNovaSenha.PasswordChar = '*';
            mskNovaSenha.Size = new Size(125, 27);
            mskNovaSenha.TabIndex = 18;
            mskNovaSenha.KeyDown += mskNovaSenha_KeyDown;
            // 
            // mskConfirmarSenha
            // 
            mskConfirmarSenha.Location = new Point(307, 211);
            mskConfirmarSenha.Name = "mskConfirmarSenha";
            mskConfirmarSenha.PasswordChar = '*';
            mskConfirmarSenha.Size = new Size(125, 27);
            mskConfirmarSenha.TabIndex = 19;
            mskConfirmarSenha.KeyDown += mskConfirmarSenha_KeyDown;
            // 
            // lblCaracteresMax
            // 
            lblCaracteresMax.AutoSize = true;
            lblCaracteresMax.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracteresMax.ForeColor = SystemColors.ControlDarkDark;
            lblCaracteresMax.Location = new Point(307, 243);
            lblCaracteresMax.Name = "lblCaracteresMax";
            lblCaracteresMax.Size = new Size(119, 15);
            lblCaracteresMax.TabIndex = 21;
            lblCaracteresMax.Text = "*Mínimo 4 caracteres";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = SystemColors.ControlLightLight;
            txtEmail.Location = new Point(0, 358);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(10, 20);
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
            bttCancelar.Click += bttCancelar_Click;
            bttCancelar.MouseLeave += bttCancelar_MouseLeave;
            bttCancelar.MouseHover += bttCancelar_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(307, 260);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 35;
            label1.Text = "*Máximo 11 caracteres";
            // 
            // RedefinirSenha2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(659, 379);
            Controls.Add(label1);
            Controls.Add(bttCancelar);
            Controls.Add(lblCaracteresMax);
            Controls.Add(mskConfirmarSenha);
            Controls.Add(mskNovaSenha);
            Controls.Add(picOlharSenha);
            Controls.Add(bttAlterarSenha);
            Controls.Add(lblTexto);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblNovaSenha);
            Controls.Add(panel1);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RedefinirSenha2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RedefinirSenha2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).EndInit();
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
        private TextBox txtEmail;
        private Button bttCancelar;
        private PictureBox picVoltar;
        private Label label1;
    }
}