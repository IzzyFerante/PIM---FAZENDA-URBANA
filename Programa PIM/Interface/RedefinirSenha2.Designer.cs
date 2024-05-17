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
            iconefechar = new PictureBox();
            lblNovaSenha = new Label();
            lblConfirmarSenha = new Label();
            lblTexto = new Label();
            bttAlterarSenha = new Button();
            panel1 = new Panel();
            panelicones = new Panel();
            iconemaximizar1 = new PictureBox();
            pictureBox1 = new PictureBox();
            iconeminimizar1 = new PictureBox();
            iconerestaurar1 = new PictureBox();
            picOlhaSenha = new PictureBox();
            mskNovaSenha = new MaskedTextBox();
            mskConfirmarSenha = new MaskedTextBox();
            lblCaracteresMax = new Label();
            ((System.ComponentModel.ISupportInitialize)iconefechar).BeginInit();
            panel1.SuspendLayout();
            panelicones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOlhaSenha).BeginInit();
            SuspendLayout();
            // 
            // iconefechar
            // 
            iconefechar.AccessibleDescription = "Fechar";
            iconefechar.BackColor = Color.DarkOliveGreen;
            iconefechar.Image = (Image)resources.GetObject("iconefechar.Image");
            iconefechar.Location = new Point(627, 12);
            iconefechar.Name = "iconefechar";
            iconefechar.Size = new Size(20, 20);
            iconefechar.SizeMode = PictureBoxSizeMode.Zoom;
            iconefechar.TabIndex = 9;
            iconefechar.TabStop = false;
            iconefechar.Click += iconefechar_Click;
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
            bttAlterarSenha.MouseHover += bttAlterarSenha_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(panelicones);
            panel1.Controls.Add(iconefechar);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 100);
            panel1.TabIndex = 16;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Controls.Add(iconemaximizar1);
            panelicones.Controls.Add(pictureBox1);
            panelicones.Controls.Add(iconeminimizar1);
            panelicones.Controls.Add(iconerestaurar1);
            panelicones.Location = new Point(1769, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // iconemaximizar1
            // 
            iconemaximizar1.Image = (Image)resources.GetObject("iconemaximizar1.Image");
            iconemaximizar1.Location = new Point(75, 10);
            iconemaximizar1.Name = "iconemaximizar1";
            iconemaximizar1.Size = new Size(20, 20);
            iconemaximizar1.SizeMode = PictureBoxSizeMode.Zoom;
            iconemaximizar1.TabIndex = 4;
            iconemaximizar1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // iconeminimizar1
            // 
            iconeminimizar1.Image = (Image)resources.GetObject("iconeminimizar1.Image");
            iconeminimizar1.Location = new Point(49, 10);
            iconeminimizar1.Name = "iconeminimizar1";
            iconeminimizar1.Size = new Size(20, 20);
            iconeminimizar1.SizeMode = PictureBoxSizeMode.Zoom;
            iconeminimizar1.TabIndex = 3;
            iconeminimizar1.TabStop = false;
            // 
            // iconerestaurar1
            // 
            iconerestaurar1.Image = (Image)resources.GetObject("iconerestaurar1.Image");
            iconerestaurar1.Location = new Point(75, 10);
            iconerestaurar1.Name = "iconerestaurar1";
            iconerestaurar1.Size = new Size(20, 20);
            iconerestaurar1.SizeMode = PictureBoxSizeMode.Zoom;
            iconerestaurar1.TabIndex = 2;
            iconerestaurar1.TabStop = false;
            iconerestaurar1.Visible = false;
            // 
            // picOlhaSenha
            // 
            picOlhaSenha.Image = (Image)resources.GetObject("picOlhaSenha.Image");
            picOlhaSenha.InitialImage = (Image)resources.GetObject("picOlhaSenha.InitialImage");
            picOlhaSenha.Location = new Point(438, 174);
            picOlhaSenha.Name = "picOlhaSenha";
            picOlhaSenha.Size = new Size(30, 20);
            picOlhaSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picOlhaSenha.TabIndex = 17;
            picOlhaSenha.TabStop = false;
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
            Controls.Add(picOlhaSenha);
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
            ((System.ComponentModel.ISupportInitialize)iconefechar).EndInit();
            panel1.ResumeLayout(false);
            panelicones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOlhaSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconefechar;
        private Label lblNovaSenha;
        private Label lblConfirmarSenha;
        private Label lblTexto;
        private Button bttAlterarSenha;
        private Panel panel1;
        private Panel panelicones;
        private PictureBox iconemaximizar1;
        private PictureBox pictureBox1;
        private PictureBox iconeminimizar1;
        private PictureBox iconerestaurar1;
        private PictureBox picOlhaSenha;
        private MaskedTextBox mskNovaSenha;
        private MaskedTextBox mskConfirmarSenha;
        private Label lblCaracteresMax;
    }
}