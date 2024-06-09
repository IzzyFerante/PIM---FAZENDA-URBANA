namespace Interface.View.IA
{
    partial class TelaIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaIA));
            txtInput = new TextBox();
            txtRespose = new RichTextBox();
            bttEnviar = new Button();
            faixadaVerde = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblNomeIA = new Label();
            pictureBox1 = new PictureBox();
            faixadaVerde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.Control;
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(36, 547);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(327, 30);
            txtInput.TabIndex = 0;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // txtRespose
            // 
            txtRespose.BackColor = SystemColors.AppWorkspace;
            txtRespose.BorderStyle = BorderStyle.None;
            txtRespose.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtRespose.Location = new Point(36, 131);
            txtRespose.Name = "txtRespose";
            txtRespose.ReadOnly = true;
            txtRespose.Size = new Size(383, 398);
            txtRespose.TabIndex = 2;
            txtRespose.Text = "";
            // 
            // bttEnviar
            // 
            bttEnviar.BackColor = Color.FromArgb(28, 52, 4);
            bttEnviar.Image = Properties.Resources.output_onlinepngtools__6__resized_resized;
            bttEnviar.Location = new Point(369, 535);
            bttEnviar.Name = "bttEnviar";
            bttEnviar.Size = new Size(50, 50);
            bttEnviar.TabIndex = 3;
            bttEnviar.UseVisualStyleBackColor = false;
            bttEnviar.Click += btnEnviar_Click;
            // 
            // faixadaVerde
            // 
            faixadaVerde.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            faixadaVerde.BackColor = Color.FromArgb(28, 52, 4);
            faixadaVerde.Controls.Add(pictureBox3);
            faixadaVerde.Controls.Add(pictureBox2);
            faixadaVerde.Controls.Add(lblNomeIA);
            faixadaVerde.Controls.Add(pictureBox1);
            faixadaVerde.Location = new Point(0, 0);
            faixadaVerde.Name = "faixadaVerde";
            faixadaVerde.Size = new Size(460, 125);
            faixadaVerde.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.minimizar_branco;
            pictureBox3.Location = new Point(392, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fechar_branco;
            pictureBox2.Location = new Point(423, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblNomeIA
            // 
            lblNomeIA.AutoSize = true;
            lblNomeIA.FlatStyle = FlatStyle.System;
            lblNomeIA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeIA.ForeColor = SystemColors.ControlLightLight;
            lblNomeIA.Location = new Point(109, 46);
            lblNomeIA.Name = "lblNomeIA";
            lblNomeIA.Size = new Size(127, 31);
            lblNomeIA.TabIndex = 13;
            lblNomeIA.Text = "CultivaBot";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.output_onlinepngtools__4_1;
            pictureBox1.Location = new Point(24, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // TelaIA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(460, 613);
            Controls.Add(faixadaVerde);
            Controls.Add(bttEnviar);
            Controls.Add(txtRespose);
            Controls.Add(txtInput);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaIA";
            StartPosition = FormStartPosition.Manual;
            Text = "IA";
            Load += TelaIA_Load;
            faixadaVerde.ResumeLayout(false);
            faixadaVerde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private RichTextBox txtRespose;
        private Button bttEnviar;
        private Panel faixadaVerde;
        private PictureBox pictureBox1;
        private Label lblNomeIA;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}