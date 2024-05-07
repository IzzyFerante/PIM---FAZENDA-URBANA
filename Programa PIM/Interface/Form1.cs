using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste01
{ 
    public partial class Login_fms1: MetroFramework.Forms.MetroForm
       
    {
        public Login_fms1()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)

        {

        }

        private void Acesar_btn_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "admin";

            if (Usuario_txt.Text == User & Senha_txt.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                Menu_Principal Menu_Principal = new Menu_Principal();
                Menu_Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha Incorretos!");
            }

        }

        private void Cancelar_txt_Click(object sender, EventArgs e)
        {

        }

        private void Senha_lbn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Senha_txt_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
