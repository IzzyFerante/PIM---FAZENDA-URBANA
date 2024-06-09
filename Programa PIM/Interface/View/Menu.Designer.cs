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
            panelicones = new Panel();
            picFornecedores = new PictureBox();
            faixadaVerde = new Panel();
            panel2 = new Panel();
            lblUsuario = new Label();
            picDeslogar = new PictureBox();
            lblUsuarioAtivo = new Label();
            panel1 = new Panel();
            picMaximizar = new PictureBox();
            picFechar = new PictureBox();
            picMinimizar = new PictureBox();
            picRestaurar = new PictureBox();
            picLogo = new PictureBox();
            picIA = new PictureBox();
            picProducao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFornecedores).BeginInit();
            faixadaVerde.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDeslogar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProducao).BeginInit();
            SuspendLayout();
            // 
            // picProdutos
            // 
            picProdutos.Anchor = AnchorStyles.None;
            picProdutos.Image = Properties.Resources.produtos_menu1;
            picProdutos.Location = new Point(200, 680);
            picProdutos.Name = "picProdutos";
            picProdutos.Size = new Size(240, 240);
            picProdutos.SizeMode = PictureBoxSizeMode.Zoom;
            picProdutos.TabIndex = 23;
            picProdutos.TabStop = false;
            picProdutos.Click += picProdutos_Click;
            picProdutos.MouseLeave += MouseLeave;
            picProdutos.MouseHover += MouseHover;
            // 
            // picVendas
            // 
            picVendas.Anchor = AnchorStyles.None;
            picVendas.Image = Properties.Resources.vendas;
            picVendas.Location = new Point(1500, 680);
            picVendas.Name = "picVendas";
            picVendas.Size = new Size(240, 240);
            picVendas.SizeMode = PictureBoxSizeMode.Zoom;
            picVendas.TabIndex = 22;
            picVendas.TabStop = false;
            picVendas.Click += picVendas_Click;
            picVendas.MouseLeave += MouseLeave;
            picVendas.MouseHover += MouseHover;
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
            picFuncionario.MouseLeave += MouseLeave;
            picFuncionario.MouseHover += MouseHover;
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
            picClientes.MouseLeave += MouseLeave;
            picClientes.MouseHover += MouseHover;
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
            picFornecedores.MouseLeave += MouseLeave;
            picFornecedores.MouseHover += MouseHover;
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(panel2);
            faixadaVerde.Controls.Add(panel1);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Controls.Add(picLogo);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(1900, 200);
            faixadaVerde.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(picDeslogar);
            panel2.Controls.Add(lblUsuarioAtivo);
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 59);
            panel2.TabIndex = 11;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(47, 24);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 23);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuário:";
            // 
            // picDeslogar
            // 
            picDeslogar.Image = Properties.Resources.output_onlinepngtools__11_;
            picDeslogar.Location = new Point(12, 12);
            picDeslogar.Name = "picDeslogar";
            picDeslogar.Size = new Size(29, 35);
            picDeslogar.SizeMode = PictureBoxSizeMode.Zoom;
            picDeslogar.TabIndex = 8;
            picDeslogar.TabStop = false;
            picDeslogar.Click += picDeslogar_Click;
            picDeslogar.MouseLeave += MouseLeave;
            picDeslogar.MouseHover += MouseHover;
            // 
            // lblUsuarioAtivo
            // 
            lblUsuarioAtivo.AutoSize = true;
            lblUsuarioAtivo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioAtivo.ForeColor = SystemColors.ControlLightLight;
            lblUsuarioAtivo.Location = new Point(119, 24);
            lblUsuarioAtivo.Name = "lblUsuarioAtivo";
            lblUsuarioAtivo.RightToLeft = RightToLeft.Yes;
            lblUsuarioAtivo.Size = new Size(53, 23);
            lblUsuarioAtivo.TabIndex = 7;
            lblUsuarioAtivo.Text = "label1";
            lblUsuarioAtivo.TextAlign = ContentAlignment.MiddleRight;
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
            picMaximizar.Image = Properties.Resources.output_onlinepngtools__18_;
            picMaximizar.Location = new Point(75, 10);
            picMaximizar.Name = "picMaximizar";
            picMaximizar.Size = new Size(20, 20);
            picMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMaximizar.TabIndex = 4;
            picMaximizar.TabStop = false;
            picMaximizar.Visible = false;
            picMaximizar.Click += picMaximizar_Click;
            picMaximizar.MouseLeave += MouseLeave;
            picMaximizar.MouseHover += MouseHover;
            // 
            // picFechar
            // 
            picFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picFechar.Image = Properties.Resources.output_onlinepngtools__14_;
            picFechar.Location = new Point(101, 10);
            picFechar.Name = "picFechar";
            picFechar.Size = new Size(20, 20);
            picFechar.SizeMode = PictureBoxSizeMode.Zoom;
            picFechar.TabIndex = 1;
            picFechar.TabStop = false;
            picFechar.Click += picFechar_Click;
            picFechar.MouseLeave += MouseLeave;
            picFechar.MouseHover += MouseHover;
            // 
            // picMinimizar
            // 
            picMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picMinimizar.Image = Properties.Resources.output_onlinepngtools__17_;
            picMinimizar.Location = new Point(49, 10);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(20, 20);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 3;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            picMinimizar.MouseLeave += MouseLeave;
            picMinimizar.MouseHover += MouseHover;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picRestaurar.Image = Properties.Resources.output_onlinepngtools__15_;
            picRestaurar.Location = new Point(75, 10);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(20, 20);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 2;
            picRestaurar.TabStop = false;
            picRestaurar.Click += picRestaurar_Click;
            picRestaurar.MouseLeave += MouseLeave;
            picRestaurar.MouseHover += MouseHover;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.output_onlinepngtools__25_;
            picLogo.Location = new Point(756, 13);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(451, 177);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 10;
            picLogo.TabStop = false;
            // 
            // picIA
            // 
            picIA.Image = Properties.Resources.IA_removebg_preview1;
            picIA.Location = new Point(1808, 980);
            picIA.Name = "picIA";
            picIA.Size = new Size(80, 80);
            picIA.SizeMode = PictureBoxSizeMode.Zoom;
            picIA.TabIndex = 24;
            picIA.TabStop = false;
            picIA.Click += picIA_Click;
            picIA.MouseLeave += MouseLeave;
            picIA.MouseHover += MouseHover;
            // 
            // picProducao
            // 
            picProducao.Anchor = AnchorStyles.None;
            picProducao.Image = Properties.Resources.output_onlinepngtools__12_1;
            picProducao.Location = new Point(850, 685);
            picProducao.Name = "picProducao";
            picProducao.Size = new Size(240, 240);
            picProducao.SizeMode = PictureBoxSizeMode.Zoom;
            picProducao.TabIndex = 25;
            picProducao.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1900, 1080);
            Controls.Add(picProducao);
            Controls.Add(picIA);
            Controls.Add(picProdutos);
            Controls.Add(picVendas);
            Controls.Add(picFuncionario);
            Controls.Add(picClientes);
            Controls.Add(picFornecedores);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDeslogar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProducao).EndInit();
            ResumeLayout(false);
        }

        /// 
        /// AÇÃO DO BOTÃO MAXIMIZAR
        /* 
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
        }*/


        #endregion
        private PictureBox picProdutos;
        private PictureBox picVendas;
        private PictureBox picFuncionario;
        private PictureBox picClientes;
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
        private Label lblUsuarioAtivo;
        private PictureBox picDeslogar;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private PictureBox picLogo;
        private PictureBox picIA;
        private PictureBox picProducao;
        private Panel panel2;
    }
}