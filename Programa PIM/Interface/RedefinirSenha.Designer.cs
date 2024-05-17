﻿
namespace Interface
{
    partial class RedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            txtEmail = new TextBox();
            txtPalavraChave = new TextBox();
            lblEmail = new Label();
            lblPalavraChave = new Label();
            label1 = new Label();
            lblTexto = new Label();
            picInfoPalavraChave = new PictureBox();
            picInfoEmail = new PictureBox();
            iconefechar = new PictureBox();
            bttConfirmar = new Button();
            panel1 = new Panel();
            panelicones = new Panel();
            iconemaximizar1 = new PictureBox();
            pictureBox1 = new PictureBox();
            iconeminimizar1 = new PictureBox();
            iconerestaurar1 = new PictureBox();
            lblEsqueciPalavraChave = new Label();
            ((System.ComponentModel.ISupportInitialize)picInfoPalavraChave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfoEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).BeginInit();
            panel1.SuspendLayout();
            panelicones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPalavraChave
            // 
            txtPalavraChave.Location = new Point(219, 226);
            txtPalavraChave.Name = "txtPalavraChave";
            txtPalavraChave.Size = new Size(300, 27);
            txtPalavraChave.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(167, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPalavraChave
            // 
            lblPalavraChave.AutoSize = true;
            lblPalavraChave.Location = new Point(63, 229);
            lblPalavraChave.Name = "lblPalavraChave";
            lblPalavraChave.Size = new Size(150, 20);
            lblPalavraChave.TabIndex = 3;
            lblPalavraChave.Text = "Palavra de Segurança";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 92);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.BackColor = Color.DarkOliveGreen;
            lblTexto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.Location = new Point(31, 31);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(183, 31);
            lblTexto.TabIndex = 5;
            lblTexto.Text = "Redefinir Senha";
            // 
            // picInfoPalavraChave
            // 
            picInfoPalavraChave.Image = (Image)resources.GetObject("picInfoPalavraChave.Image");
            picInfoPalavraChave.Location = new Point(525, 232);
            picInfoPalavraChave.Name = "picInfoPalavraChave";
            picInfoPalavraChave.Size = new Size(21, 21);
            picInfoPalavraChave.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoPalavraChave.TabIndex = 6;
            picInfoPalavraChave.TabStop = false;
            picInfoPalavraChave.Click += picInfoPalavraChave_Click;
            picInfoPalavraChave.MouseHover += picInfoEmail_MouseHover;
            // 
            // picInfoEmail
            // 
            picInfoEmail.Image = (Image)resources.GetObject("picInfoEmail.Image");
            picInfoEmail.Location = new Point(525, 169);
            picInfoEmail.Name = "picInfoEmail";
            picInfoEmail.Size = new Size(21, 21);
            picInfoEmail.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoEmail.TabIndex = 7;
            picInfoEmail.TabStop = false;
            picInfoEmail.MouseLeave += picInfoEmail_MouseLeave;
            picInfoEmail.MouseHover += picInfoEmail_MouseHover;
            // 
            // iconefechar
            // 
            iconefechar.BackColor = Color.DarkOliveGreen;
            iconefechar.Image = (Image)resources.GetObject("iconefechar.Image");
            iconefechar.Location = new Point(627, 12);
            iconefechar.Name = "iconefechar";
            iconefechar.Size = new Size(20, 20);
            iconefechar.SizeMode = PictureBoxSizeMode.Zoom;
            iconefechar.TabIndex = 8;
            iconefechar.TabStop = false;
            iconefechar.Click += iconefechar_Click;
            iconefechar.MouseHover += picInfoEmail_MouseHover;
            // 
            // bttConfirmar
            // 
            bttConfirmar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bttConfirmar.Location = new Point(266, 310);
            bttConfirmar.Name = "bttConfirmar";
            bttConfirmar.Size = new Size(126, 31);
            bttConfirmar.TabIndex = 9;
            bttConfirmar.Text = "Confirmar";
            bttConfirmar.UseVisualStyleBackColor = true;
            bttConfirmar.Click += bttConfirmar_Click;
            bttConfirmar.MouseHover += picInfoEmail_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(panelicones);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 100);
            panel1.TabIndex = 10;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Controls.Add(iconemaximizar1);
            panelicones.Controls.Add(pictureBox1);
            panelicones.Controls.Add(iconeminimizar1);
            panelicones.Controls.Add(iconerestaurar1);
            panelicones.Location = new Point(1310, 0);
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
            // lblEsqueciPalavraChave
            // 
            lblEsqueciPalavraChave.AutoSize = true;
            lblEsqueciPalavraChave.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsqueciPalavraChave.ForeColor = SystemColors.ControlDarkDark;
            lblEsqueciPalavraChave.Location = new Point(256, 256);
            lblEsqueciPalavraChave.Name = "lblEsqueciPalavraChave";
            lblEsqueciPalavraChave.Size = new Size(230, 19);
            lblEsqueciPalavraChave.TabIndex = 11;
            lblEsqueciPalavraChave.Text = "Esqueci minha Palavra de Segurança";
            lblEsqueciPalavraChave.Click += lblEsqueciPalavraChave_Click;
            // 
            // RedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(659, 379);
            ControlBox = false;
            Controls.Add(lblEsqueciPalavraChave);
            Controls.Add(bttConfirmar);
            Controls.Add(iconefechar);
            Controls.Add(picInfoEmail);
            Controls.Add(picInfoPalavraChave);
            Controls.Add(lblTexto);
            Controls.Add(label1);
            Controls.Add(lblPalavraChave);
            Controls.Add(lblEmail);
            Controls.Add(txtPalavraChave);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RedefinirSenha";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esqueceu Senha";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)picInfoPalavraChave).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfoEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).EndInit();
            panel1.ResumeLayout(false);
            panelicones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            String Email = "teste@gmail.com";
            String PalavraChave = "Teste";

            if (txtEmail.Text == Email & txtPalavraChave.Text == PalavraChave)
            {
                MessageBox.Show("Dados corretos!");
                RedefinirSenha2 RedefinirSenha2 = new RedefinirSenha2();
                RedefinirSenha2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou Palavra de Segurança incorretos!\n\nVerifique as letras maiúsculas ou minúsculas.");
            }
        }

        private void iconefechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.Show();
        }

        private void picInfoPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite a sua Palavra de Segurança que foi cadastrada no momento de criação da senha.");
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPalavraChave;
        private Label lblEmail;
        private Label lblPalavraChave;
        private Label label1;
        private Label lblTexto;
        private PictureBox picInfoPalavraChave;
        private PictureBox picInfoEmail;
        private PictureBox iconefechar;
        private Button bttConfirmar;
        private Panel panel1;
        private Panel panelicones;
        private PictureBox iconemaximizar1;
        private PictureBox pictureBox1;
        private PictureBox iconeminimizar1;
        private PictureBox iconerestaurar1;
        private Label lblEsqueciPalavraChave;
    }
}