using Interface.Model;
using Interface.View.Funcionarios;
using Interface.View.Produção.Tela_Extras.Area.Area_alt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Produção.Tela_Extras.Area.Area_cad
{
    public partial class AlterarArea_cad : Form
    {
        private TelaArea_cad formPrincipal;

        public AlterarArea_cad(string cod, TelaArea_cad area)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtCodCategoria.Text = cod;
            formPrincipal = area;
        }


        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            txtDescCategoria.TabIndex = 0;
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
            if (MessageBox.Show("Tem certeza que deseja cancelar alteração?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        ///
        /// EVENTO BOTÃO "CONFIRMAR"
        ///
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar alteração?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AcoesProducao acoes = new AcoesProducao();
                acoes.AtualizaDadosArea("area", "nome", txtDescCategoria.Text, "id_area", txtCodCategoria.Text);  //  Alterando dado no banco

                MessageBox.Show("Área alterada com sucesso!", "Alteração realizada");

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
            if (txtDescCategoria.Text == null)
            {
                MessageBox.Show("O nome não pode ser nulo, ou seja, em branco", "Atenção");
                txtDescCategoria.Focus();
            }
        }

        private void AlterarCargo_Load(object sender, EventArgs e)
        {
            AcoesProducao acoes = new AcoesProducao();
            txtDescCategoria.Text = acoes.PuxarDescArea(txtCodCategoria.Text);
        }

    }
}