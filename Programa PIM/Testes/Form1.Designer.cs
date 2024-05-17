namespace Testes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLogradouro = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            lblCep = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            mskCep = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(150, 90);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(300, 27);
            txtLogradouro.TabIndex = 1;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(150, 151);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(300, 27);
            txtBairro.TabIndex = 2;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(150, 212);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(300, 27);
            txtCidade.TabIndex = 3;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(150, 276);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(300, 27);
            txtEstado.TabIndex = 4;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(109, 32);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(35, 20);
            lblCep.TabIndex = 5;
            lblCep.Text = "Cep";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 93);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Logradouro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 158);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Bairro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 215);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 8;
            label4.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 279);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Estado";
            // 
            // mskCep
            // 
            mskCep.Location = new Point(150, 29);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(79, 27);
            mskCep.TabIndex = 10;
            mskCep.Leave += mskCep_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mskCep);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCep);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtLogradouro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label lblCep;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox mskCep;
    }
}
