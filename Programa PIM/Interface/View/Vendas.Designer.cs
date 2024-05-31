namespace Interface
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            panelicones = new Panel();
            iconemaximizar1 = new PictureBox();
            iconefechar = new PictureBox();
            iconeminimizar1 = new PictureBox();
            iconerestaurar1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            Icone_cliente = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            panelicones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_cliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Controls.Add(iconemaximizar1);
            panelicones.Controls.Add(iconefechar);
            panelicones.Controls.Add(iconeminimizar1);
            panelicones.Controls.Add(iconerestaurar1);
            panelicones.Location = new Point(852, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 6;
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
            // iconefechar
            // 
            iconefechar.Image = (Image)resources.GetObject("iconefechar.Image");
            iconefechar.Location = new Point(101, 10);
            iconefechar.Name = "iconefechar";
            iconefechar.Size = new Size(20, 20);
            iconefechar.SizeMode = PictureBoxSizeMode.Zoom;
            iconefechar.TabIndex = 1;
            iconefechar.TabStop = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(75, 38);
            label1.TabIndex = 7;
            label1.Text = "UFM";
            // 
            // panel1
            // 
            panel1.Location = new Point(979, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Icone_cliente);
            panel2.Controls.Add(panelicones);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 125);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(396, 84);
            label2.Name = "label2";
            label2.Size = new Size(123, 41);
            label2.TabIndex = 11;
            label2.Text = "Clientes";
            // 
            // Icone_cliente
            // 
            Icone_cliente.Image = (Image)resources.GetObject("Icone_cliente.Image");
            Icone_cliente.Location = new Point(898, 50);
            Icone_cliente.Name = "Icone_cliente";
            Icone_cliente.Size = new Size(75, 75);
            Icone_cliente.SizeMode = PictureBoxSizeMode.Zoom;
            Icone_cliente.TabIndex = 10;
            Icone_cliente.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(822, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 156);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 11;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(172, 188, 116);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(926, 274);
            dataGridView1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(327, 156);
            button2.Name = "button2";
            button2.Size = new Size(126, 47);
            button2.TabIndex = 13;
            button2.Text = "Incluir";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(170, 156);
            button3.Name = "button3";
            button3.Size = new Size(126, 47);
            button3.TabIndex = 14;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(815, 156);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 12;
            label3.Text = "Outras Opções";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(979, 572);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            panelicones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Icone_cliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelicones;
        private PictureBox iconemaximizar1;
        private PictureBox iconefechar;
        private PictureBox iconeminimizar1;
        private PictureBox iconerestaurar1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox Icone_cliente;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}