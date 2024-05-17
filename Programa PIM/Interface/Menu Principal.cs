namespace Interface
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        


       

       

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void iconefechar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconemaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconerestaurar.Visible = false;
            iconemaximizar.Visible = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconerestaurar.Visible = true;
            iconemaximizar.Visible = false;
        }
        
            private void iconeminimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
