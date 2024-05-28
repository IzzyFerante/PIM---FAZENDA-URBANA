
namespace Interface
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblUsuario = new Label();
            mskSenha = new MaskedTextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            bttAcessar = new Button();
            picOlharSenha = new PictureBox();
            iconFechar = new PictureBox();
            lblEsqueciSenha = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconFechar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-117, -59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(592, 599);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(481, 23);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(110, 46);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(634, 172);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 28);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário";
            // 
            // mskSenha
            // 
            mskSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskSenha.Location = new Point(729, 223);
            mskSenha.Name = "mskSenha";
            mskSenha.PasswordChar = '*';
            mskSenha.Size = new Size(125, 34);
            mskSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(729, 169);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 34);
            txtUsuario.TabIndex = 6;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.Location = new Point(648, 223);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(65, 28);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // bttAcessar
            // 
            bttAcessar.FlatStyle = FlatStyle.System;
            bttAcessar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bttAcessar.Location = new Point(745, 311);
            bttAcessar.Name = "bttAcessar";
            bttAcessar.Size = new Size(104, 43);
            bttAcessar.TabIndex = 8;
            bttAcessar.Text = "Acessar";
            bttAcessar.UseVisualStyleBackColor = true;
            bttAcessar.Click += bttAcessar_Click;
            bttAcessar.MouseLeave += bttAcessar_MouseLeave;
            bttAcessar.MouseHover += bttAcessar_MouseHover;
            // 
            // picOlharSenha
            // 
            picOlharSenha.Image = (Image)resources.GetObject("picOlharSenha.Image");
            picOlharSenha.InitialImage = (Image)resources.GetObject("picOlharSenha.InitialImage");
            picOlharSenha.Location = new Point(860, 232);
            picOlharSenha.Name = "picOlharSenha";
            picOlharSenha.Size = new Size(30, 20);
            picOlharSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picOlharSenha.TabIndex = 11;
            picOlharSenha.TabStop = false;
            picOlharSenha.MouseLeave += picOlharSenha_MouseLeave;
            picOlharSenha.MouseHover += picOlharSenha_MouseHover;
            // 
            // iconFechar
            // 
            iconFechar.Image = (Image)resources.GetObject("iconFechar.Image");
            iconFechar.Location = new Point(947, 12);
            iconFechar.Name = "iconFechar";
            iconFechar.Size = new Size(20, 20);
            iconFechar.SizeMode = PictureBoxSizeMode.Zoom;
            iconFechar.TabIndex = 12;
            iconFechar.TabStop = false;
            iconFechar.Click += iconFechar_Click;
            iconFechar.MouseLeave += iconFechar_MouseLeave;
            iconFechar.MouseHover += iconFechar_MouseHover;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsqueciSenha.ForeColor = SystemColors.ControlDarkDark;
            lblEsqueciSenha.Location = new Point(724, 263);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(136, 19);
            lblEsqueciSenha.TabIndex = 13;
            lblEsqueciSenha.Text = "Esqueci minha senha";
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            lblEsqueciSenha.MouseLeave += lblEsqueciSenha_MouseLeave;
            lblEsqueciSenha.MouseHover += lblEsqueciSenha_MouseHover;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 534);
            Controls.Add(lblEsqueciSenha);
            Controls.Add(iconFechar);
            Controls.Add(picOlharSenha);
            Controls.Add(bttAcessar);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(mskSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOlharSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label lblUsuario;
        private MaskedTextBox mskSenha;
        private TextBox txtUsuario;
        private Label lblSenha;
        private Button bttAcessar;
        private PictureBox picOlharSenha;
        private PictureBox iconFechar;
        private Label lblEsqueciSenha;
    }
}