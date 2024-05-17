using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "admin";

            if (Usuario_txt.Text == User & senha_msk.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                Menu_Principal1 Menu_Principal1 = new Menu_Principal1();
                Menu_Principal1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha Incorretos!");
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void esqueceusnh_btn_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Abra um chamado!");
            
        }
    }
}