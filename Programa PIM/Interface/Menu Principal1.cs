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
    public partial class Menu_Principal1 : Form
    {
        public Menu_Principal1()
        {
            InitializeComponent();
        }

        private void iconefechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconemaximizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconerestaurar1.Visible = true;
            iconemaximizar1.Visible = false;
        }

        private void iconerestaurar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconerestaurar1.Visible = false;
            iconemaximizar1.Visible = true;
        }

        private void iconeminimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Menu_Principal1_Load(object sender, EventArgs e)
        {

        }
    }
}
