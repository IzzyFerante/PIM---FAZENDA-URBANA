﻿using Interface.View.Funcionarios;

namespace Interface.View.Produção.Tela_Extras.Area.Area_cad
{
    partial class TelaArea_cad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaArea_cad));
            faixadaVerde = new Panel();
            bttFechar = new PictureBox();
            lblCargo = new Label();
            panelicones = new Panel();
            dataGridCargos = new DataGridView();
            bttIncluir = new Button();
            bttAlterar = new Button();
            bttSelecionar = new Button();
            bttBuscar = new Button();
            picFiltroBuscar = new Button();
            checkListBusca = new CheckedListBox();
            lblPesquisa = new Label();
            txtPesquisa = new TextBox();
            faixadaVerde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCargos).BeginInit();
            SuspendLayout();
            // 
            // faixadaVerde
            // 
            faixadaVerde.BackColor = Color.DarkOliveGreen;
            faixadaVerde.Controls.Add(bttFechar);
            faixadaVerde.Controls.Add(lblCargo);
            faixadaVerde.Controls.Add(panelicones);
            faixadaVerde.Dock = DockStyle.Top;
            faixadaVerde.ImeMode = ImeMode.NoControl;
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(664, 100);
            faixadaVerde.TabIndex = 12;
            // 
            // bttFechar
            // 
            bttFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bttFechar.Image = Properties.Resources.output_onlinepngtools__14_;
            bttFechar.Location = new Point(632, 12);
            bttFechar.Name = "bttFechar";
            bttFechar.Size = new Size(20, 20);
            bttFechar.SizeMode = PictureBoxSizeMode.Zoom;
            bttFechar.TabIndex = 6;
            bttFechar.TabStop = false;
            bttFechar.Click += bttFechar_Click;
            bttFechar.MouseLeave += bttBuscar_MouseLeave;
            bttFechar.MouseHover += bttBuscar_MouseHover;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.BackColor = Color.DarkOliveGreen;
            lblCargo.FlatStyle = FlatStyle.System;
            lblCargo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(28, 31);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(63, 31);
            lblCargo.TabIndex = 0;
            lblCargo.Text = "Área";
            // 
            // panelicones
            // 
            panelicones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelicones.AutoScroll = true;
            panelicones.Location = new Point(2055, 0);
            panelicones.Name = "panelicones";
            panelicones.Size = new Size(128, 34);
            panelicones.TabIndex = 5;
            // 
            // dataGridCargos
            // 
            dataGridCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCargos.Location = new Point(49, 183);
            dataGridCargos.Name = "dataGridCargos";
            dataGridCargos.RowHeadersWidth = 51;
            dataGridCargos.RowTemplate.Height = 29;
            dataGridCargos.Size = new Size(566, 312);
            dataGridCargos.TabIndex = 13;
            // 
            // bttIncluir
            // 
            bttIncluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttIncluir.Location = new Point(49, 124);
            bttIncluir.Name = "bttIncluir";
            bttIncluir.Size = new Size(107, 40);
            bttIncluir.TabIndex = 14;
            bttIncluir.Text = "Incluir";
            bttIncluir.UseVisualStyleBackColor = true;
            bttIncluir.Click += bttIncluir_Click;
            // 
            // bttAlterar
            // 
            bttAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttAlterar.Location = new Point(175, 124);
            bttAlterar.Name = "bttAlterar";
            bttAlterar.Size = new Size(107, 40);
            bttAlterar.TabIndex = 15;
            bttAlterar.Text = "Alterar";
            bttAlterar.UseVisualStyleBackColor = true;
            bttAlterar.Click += bttAlterar_Click;
            // 
            // bttSelecionar
            // 
            bttSelecionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttSelecionar.ForeColor = SystemColors.ControlLightLight;
            bttSelecionar.Image = Properties.Resources.Sem_título_resized__2___1_1;
            bttSelecionar.Location = new Point(517, 506);
            bttSelecionar.Name = "bttSelecionar";
            bttSelecionar.Size = new Size(107, 47);
            bttSelecionar.TabIndex = 16;
            bttSelecionar.Text = "Selecionar";
            bttSelecionar.UseVisualStyleBackColor = true;
            bttSelecionar.Click += bttSelecionar_Click;
            // 
            // bttBuscar
            // 
            bttBuscar.Image = Properties.Resources.search_3917132__1__resized_resized_resized;
            bttBuscar.Location = new Point(586, 132);
            bttBuscar.Name = "bttBuscar";
            bttBuscar.Size = new Size(30, 30);
            bttBuscar.TabIndex = 28;
            bttBuscar.UseVisualStyleBackColor = true;
            bttBuscar.Click += bttBuscar_Click;
            // 
            // picFiltroBuscar
            // 
            picFiltroBuscar.Image = Properties.Resources.output_onlinepngtools__19___1__resized;
            picFiltroBuscar.Location = new Point(380, 129);
            picFiltroBuscar.Name = "picFiltroBuscar";
            picFiltroBuscar.Size = new Size(52, 36);
            picFiltroBuscar.TabIndex = 32;
            picFiltroBuscar.UseVisualStyleBackColor = true;
            picFiltroBuscar.Click += picFiltroBuscar_Click;
            picFiltroBuscar.MouseLeave += picFiltroBuscar_MouseLeave;
            picFiltroBuscar.MouseHover += picFiltroBuscar_MouseHover;
            // 
            // checkListBusca
            // 
            checkListBusca.FormattingEnabled = true;
            checkListBusca.Items.AddRange(new object[] { "ID Área", "Descrição Área" });
            checkListBusca.Location = new Point(385, 165);
            checkListBusca.Name = "checkListBusca";
            checkListBusca.Size = new Size(198, 48);
            checkListBusca.TabIndex = 31;
            checkListBusca.Visible = false;
            checkListBusca.ItemCheck += CheckListBusca_ItemCheck;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesquisa.Location = new Point(438, 110);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(67, 20);
            lblPesquisa.TabIndex = 30;
            lblPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.CharacterCasing = CharacterCasing.Upper;
            txtPesquisa.Location = new Point(438, 134);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(145, 27);
            txtPesquisa.TabIndex = 29;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // TelaArea_cad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(664, 572);
            Controls.Add(bttBuscar);
            Controls.Add(picFiltroBuscar);
            Controls.Add(checkListBusca);
            Controls.Add(lblPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(bttSelecionar);
            Controls.Add(bttAlterar);
            Controls.Add(bttIncluir);
            Controls.Add(dataGridCargos);
            Controls.Add(faixadaVerde);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaArea_cad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargo";
            FormClosed += _FormClosed;
            Load += Cargo_Load;
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bttFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel faixadaVerde;
        private Label lblCargo;
        private Panel panelicones;
        private DataGridView dataGridCargos;
        private Button bttIncluir;
        private Button bttAlterar;
        private Button bttSelecionar;
        private Button bttBuscar;
        private Button picFiltroBuscar;
        private CheckedListBox checkListBusca;
        private Label lblPesquisa;
        private TextBox txtPesquisa;
        private PictureBox bttFechar;
    }
}