
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
            label1 = new Label();
            label3 = new Label();
            senha_msk = new MaskedTextBox();
            Usuario_txt = new TextBox();
            label4 = new Label();
            acessar_btn = new Button();
            picOlhaSenha = new PictureBox();
            iconefechar = new PictureBox();
            lblEsqueceuSenha = new Label();
            lblEsqueciSenha = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOlhaSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(481, 23);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(634, 172);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 3;
            label3.Text = "Usuário";
            label3.Click += label3_Click;
            // 
            // senha_msk
            // 
            senha_msk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            senha_msk.Location = new Point(729, 223);
            senha_msk.Name = "senha_msk";
            senha_msk.PasswordChar = '*';
            senha_msk.Size = new Size(125, 34);
            senha_msk.TabIndex = 5;
            // 
            // Usuario_txt
            // 
            Usuario_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usuario_txt.Location = new Point(729, 169);
            Usuario_txt.Name = "Usuario_txt";
            Usuario_txt.Size = new Size(125, 34);
            Usuario_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(648, 223);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // acessar_btn
            // 
            acessar_btn.FlatStyle = FlatStyle.System;
            acessar_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acessar_btn.Location = new Point(745, 311);
            acessar_btn.Name = "acessar_btn";
            acessar_btn.Size = new Size(104, 43);
            acessar_btn.TabIndex = 8;
            acessar_btn.Text = "Acessar";
            acessar_btn.UseVisualStyleBackColor = true;
            acessar_btn.Click += button1_Click;
            acessar_btn.MouseLeave += acessar_btn_MouseLeave;
            acessar_btn.MouseHover += acessar_btn_MouseHover;
            // 
            // picOlhaSenha
            // 
            picOlhaSenha.Image = (Image)resources.GetObject("picOlhaSenha.Image");
            picOlhaSenha.InitialImage = (Image)resources.GetObject("picOlhaSenha.InitialImage");
            picOlhaSenha.Location = new Point(860, 232);
            picOlhaSenha.Name = "picOlhaSenha";
            picOlhaSenha.Size = new Size(30, 20);
            picOlhaSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picOlhaSenha.TabIndex = 11;
            picOlhaSenha.TabStop = false;
            picOlhaSenha.MouseLeave += picOlhaSenha_MouseLeave;
            picOlhaSenha.MouseHover += picOlhaSenha_MouseHover;
            // 
            // iconefechar
            // 
            iconefechar.Image = (Image)resources.GetObject("iconefechar.Image");
            iconefechar.Location = new Point(947, 12);
            iconefechar.Name = "iconefechar";
            iconefechar.Size = new Size(20, 20);
            iconefechar.SizeMode = PictureBoxSizeMode.Zoom;
            iconefechar.TabIndex = 12;
            iconefechar.TabStop = false;
            iconefechar.Click += iconefechar_Click;
            iconefechar.MouseLeave += iconefechar_MouseLeave;
            iconefechar.MouseHover += iconefechar_MouseHover;
            // 
            // lblEsqueceuSenha
            // 
            lblEsqueceuSenha.Location = new Point(0, 0);
            lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            lblEsqueceuSenha.Size = new Size(100, 23);
            lblEsqueceuSenha.TabIndex = 0;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsqueciSenha.Location = new Point(719, 265);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(146, 20);
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
            Controls.Add(lblEsqueceuSenha);
            Controls.Add(iconefechar);
            Controls.Add(picOlhaSenha);
            Controls.Add(acessar_btn);
            Controls.Add(label4);
            Controls.Add(Usuario_txt);
            Controls.Add(senha_msk);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOlhaSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private MaskedTextBox senha_msk;
        private TextBox Usuario_txt;
        private Label label4;
        private Button acessar_btn;
        private PictureBox picOlhaSenha;
        private PictureBox iconefechar;
        private Label lblEsqueceuSenha;
        private Label lblEsqueciSenha;
    }
}