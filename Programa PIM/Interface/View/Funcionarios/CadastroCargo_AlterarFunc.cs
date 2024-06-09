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
    public partial class CadastroCargo_AlterarFunc : Form
    {
        private Cargo_AlterarFunc formPrincipal;

        public CadastroCargo_AlterarFunc(string cod, Cargo_AlterarFunc cargo)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtCodCargo.Text = cod;
            formPrincipal = cargo;
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
            if (MessageBox.Show("Tem certeza que deseja cancelar cadastro de novo cargo?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        ///
        /// EVENTO BOTÃO "CONFIRMAR"
        ///
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar cadastro de novo cargo?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AcoesFuncionarios acoes = new AcoesFuncionarios();
                acoes.CadastrarCargo(txtCodCargo.Text, txtDescCargo.Text);  //  Alterando dado no banco

                MessageBox.Show("Cargo cadastrado com sucesso!", "Cadastro realizado");

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
        /// EVENTO PARA CARREGAR COD NOVO AUTOMATICO
        ///
        private void CadastrarCargo_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            string ultimoId = acoes.NovaMatricula("cargo", "cod_cargo");
            string novaMatricula = "";

            if (!string.IsNullOrEmpty(ultimoId))
            {
                int conversaoId = int.Parse(ultimoId);
                novaMatricula = (conversaoId + 1).ToString().PadLeft(5, '0');
            }
            else
            {
                novaMatricula = "000001";
            }

            txtCodCargo.Text = novaMatricula;
        }


        ///
        /// EVENTO PARA GARANTIR QUE DESCRIÇÃO NÃO SEJA NULO
        ///
        private void txtDescCargo_Leave(object sender, EventArgs e)
        {
            if (txtDescCargo.Text == null)
            {
                MessageBox.Show("A descrição não pode ser nula, ou seja, em branco", "Atenção");
                txtDescCargo.Focus();
            }
        }
    }
}
