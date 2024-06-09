using Interface.Model;
using Interface.View.Fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.View.Produtos
{
    public partial class VisualizarProduto : Form
    {
        private TelaProdutos formPrincipal;
        private string? id;
        private string statusOriginal = "";

        public VisualizarProduto(string id, string usuarioConectado, TelaProdutos prod)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtIdProduto.Text = id.PadLeft(6, '0');  //  Preenche o campo de identificação automaticamente
            lblUsuario.Text = usuarioConectado;     //  Mantém salvo o usuario que está ativo para a informação não se perder quando voltar ao menu
            formPrincipal = prod;     // Permite passar informações entre esse form e o form chamado 
        }


        /// 
        /// EVENTO PARA DEFINIR A ORDEM DO TAB          
        /// 
        private void InitializeTabOrder()
        {
            txtDescProduto.TabIndex = 0;
            txtValor.TabIndex = 1;
            txtCodSubcategoria.TabIndex = 2;
            bttConfirmar.TabIndex = 3;
            bttCancelar.TabIndex = 4;
        }


        /// 
        /// EVENTO PARA QUANDO ABRIR TELA 
        ///
        private void Tela_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            AcoesVendas acoesVendas = new AcoesVendas();

            string id = txtIdProduto.Text.PadLeft(6, '0');

            //  SALVAR O STATUS ORIGINAL DO FORNECEDOR PARA FUTURA VERIFICAÇÃO DE ALTERAÇÃO DE STATUS
            bool? statusOriginalBOOL = acoes.PuxarDadoBOOL("status", "produtos", "id_produto", id); //  Puxa o status original em formato booleano
            statusOriginal = statusOriginalBOOL.ToString(); //  Transforma em string e salva na variável geral

            //  PREENCHE O CHECK CONFORME SALVO
            if (statusOriginalBOOL.HasValue && statusOriginalBOOL.Value == true)
            {
                checkProdutoAtivo.CheckState = CheckState.Checked;
            }
            else
            {
                checkProdutoAtivo.CheckState = CheckState.Unchecked;
            }

            //  PREENCHER OS CAMPOS COM OS DADOS EXISTENTES NO BANCO
            txtIdProduto.Text = acoes.preencherDadosExistentes("id_produto", "produtos", "id_produto", id);
            txtDescProduto.Text = acoes.preencherDadosExistentes("desc_produto", "produtos", "id_produto", id);
            txtValor.Text = acoes.preencherDadosExistentesNUMERIC("valor_unitario", "produtos", "id_produto", id).ToString();
            txtCodSubcategoria.Text = acoes.preencherDadosExistentes("id_categoria", "produtos", "id_produto", id);
            txtQntdEstoque.Text = acoesVendas.preencherDadosExistentesINT("qndt_estoque", "produtos", "id_produto", id).ToString();

            string categoria = acoes.preencherDadosExistentes("id_categoria", "produtos", "id_produto", id);
            txtDescSubcategoria.Text = acoes.preencherDadosExistentes("nome_categoria", "categorias", "id_categoria", categoria);
        }
    }
}