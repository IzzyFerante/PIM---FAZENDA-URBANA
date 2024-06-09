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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface.View.Produtos.Subcategoria.Subcategoria_Alteração
{
    public partial class AlterarSubcategoria_alt : Form
    {
        private Subcategoria_alt formPrincipal;

        public AlterarSubcategoria_alt(string id, Subcategoria_alt subcategoria)
        {
            InitializeComponent();
            InitializeTabOrder();

            string cod = id.PadLeft(5, '0');
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
            if (!string.IsNullOrWhiteSpace(txtDescSubcategoria.Text))
            {
                if (MessageBox.Show("Confirmar alteração?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AcoesProdutos acoes = new AcoesProdutos();
                    acoes.AtualizarDadosFK("categorias", "nome_categoria", txtDescSubcategoria.Text, "id_categoria", txtCodSubcategoria.Text);  //  Alterando dado no banco

                    MessageBox.Show("Categoria alterada com sucesso!", "Alteração realizada");

                    formPrincipal.AtualizarDataGridView();  //  Atualizando datagrid do form Cargo
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Os campos descrição categoria não pode ser em branco!", "Preenchimento incorreto");
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

        private void AlterarSubcategoria_Load(object sender, EventArgs e)
        {
            AcoesProdutos acoes = new AcoesProdutos();
            txtDescSubcategoria.Text = acoes.PuxarDescFK("desc_categoria", "categorias", "id_categoria", txtCodSubcategoria.Text);
        }     
    }
}
