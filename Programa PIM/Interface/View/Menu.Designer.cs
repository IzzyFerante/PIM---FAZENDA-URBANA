namespace Interface.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            picProdutos = new PictureBox();
            picVendas = new PictureBox();
            picFuncionario = new PictureBox();
            picClientes = new PictureBox();
            logotipo = new Label();
            panelicones = new Panel();
            picFornecedores = new PictureBox();
            faixadaVerde = new Panel();
            panel1 = new Panel();
            picMaximizar = new PictureBox();
            picFechar = new PictureBox();
            picMinimizar = new PictureBox();
            picRestaurar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFornecedores).BeginInit();
            faixadaVerde.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            SuspendLayout();
            // 
            // picProdutos
            // 
            picProdutos.Anchor = AnchorStyles.None;
            picProdutos.Image = Properties.Resources.produtos;
            picProdutos.Location = new Point(520, 680);
            picProdutos.Name = "picProdutos";
            picProdutos.Size = new Size(240, 240);
            picProdutos.SizeMode = PictureBoxSizeMode.Zoom;
            picProdutos.TabIndex = 23;
            picProdutos.TabStop = false;
            picProdutos.Click += picProdutos_Click;
            picProdutos.MouseLeave += picProdutos_MouseLeave;
            picProdutos.MouseHover += picProdutos_MouseHover;
            // 
            // picVendas
            // 
            picVendas.Anchor = AnchorStyles.None;
            picVendas.Image = Properties.Resources.vendas;
            picVendas.Location = new Point(1220, 680);
            picVendas.Name = "picVendas";
            picVendas.Size = new Size(240, 240);
            picVendas.SizeMode = PictureBoxSizeMode.Zoom;
            picVendas.TabIndex = 22;
            picVendas.TabStop = false;
            picVendas.Click += picVendas_Click;
            picVendas.MouseLeave += picVendas_MouseLeave;
            picVendas.MouseHover += picVendas_MouseHover;
            // 
            // picFuncionario
            // 
            picFuncionario.Anchor = AnchorStyles.None;
            picFuncionario.Image = Properties.Resources.funcionarios;
            picFuncionario.Location = new Point(200, 300);
            picFuncionario.Name = "picFuncionario";
            picFuncionario.Size = new Size(240, 240);
            picFuncionario.SizeMode = PictureBoxSizeMode.Zoom;
            picFuncionario.TabIndex = 21;
            picFuncionario.TabStop = false;
            picFuncionario.Click += picFuncionarios_Click;
            picFuncionario.MouseLeave += picFuncionario_MouseLeave;
            picFuncionario.MouseHover += picFuncionario_MouseHover;
            // 
            // picClientes
            // 
            picClientes.Anchor = AnchorStyles.None;
            picClientes.Image = Properties.Resources.clientes;
            picClientes.Location = new Point(1500, 300);
            picClientes.Name = "picClientes";
            picClientes.Size = new Size(240, 240);
            picClientes.SizeMode = PictureBoxSizeMode.Zoom;
            picClientes.TabIndex = 20;
            picClientes.TabStop = false;
            picClientes.Click += picClientes_Click;
            picClientes.MouseLeave += picClientes_MouseLeave;
            picClientes.MouseHover += picClientes_MouseHover;
            // 
            // logotipo
            // 
            logotipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logotipo.AutoSize = true;
            logotipo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            logotipo.Location = new Point(12, 50);
            logotipo.Name = "logotipo";
            logotipo.Size = new Size(271, 38);
            logotipo.TabIndex = 0;
            logotipo.Text = "UrbanFarm Manager";
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(2551, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // picFornecedores
            // 
            picFornecedores.Anchor = AnchorStyles.None;
            picFornecedores.Image = Properties.Resources.fornecedores;
            picFornecedores.Location = new Point(850, 300);
            picFornecedores.Name = "picFornecedores";
            picFornecedores.Size = new Size(240, 240);
            picFornecedores.SizeMode = PictureBoxSizeMode.Zoom;
            picFornecedores.TabIndex = 19;
            picFornecedores.TabStop = false;
            picFornecedores.Click += picFornecedores_Click;
            picFornecedores.MouseLeave += picFornecedores_MouseLeave;
            picFornecedores.MouseHover += picFornecedores_MouseHover;
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(panel1);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Controls.Add(logotipo);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(1900, 200);
            faixadaVerde.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(picMaximizar);
            panel1.Controls.Add(picFechar);
            panel1.Controls.Add(picMinimizar);
            panel1.Controls.Add(picRestaurar);
            panel1.Location = new Point(1769, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 40);
            panel1.TabIndex = 6;
            // 
            // picMaximizar
            // 
            picMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picMaximizar.Image = (Image)resources.GetObject("picMaximizar.Image");
            picMaximizar.Location = new Point(75, 10);
            picMaximizar.Name = "picMaximizar";
            picMaximizar.Size = new Size(20, 20);
            picMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMaximizar.TabIndex = 4;
            picMaximizar.TabStop = false;
            picMaximizar.Visible = false;
            picMaximizar.Click += picMaximizar_Click;
            picMaximizar.MouseLeave += picMaximizar_MouseLeave;
            picMaximizar.MouseHover += picMaximizar_MouseHover;
            // 
            // picFechar
            // 
            picFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picFechar.Image = (Image)resources.GetObject("picFechar.Image");
            picFechar.Location = new Point(101, 10);
            picFechar.Name = "picFechar";
            picFechar.Size = new Size(20, 20);
            picFechar.SizeMode = PictureBoxSizeMode.Zoom;
            picFechar.TabIndex = 1;
            picFechar.TabStop = false;
            picFechar.Click += picFechar_Click;
            picFechar.MouseLeave += picFechar_MouseLeave;
            picFechar.MouseHover += picFechar_MouseHover;
            // 
            // picMinimizar
            // 
            picMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(49, 10);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(20, 20);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 3;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            picMinimizar.MouseLeave += picMinimizar_MouseLeave;
            picMinimizar.MouseHover += picMinimizar_MouseHover;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(75, 10);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(20, 20);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 2;
            picRestaurar.TabStop = false;
            picRestaurar.Click += picRestaurar_Click;
            picRestaurar.MouseLeave += picRestaurar_MouseLeave;
            picRestaurar.MouseHover += picRestaurar_MouseHover;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1900, 1080);
            Controls.Add(picProdutos);
            Controls.Add(picVendas);
            Controls.Add(picFuncionario);
            Controls.Add(picClientes);
            Controls.Add(picFornecedores);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFuncionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFornecedores).EndInit();
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ResumeLayout(false);
        }

        /// 
        /// AÇÃO DO BOTÃO MAXIMIZAR
        /// 
        private void picMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition  = FormStartPosition.CenterScreen;

            //  Alterar os botões visiveis
            picRestaurar.Visible = true;
            picMaximizar.Visible = false;

            //  Redimensionar icones
            ClientSize = new Size(1920, 1080);
            faixadaVerde.Size = new Size(1920, 200);
            int newSize = Math.Max(this.ClientSize.Width, this.ClientSize.Height) / 8;
            ResizePictureBox(picFuncionario, newSize);
            ResizePictureBox(picFornecedores, newSize);
            ResizePictureBox(picClientes, newSize);
            ResizePictureBox(picProdutos, newSize);
            ResizePictureBox(picVendas, newSize);

            //  Colocar na localização na hora da redimensionação
            picFuncionario.Location = new Point(200, 300);
            picFornecedores.Location = new Point(850, 300);
            picClientes.Location = new Point(1500, 300);
            picProdutos.Location = new Point(520, 680);
            picVendas.Location = new Point(1220, 680);
        }


        #endregion
        private PictureBox picProdutos;
        private PictureBox picVendas;
        private PictureBox picFuncionario;
        private PictureBox picClientes;
        private Label logotipo;
        private PictureBox iconemaximizar1;
        private PictureBox iconefechar;
        private PictureBox iconeminimizar1;
        private PictureBox iconerestaurar1;
        private Panel panelicones;
        private PictureBox picFornecedores;
        private Panel faixadaVerde;
        private Panel panel1;
        private PictureBox picMaximizar;
        private PictureBox picFechar;
        private PictureBox picMinimizar;
        private PictureBox picRestaurar;
    }
}