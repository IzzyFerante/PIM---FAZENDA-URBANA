namespace Interface
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            iconemaximizar = new PictureBox();
            iconefechar1 = new PictureBox();
            iconerestaurar = new PictureBox();
            iconeminimizar1 = new PictureBox();
            iconefechar = new PictureBox();
            iconetamnho = new PictureBox();
            iconeminimixar = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconemaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconetamnho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimixar).BeginInit();
            SuspendLayout();
         
            
            // 
            // panel3
            // 
            panel3.Controls.Add(iconemaximizar);
            panel3.Controls.Add(iconefechar1);
            panel3.Controls.Add(iconerestaurar);
            panel3.Controls.Add(iconeminimizar1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(115, 105);
            panel3.TabIndex = 6;
            // 
            // iconemaximizar
            // 
            iconemaximizar.BackColor = Color.DarkOliveGreen;
            iconemaximizar.Enabled = false;
            iconemaximizar.Image = (Image)resources.GetObject("iconemaximizar.Image");
            iconemaximizar.Location = new Point(67, 3);
            iconemaximizar.Name = "iconemaximizar";
            iconemaximizar.Size = new Size(20, 20);
            iconemaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconemaximizar.TabIndex = 5;
            iconemaximizar.TabStop = false;
            iconemaximizar.Click += iconemaximizar_Click;
            // 
            // iconefechar1
            // 
            iconefechar1.BackColor = Color.DarkOliveGreen;
            iconefechar1.Enabled = false;
            iconefechar1.Image = (Image)resources.GetObject("iconefechar1.Image");
            iconefechar1.Location = new Point(93, 3);
            iconefechar1.Name = "iconefechar1";
            iconefechar1.Size = new Size(20, 20);
            iconefechar1.SizeMode = PictureBoxSizeMode.Zoom;
            iconefechar1.TabIndex = 2;
            iconefechar1.TabStop = false;
            iconefechar1.Click += iconefechar1_Click;
            // 
            // iconerestaurar
            // 
            iconerestaurar.BackColor = Color.DarkOliveGreen;
            iconerestaurar.Enabled = false;
            iconerestaurar.Image = (Image)resources.GetObject("iconerestaurar.Image");
            iconerestaurar.Location = new Point(41, 3);
            iconerestaurar.Name = "iconerestaurar";
            iconerestaurar.Size = new Size(20, 20);
            iconerestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconerestaurar.TabIndex = 4;
            iconerestaurar.TabStop = false;
            iconerestaurar.Visible = false;
            iconerestaurar.Click += pictureBox2_Click;
            // 
            // iconeminimizar1
            // 
            iconeminimizar1.BackColor = Color.DarkOliveGreen;
            iconeminimizar1.Enabled = false;
            iconeminimizar1.Location = new Point(12, 3);
            iconeminimizar1.Name = "iconeminimizar1";
            iconeminimizar1.Size = new Size(20, 20);
            iconeminimizar1.SizeMode = PictureBoxSizeMode.Zoom;
            iconeminimizar1.TabIndex = 3;
            iconeminimizar1.TabStop = false;
            iconeminimizar1.Click += iconeminimizar1_Click;
            // 
            // iconefechar
            // 
            iconefechar.BackColor = Color.DarkOliveGreen;
            iconefechar.Enabled = false;
            iconefechar.Image = (Image)resources.GetObject("iconefechar.Image");
            iconefechar.Location = new Point(93, 3);
            iconefechar.Name = "iconefechar";
            iconefechar.Size = new Size(20, 20);
            iconefechar.SizeMode = PictureBoxSizeMode.Zoom;
            iconefechar.TabIndex = 2;
            iconefechar.TabStop = false;
            iconefechar.Click += pictureBox1_Click_1;
           
            // 
            // iconeminimixar
            // 
            iconeminimixar.BackColor = Color.DarkOliveGreen;
            iconeminimixar.Enabled = false;
            iconeminimixar.Image = (Image)resources.GetObject("iconeminimixar.Image");
            iconeminimixar.Location = new Point(21, 3);
            iconeminimixar.Name = "iconeminimixar";
            iconeminimixar.Size = new Size(20, 20);
            iconeminimixar.SizeMode = PictureBoxSizeMode.Zoom;
            iconeminimixar.TabIndex = 3;
            iconeminimixar.TabStop = false;
            iconeminimixar.Click += iconeminimixar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 0;
            label1.Text = "UrbanFarm Manager";
            label1.Click += label1_Click;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 473);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Principal";
            Text = "Menu_Principal";
            Load += Menu_Principal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconemaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconetamnho).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimixar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private PictureBox iconetamnho;
        private PictureBox iconeminimixar;
        private PictureBox iconefechar;
        private Panel panel1;
        private Panel panel3;
        private PictureBox iconemaximizar;
        private PictureBox iconefechar1;
        private PictureBox iconerestaurar;
        private PictureBox iconeminimizar1;
    }
}