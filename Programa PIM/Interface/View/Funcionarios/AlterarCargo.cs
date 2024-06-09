using Interface.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Funcionarios
{
    public partial class AlterarCargo : Form
    {
        private Cargo formPrincipal;

        public AlterarCargo(string cod, Cargo cargo)
        {
            InitializeComponent();
            InitializeTabOrder();

            string codCargo = cod.PadLeft(5, '0');
            txtCodCategoria.Text = codCargo;
            formPrincipal = cargo;
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
                AcoesFuncionarios acoes = new AcoesFuncionarios();
                acoes.AtualizaDadosCARGO("cargo", "nome_cargo", txtDescCategoria.Text, "cod_cargo", txtCodCategoria.Text);  //  Alterando dado no banco

                MessageBox.Show("Cargo alterado com sucesso!", "Alteração realizada");

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
                MessageBox.Show("A descrição não pode ser nula, ou seja, em branco", "Atenção");
                txtDescCategoria.Focus();
            }
        }

        private void AlterarCargo_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            txtDescCategoria.Text = acoes.PuxarDescCargo(txtCodCategoria.Text);
        }
    }
}
