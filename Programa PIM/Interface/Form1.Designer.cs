namespace teste01
{
    partial class Login_fms1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_fms1));
            this.Acesar_btn = new MetroFramework.Controls.MetroButton();
            this.Cancelar_txt = new MetroFramework.Controls.MetroButton();
            this.Usuario_txt = new MetroFramework.Controls.MetroTextBox();
            this.Senha_txt = new MetroFramework.Controls.MetroTextBox();
            this.Usuario_lb = new MetroFramework.Controls.MetroLabel();
            this.Senha_lbn = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Acesar_btn
            // 
            this.Acesar_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.Acesar_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.Acesar_btn, "Acesar_btn");
            this.Acesar_btn.Name = "Acesar_btn";
            this.Acesar_btn.UseSelectable = true;
            this.Acesar_btn.Click += new System.EventHandler(this.Acesar_btn_Click);
            // 
            // Cancelar_txt
            // 
            this.Cancelar_txt.BackColor = System.Drawing.Color.OliveDrab;
            this.Cancelar_txt.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.Cancelar_txt, "Cancelar_txt");
            this.Cancelar_txt.Name = "Cancelar_txt";
            this.Cancelar_txt.UseSelectable = true;
            this.Cancelar_txt.Click += new System.EventHandler(this.Cancelar_txt_Click);
            // 
            // Usuario_txt
            // 
            // 
            // 
            // 
            this.Usuario_txt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Usuario_txt.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.Usuario_txt.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.Usuario_txt.CustomButton.Name = "";
            this.Usuario_txt.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.Usuario_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Usuario_txt.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.Usuario_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Usuario_txt.CustomButton.UseSelectable = true;
            this.Usuario_txt.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.Usuario_txt.Lines = new string[0];
            resources.ApplyResources(this.Usuario_txt, "Usuario_txt");
            this.Usuario_txt.MaxLength = 32767;
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.PasswordChar = '\0';
            this.Usuario_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Usuario_txt.SelectedText = "";
            this.Usuario_txt.SelectionLength = 0;
            this.Usuario_txt.SelectionStart = 0;
            this.Usuario_txt.ShortcutsEnabled = true;
            this.Usuario_txt.UseSelectable = true;
            this.Usuario_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Usuario_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Senha_txt
            // 
            // 
            // 
            // 
            this.Senha_txt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Senha_txt.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.Senha_txt.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.Senha_txt.CustomButton.Name = "";
            this.Senha_txt.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.Senha_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Senha_txt.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.Senha_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Senha_txt.CustomButton.UseSelectable = true;
            this.Senha_txt.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.Senha_txt.Lines = new string[0];
            resources.ApplyResources(this.Senha_txt, "Senha_txt");
            this.Senha_txt.MaxLength = 32767;
            this.Senha_txt.Name = "Senha_txt";
            this.Senha_txt.PasswordChar = '\0';
            this.Senha_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Senha_txt.SelectedText = "";
            this.Senha_txt.SelectionLength = 0;
            this.Senha_txt.SelectionStart = 0;
            this.Senha_txt.ShortcutsEnabled = true;
            this.Senha_txt.UseSelectable = true;
            this.Senha_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Senha_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Senha_txt.Click += new System.EventHandler(this.Senha_txt_Click);
            // 
            // Usuario_lb
            // 
            resources.ApplyResources(this.Usuario_lb, "Usuario_lb");
            this.Usuario_lb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Usuario_lb.Name = "Usuario_lb";
            // 
            // Senha_lbn
            // 
            resources.ApplyResources(this.Senha_lbn, "Senha_lbn");
            this.Senha_lbn.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Senha_lbn.ForeColor = System.Drawing.Color.OliveDrab;
            this.Senha_lbn.Name = "Senha_lbn";
            this.Senha_lbn.Click += new System.EventHandler(this.Senha_lbn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::teste01.Properties.Resources.nao_sei;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Login_fms1
            // 
            resources.ApplyResources(this, "$this");
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Senha_lbn);
            this.Controls.Add(this.Usuario_lb);
            this.Controls.Add(this.Senha_txt);
            this.Controls.Add(this.Usuario_txt);
            this.Controls.Add(this.Cancelar_txt);
            this.Controls.Add(this.Acesar_btn);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Login_fms1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Login_btn;
        private MetroFramework.Controls.MetroButton Acesar_btn;
        private MetroFramework.Controls.MetroButton Cancelar_txt;
        private MetroFramework.Controls.MetroTextBox Usuario_txt;
        private MetroFramework.Controls.MetroTextBox Senha_txt;
        private MetroFramework.Controls.MetroLabel Usuario_lb;
        private MetroFramework.Controls.MetroLabel Senha_lbn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

