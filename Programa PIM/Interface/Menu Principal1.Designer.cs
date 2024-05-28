namespace Interface
{
    partial class Menu_Principal1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal1));
            panel1 = new Panel();
            panelicones = new Panel();
            iconemaximizar1 = new PictureBox();
            iconefechar = new PictureBox();
            iconeminimizar1 = new PictureBox();
            iconerestaurar1 = new PictureBox();
            label1 = new Label();
            Icone_fornecedor = new PictureBox();
            Icone_cliente = new PictureBox();
            Icone_funcionario = new PictureBox();
            Icone_vendas = new PictureBox();
            Icone_produtos = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            Clientes = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panelicones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_fornecedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_cliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_funcionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_vendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Icone_produtos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(panelicones);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 125);
            panel1.TabIndex = 0;
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Controls.Add(iconemaximizar1);
            panelicones.Controls.Add(iconefechar);
            panelicones.Controls.Add(iconeminimizar1);
            panelicones.Controls.Add(iconerestaurar1);
            panelicones.Location = new Point(851, 0);
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
            iconemaximizar1.Click += iconemaximizar1_Click;
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
            iconefechar.Click += iconefechar_Click;
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
            iconeminimizar1.Click += iconeminimizar1_Click;
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
            iconerestaurar1.Click += iconerestaurar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 0;
            label1.Text = "UrbanFarm Manager";
            // 
            // Icone_fornecedor
            // 
            Icone_fornecedor.Image = (Image)resources.GetObject("Icone_fornecedor.Image");
            Icone_fornecedor.Location = new Point(435, 44);
            Icone_fornecedor.Name = "Icone_fornecedor";
            Icone_fornecedor.Size = new Size(100, 105);
            Icone_fornecedor.SizeMode = PictureBoxSizeMode.Zoom;
            Icone_fornecedor.TabIndex = 1;
            Icone_fornecedor.TabStop = false;
            // 
            // Icone_cliente
            // 
            Icone_cliente.Image = (Image)resources.GetObject("Icone_cliente.Image");
            Icone_cliente.Location = new Point(710, 53);
            Icone_cliente.Name = "Icone_cliente";
            Icone_cliente.Size = new Size(100, 105);
            Icone_cliente.SizeMode = PictureBoxSizeMode.Zoom;
            Icone_cliente.TabIndex = 2;
            Icone_cliente.TabStop = false;
            // 
            // Icone_funcionario
            // 
            Icone_funcionario.Image = (Image)resources.GetObject("Icone_funcionario.Image");
            Icone_funcionario.Location = new Point(154, 44);
            Icone_funcionario.Name = "Icone_funcionario";
            Icone_funcionario.Size = new Size(100, 105);
            Icone_funcionario.SizeMode = PictureBoxSizeMode.Zoom;
            Icone_funcionario.TabIndex = 4;
            Icone_funcionario.TabStop = false;
            // 
            // Icone_vendas
            // 
            Icone_vendas.Image = (Image)resources.GetObject("Icone_vendas.Image");
            Icone_vendas.Location = new Point(580, 223);
            Icone_vendas.Name = "Icone_vendas";
            Icone_vendas.Size = new Size(100, 105);
            Icone_vendas.SizeMode = PictureBoxSizeMode.Zoom;
            Icone_vendas.TabIndex = 6;
            Icone_vendas.TabStop = false;
            // 
            // Icone_produtos
            // 
            Icone_produtos.Image = (Image)resources.GetObject("Icone_produtos.Image");
            Icone_produtos.Location = new Point(276, 223);
            Icone_produtos.Name = "Icone_produtos";
            Icone_produtos.Size = new Size(100, 105);
            Icone_produtos.SizeMode = PictureBoxSizeMode.Zoom;
            Icone_produtos.TabIndex = 7;
            Icone_produtos.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(148, 152);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 13;
            label2.Text = "Funcionarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(435, 152);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 14;
            label3.Text = "Fornecedores";
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Clientes.Location = new Point(725, 161);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(70, 23);
            Clientes.TabIndex = 15;
            Clientes.Text = "Clientes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(283, 328);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 16;
            label5.Text = "Produtos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(593, 328);
            label6.Name = "label6";
            label6.Size = new Size(65, 23);
            label6.TabIndex = 17;
            label6.Text = "Vendas";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(Icone_funcionario);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Clientes);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Icone_produtos);
            panel2.Controls.Add(Icone_vendas);
            panel2.Controls.Add(Icone_fornecedor);
            panel2.Controls.Add(Icone_cliente);
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 361);
            panel2.TabIndex = 18;
            // 
            // Menu_Principal1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 572);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Principal1";
            Text = "Menu_Principal1";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Principal1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelicones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconemaximizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconefechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeminimizar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconerestaurar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_fornecedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_cliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_funcionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_vendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)Icone_produtos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox iconefechar;
        private Label label1;
        private PictureBox iconemaximizar1;
        private PictureBox iconeminimizar1;
        private PictureBox iconerestaurar1;
        private Panel panelicones;
        private PictureBox Icone_fornecedor;
        private PictureBox Icone_cliente;
        private PictureBox Icone_funcionario;
        private PictureBox Icone_vendas;
        private PictureBox Icone_produtos;
        private Label label2;
        private Label label3;
        private Label Clientes;
        private Label label5;
        private Label label6;
        private Panel panel2;
    }
}