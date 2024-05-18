namespace Interface
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
            iconFechar = new PictureBox();
            lblNovaSenha = new Label();
            lblConfirmarSenha = new Label();
            lblTexto = new Label();
            bttAlterarSenha = new Button();
            panel1 = new Panel();
            picOlharSenha = new PictureBox();
            mskNovaSenha = new MaskedTextBox();
            mskConfirmarSenha = new MaskedTextBox();
            lblCaracteresMax = new Label();
            ((System.ComponentModel.ISupportInitialize)iconFechar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).BeginInit();
            SuspendLayout();
            // 
            // iconFechar
            // 
            iconFechar.AccessibleDescription = "Fechar";
            iconFechar.BackColor = Color.DarkOliveGreen;
            iconFechar.Image = (Image)resources.GetObject("iconFechar.Image");
            iconFechar.Location = new Point(627, 12);
            iconFechar.Name = "iconFechar";
            iconFechar.Size = new Size(20, 20);
            iconFechar.SizeMode = PictureBoxSizeMode.Zoom;
            iconFechar.TabIndex = 9;
            iconFechar.TabStop = false;
            iconFechar.Click += iconFechar_Click;
            iconFechar.MouseLeave += iconFechar_MouseLeave;
            iconFechar.MouseHover += iconFechar_MouseHover;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(200, 147);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(88, 20);
            lblNovaSenha.TabIndex = 12;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(174, 202);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(114, 20);
            lblConfirmarSenha.TabIndex = 13;
            lblConfirmarSenha.Text = "Confirme Senha";
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
            bttAlterarSenha.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bttAlterarSenha.Location = new Point(266, 282);
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
            panel1.Controls.Add(iconFechar);
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
            picOlharSenha.Location = new Point(438, 174);
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
            mskNovaSenha.Location = new Point(294, 144);
            mskNovaSenha.Name = "mskNovaSenha";
            mskNovaSenha.PasswordChar = '*';
            mskNovaSenha.Size = new Size(125, 27);
            mskNovaSenha.TabIndex = 18;
            // 
            // mskConfirmarSenha
            // 
            mskConfirmarSenha.Location = new Point(294, 199);
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
            lblCaracteresMax.Location = new Point(294, 231);
            lblCaracteresMax.Name = "lblCaracteresMax";
            lblCaracteresMax.Size = new Size(116, 15);
            lblCaracteresMax.TabIndex = 21;
            lblCaracteresMax.Text = "Máximo 8 caracteres";
            // 
            // RedefinirSenha2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(659, 379);
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
            ((System.ComponentModel.ISupportInitialize)iconFechar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconFechar;
        private Label lblNovaSenha;
        private Label lblConfirmarSenha;
        private Label lblTexto;
        private Button bttAlterarSenha;
        private Panel panel1;
        private PictureBox picOlharSenha;
        private MaskedTextBox mskNovaSenha;
        private MaskedTextBox mskConfirmarSenha;
        private Label lblCaracteresMax;
    }
}