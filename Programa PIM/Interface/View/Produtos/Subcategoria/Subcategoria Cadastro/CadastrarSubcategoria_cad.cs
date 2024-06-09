using Interface.Model;
using Interface.View.Produtos.Subcategoria.Subcategoria_Alteração;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Produtos.Subcategoria.Subcategoria_Cadastro
{
    public partial class CadastrarSubcategoria_cad : Form
    {
        private Subcategoria_cad formPrincipal;

        public CadastrarSubcategoria_cad(string cod, Subcategoria_cad subcategoria)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtCodSubcategoria.Text = cod;
            formPrincipal = subcategoria;
        }


        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            txtDescSubcategoria.TabIndex = 0;
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
            if (MessageBox.Show("Tem certeza que deseja cancelar cadastro de nova categoria?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        ///
        /// EVENTO BOTÃO "CONFIRMAR"
        ///
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescSubcategoria.Text))
            {
                if (MessageBox.Show("Confirmar cadastro de nova categoria?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AcoesProdutos acoes = new AcoesProdutos();
                    acoes.CadastrarNovaFK("categorias", "id_categoria, nome_categoria", $"'{txtCodSubcategoria.Text}', '{txtDescSubcategoria.Text}'");  //  Alterando dado no banco

                    MessageBox.Show("Categoria cadastrada com sucesso!", "Cadastro realizado");

                    formPrincipal.AtualizarDataGridView();  //  Atualizando datagrid do form Cargo
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Os campo descrição categoria não pode ser em branco!", "Preenchimento incorreto");
            }
        }

        // Confirmar com a tecla "Enter"
        private void txtDescSubcategoria_KeyDown(object sender, KeyEventArgs e)
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
        private void CadastrarSubcategoria_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            string ultimoId = acoes.NovaMatricula("categorias", "id_categoria");
            string novaMatricula = "";

            if (!string.IsNullOrEmpty(ultimoId))
            {
                int conversaoId = int.Parse(ultimoId);
                novaMatricula = (conversaoId + 1).ToString().PadLeft(6, '0');
            }
            else
            {
                novaMatricula = "000001";
            }

            txtCodSubcategoria.Text = novaMatricula;
        }


        ///
        /// EVENTO PARA GARANTIR QUE DESCRIÇÃO NÃO SEJA NULO
        ///
        private void txtDescSubcategoria_Leave(object sender, EventArgs e)
        {
            if (txtDescSubcategoria.Text == null)
            {
                MessageBox.Show("A descrição não pode ser nula, ou seja, em branco", "Atenção");
                txtDescSubcategoria.Focus();
            }
        }
    }
}
