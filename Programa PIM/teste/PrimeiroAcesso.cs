using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View
{
    public partial class PrimeiroAcesso : Form
    {
        public PrimeiroAcesso()
        {
            InitializeComponent();
        }

        /// 
        /// EVENTOS BOTÃO "INFO USUARIO" 
        ///
        private void picInfoUsuario_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Você deve colocar o seu usuário cadastrado no sistema!\n\nSeu usuário é o seu primeiro nome e seu ultímo sobrenome, separados por um ponto final (.). Sem espaços.", "Ajuda Usuário");
        }
        //  Animação do cursor
        private void picInfoUsuario_MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void picInfoUsuario_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

      
    }
}
