using Interface.View.Funcionarios;

namespace Interface.View.Produção.Tela_Extras.Area.Area_cad
{
    partial class AlterarArea_cad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarArea_cad));
            faixadaVerde = new Panel();
            bttFechar = new PictureBox();
            lblAlterarCategoria = new Label();
            panelicones = new Panel();
            lblCodCategoria = new Label();
            txtCodCategoria = new TextBox();
            txtDescCategoria = new TextBox();
            lblDescCategoria = new Label();
            bttCancelar = new Button();
            bttConfirmar = new Button();
            faixadaVerde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).BeginInit();
            SuspendLayout();
            // 
            // faixadaVerde
            // 
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttFechar);
            faixadaVerde.Controls.Add(lblAlterarCategoria);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Dock = DockStyle.Top;
            faixadaVerde.ImeMode = ImeMode.NoControl;
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(547, 70);
            faixadaVerde.TabIndex = 13;
            // 
            // bttFechar
            // 
            bttFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttFechar.Image = Properties.Resources.output_onlinepngtools__14_;
            bttFechar.Location = new Point(632, 12);
            bttFechar.Name = "bttFechar";
            bttFechar.Size = new Size(367, 0);
            bttFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bttFechar.TabIndex = 6;
            bttFechar.TabStop = false;
            // 
            // lblAlterarCategoria
            // 
            lblAlterarCategoria.AutoSize = true;
            lblAlterarCategoria.BackColor = Color.DarkOliveGreen;
            lblAlterarCategoria.FlatStyle = FlatStyle.System;
            lblAlterarCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlterarCategoria.ForeColor = SystemColors.ControlLightLight;
            lblAlterarCategoria.Location = new Point(26, 20);
            lblAlterarCategoria.Name = "lblAlterarCategoria";
            lblAlterarCategoria.Size = new Size(128, 28);
            lblAlterarCategoria.TabIndex = 0;
            lblAlterarCategoria.Text = "Alterar Área";
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(2402, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // lblCodCategoria
            // 
            lblCodCategoria.AutoSize = true;
            lblCodCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodCategoria.Location = new Point(46, 105);
            lblCodCategoria.Name = "lblCodCategoria";
            lblCodCategoria.Size = new Size(27, 23);
            lblCodCategoria.TabIndex = 14;
            lblCodCategoria.Text = "ID";
            // 
            // txtCodCategoria
            // 
            txtCodCategoria.Font = new Font("Microsoft YaHei UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodCategoria.Location = new Point(79, 102);
            txtCodCategoria.MaxLength = 5;
            txtCodCategoria.Name = "txtCodCategoria";
            txtCodCategoria.ReadOnly = true;
            txtCodCategoria.Size = new Size(61, 29);
            txtCodCategoria.TabIndex = 15;
            // 
            // txtDescCategoria
            // 
            txtDescCategoria.CharacterCasing = CharacterCasing.Upper;
            txtDescCategoria.Font = new Font("Microsoft YaHei UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescCategoria.Location = new Point(262, 102);
            txtDescCategoria.MaxLength = 35;
            txtDescCategoria.Name = "txtDescCategoria";
            txtDescCategoria.Size = new Size(240, 29);
            txtDescCategoria.TabIndex = 16;
            txtDescCategoria.KeyDown += txtDescCargo_KeyDown;
            txtDescCategoria.Leave += txtDescCargo_Leave;
            // 
            // lblDescCategoria
            // 
            lblDescCategoria.AutoSize = true;
            lblDescCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescCategoria.Location = new Point(199, 105);
            lblDescCategoria.Name = "lblDescCategoria";
            lblDescCategoria.Size = new Size(57, 23);
            lblDescCategoria.TabIndex = 17;
            lblDescCategoria.Text = "Nome";
            // 
            // bttCancelar
            // 
            bttCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttCancelar.Location = new Point(317, 156);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(94, 35);
            bttCancelar.TabIndex = 18;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            bttCancelar.Click += bttCancelar_Click;
            bttCancelar.MouseLeave += MouseLeave;
            bttCancelar.MouseHover += MouseHover;
            // 
            // bttConfirmar
            // 
            bttConfirmar.BackColor = Color.FromArgb(72, 44, 30);
            bttConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttConfirmar.ForeColor = Color.Snow;
            bttConfirmar.Location = new Point(425, 155);
            bttConfirmar.Name = "bttConfirmar";
            bttConfirmar.Size = new Size(94, 37);
            bttConfirmar.TabIndex = 19;
            bttConfirmar.Text = "Confirmar";
            bttConfirmar.UseVisualStyleBackColor = false;
            bttConfirmar.Click += bttConfirmar_Click;
            bttConfirmar.MouseLeave += MouseLeave;
            bttConfirmar.MouseHover += MouseHover;
            // 
            // AlterarArea_cad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(547, 199);
            Controls.Add(bttConfirmar);
            Controls.Add(bttCancelar);
            Controls.Add(lblDescCategoria);
            Controls.Add(txtDescCategoria);
            Controls.Add(txtCodCategoria);
            Controls.Add(lblCodCategoria);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AlterarArea_cad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarCargo";
            Load += AlterarCargo_Load;
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel faixadaVerde;
        private PictureBox bttFechar;
        private Label lblAlterarCategoria;
        private Panel panelicones;
        private Label lblCodCategoria;
        private TextBox txtCodCategoria;
        private TextBox txtDescCategoria;
        private Label lblDescCategoria;
        private Button bttCancelar;
        private Button bttConfirmar;
    }
}