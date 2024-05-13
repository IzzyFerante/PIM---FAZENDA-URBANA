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
            esqueceusnh_btn = new Button();
            cancelar_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(481, 23);
            label1.Name = "label1";
            label1.Size = new Size(103, 46);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(656, 167);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 3;
            label3.Text = "Usuário";
            label3.Click += label3_Click;
            // 
            // senha_msk
            // 
            senha_msk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            senha_msk.Location = new Point(751, 218);
            senha_msk.Name = "senha_msk";
            senha_msk.PasswordChar = '*';
            senha_msk.Size = new Size(125, 34);
            senha_msk.TabIndex = 5;
            // 
            // Usuario_txt
            // 
            Usuario_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usuario_txt.Location = new Point(751, 164);
            Usuario_txt.Name = "Usuario_txt";
            Usuario_txt.Size = new Size(125, 34);
            Usuario_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(670, 218);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // acessar_btn
            // 
            acessar_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acessar_btn.Location = new Point(772, 297);
            acessar_btn.Name = "acessar_btn";
            acessar_btn.Size = new Size(104, 43);
            acessar_btn.TabIndex = 8;
            acessar_btn.Text = "Acessar";
            acessar_btn.UseVisualStyleBackColor = true;
            acessar_btn.Click += button1_Click;
            // 
            // esqueceusnh_btn
            // 
            esqueceusnh_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            esqueceusnh_btn.Location = new Point(736, 496);
            esqueceusnh_btn.Name = "esqueceusnh_btn";
            esqueceusnh_btn.Size = new Size(183, 26);
            esqueceusnh_btn.TabIndex = 9;
            esqueceusnh_btn.Text = "Esqueci minha senha?";
            esqueceusnh_btn.UseVisualStyleBackColor = true;
            esqueceusnh_btn.Click += esqueceusnh_btn_Click;
            // 
            // cancelar_btn
            // 
            cancelar_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancelar_btn.Location = new Point(772, 357);
            cancelar_btn.Name = "cancelar_btn";
            cancelar_btn.Size = new Size(104, 43);
            cancelar_btn.TabIndex = 10;
            cancelar_btn.Text = "Cancelar";
            cancelar_btn.UseVisualStyleBackColor = true;
            cancelar_btn.Click += cancelar_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 534);
            Controls.Add(cancelar_btn);
            Controls.Add(esqueceusnh_btn);
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
        private Button esqueceusnh_btn;
        private Button cancelar_btn;
    }
}