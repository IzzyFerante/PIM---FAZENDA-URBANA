using Interface.Model;
using Interface.View.Produção.Tela_Extras.Area.Area_cad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Produção.Tela_Extras.Area.Area_alt
{
    public partial class CadastrarArea_alt : Form
    {
        private TelaArea_alt formPrincipal;

        public CadastrarArea_alt(string cod, TelaArea_alt area)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtCodCargo.Text = cod;
            formPrincipal = area;
        }


        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            txtDescCargo.TabIndex = 0;
            bttConfirmar.TabIndex = 1;
            bttCancelar.TabIndex = 2;
        }


        /// 
        ///  ANIMAÇÃO CURSOR
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;


        ///
        /// EVENTO BOTÃO "CANCELAR"
        ///
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar cadastro de nova área?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        ///
        /// EVENTO BOTÃO "CONFIRMAR"
        ///
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar cadastro de nova área?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AcoesProducao acoes = new AcoesProducao();
                acoes.CadastrarArea(txtCodCargo.Text, txtDescCargo.Text);  //  Alterando dado no banco

                MessageBox.Show("Área cadastrado com sucesso!", "Cadastro realizado");

                formPrincipal.AtualizarDataGridView();  //  Atualizando datagrid do form Cargo
                this.Close();
            }
        }

        // Confirmar com a tecla "Enter"
        private void txtDescCargo_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Evita o som de 'ding' ao pressionar Enter
                e.SuppressKeyPress = true;

                // Executa a ação desejada, como clicar no botão
                bttConfirmar.PerformClick();
            }
        }



        ///
        /// EVENTO PARA GARANTIR QUE DESCRIÇÃO NÃO SEJA NULO
        ///
        private void txtDescCargo_Leave(object sender, EventArgs e)
        {
            if (txtDescCargo.Text == null)
            {
                MessageBox.Show("O nome não pode ser nulo, ou seja, em branco", "Atenção");
                txtDescCargo.Focus();
            }
        }
    }
}
