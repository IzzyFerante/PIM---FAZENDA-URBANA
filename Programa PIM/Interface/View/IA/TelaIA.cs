using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Interface.Model;
using OpenAI;

namespace Interface.View.IA
{
    public partial class TelaIA : Form
    {
       private readonly ChatGPTIntegration chatGPTIntegration;

        public TelaIA()
        {
            InitializeComponent();
            chatGPTIntegration = new ChatGPTIntegration(); // Certifique-se de inicializar o objeto aqui
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string pergunta = txtInput.Text;
            if (!string.IsNullOrEmpty(pergunta))
            {
                string resposta = await chatGPTIntegration.GetChatGPTResponse(pergunta);
                txtRespose.Text = txtRespose.Text + "\n\n" + resposta;
            }
            else
            {
                MessageBox.Show("Por favor, insira uma pergunta.");
            }
        }
            




        //  BOTÃO FECHAR
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        //  BOTÃO MINIMIZAR
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //  AÇÃO PARA CLICAR QUANDO APERTAR O ENTER
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttEnviar.PerformClick();
            }
        }

        private void TelaIA_Load(object sender, EventArgs e)
        {
            txtRespose.Text = "Olá, como posso te ajudar na cultivação da sua fazenda urbana?";
        }
    }
}
























    

    

