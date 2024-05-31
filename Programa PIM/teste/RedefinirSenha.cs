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
    public partial class RedefinirSenha : Form
    {
        public RedefinirSenha()
        {
            InitializeComponent();
        }


        ///
        /// Eventos botão "InfoEmail"
        ///
        private void picInfoEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coloque o seu email cadastrado no sistema!\n\nCaso não se lembre, favor contatar seu Superior.", "Ajuda Usuário");
        }

        


        ///
        /// Eventos botão "InfoPalavraChave"
        ///
        private void picInfoPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite a sua Palavra de Segurança que foi cadastrada no momento de criação da senha.\n\nCaso não se lembre, favor contatar seu Superior", "Ajuda Usuário");
        }

     

        ///
        /// Eventos botão "Confirmar"
        ///
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados corretos!", "Redefinição permitida!");
        }

     


        ///
        /// Eventos botão "Esqueci Minha Senha"
        ///
        private void lblEsqueciPalavraChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor entrar em contato com o seu Superior, para redefiniçao de Senha e Palavra de Segurança.", "Redefinir Palavra de Segurança");
        }

     
    }
}
      