using Interface.Model;
using Interface.View.Clientes;
using Interface.View.Fornecedores;
using Interface.View.Funcionarios;
using Interface.View.Produtos.Subcategoria.Subcategoria_Alteração;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testes;

namespace Interface.View.Produtos
{
    public partial class AlterarProduto : Form
    {
        private TelaProdutos formPrincipal;
        private string? id;
        private string statusOriginal = "";

        public AlterarProduto(string id, string usuarioConectado, TelaProdutos prod)
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


        private Subcategoria_alt subcategoria;


        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            if (subcategoria != null && !subcategoria.IsDisposed)
            {
                subcategoria.Close();
            }
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
            txtQntdEstoque.Text = acoesVendas.preencherDadosExistentesINT("qntd_estoque", "produtos", "id_produto", id).ToString();

            string categoria = acoes.preencherDadosExistentes("id_categoria", "produtos", "id_produto", id);
            txtDescSubcategoria.Text = acoes.preencherDadosExistentes("nome_categoria", "categorias", "id_categoria", categoria);
        }


        /// 
        /// EVENTO DO BOTÃO "CANCELAR"
        /// 
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        /// 
        /// EVENTO DO BOTÃO "CONFIRMAR"
        /// 
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            AcoesProdutos acoes = new AcoesProdutos();

            if (ValidarCamposObrigatorios())    //  Chama o método criado mais abaixo para validar se os campo obrigratórios foram preenchidos
            {
                if (MessageBox.Show("Confirmar alteração de produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)    //  Garante que o botão não tenha sido apertado por engano
                {
                    //  DEFINIR BOOL DE STATUS CONFORME PREENCHIDO
                    bool produtoAtivo = false; //  Cria variável para salvar a informação
                    if (checkProdutoAtivo.CheckState == CheckState.Checked)
                    {
                        produtoAtivo = true;
                    }


                    string id = txtIdProduto.Text.PadLeft(6, '0');   //  Garante que a identificação tenha os zeros anteriores
                    string valor = txtValor.Text.Replace(",", ".");
                    string qntd = txtQntdEstoque.Text.Trim(new char[] { ',', '.', });

                    acoes.AtualizarDados(id, produtoAtivo, txtCodSubcategoria.Text, txtDescProduto.Text, valor, qntd);


                    //  TRANSFORMA O STATUS ORIGINAL EM BOOLEANO
                    bool statusOriginalBOOL;
                    bool conversao = Boolean.TryParse(statusOriginal, out statusOriginalBOOL);

                    //  FAZ A VERIFICAÇÃO DE ALTTERAÇÃO DE STATUS E SUAS RESPECTIVAS AÇÕES
                    if (produtoAtivo == statusOriginalBOOL && produtoAtivo == false)
                    {
                        MessageBox.Show("Produto continua inativo!", "Produto Inativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (produtoAtivo != statusOriginalBOOL && produtoAtivo == true)
                    {
                        MessageBox.Show("O produto foi reativado!", "Produto Reativado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (produtoAtivo != statusOriginalBOOL && produtoAtivo == false)
                    {
                        MessageBox.Show("O produto foi inativado!", "Produto Inativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    MessageBox.Show("Produto alterado com sucesso", "Alteração realizada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    formPrincipal.AtualizarDataGridView();  //  Atualiza o datagrid do forms TelaCliente
                    this.Close();   //  Fecha esse forms
                }
            }
            else
            {
                MessageBox.Show("Algum dado obrigatório não foi preenchido, favor verificar se todos os campos com asterisco (*) foram preenchidos.", "Erro de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQntdEstoque.Text))
            {
                // Remover espaços em branco no início e no fim
                string valorTexto = txtValor.Text.Trim();

                // Separar a parte inteira da parte decimal
                string[] partes = valorTexto.Split(new[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Verificar se a parte inteira tem até 8 dígitos
                string parteInteira = partes[0];

                // Verificar se a parte decimal tem até 2 dígitos
                string parteDecimal = "";
                if (partes.Length > 1)
                {
                    parteDecimal = partes[1];
                }

                // Verificar se há uma parte inteira
                if (Regex.IsMatch(valorTexto, @"[a-zA-Z]"))
                {
                    MessageBox.Show("Valor não pode conter letras.", "Valor inválido");
                    txtValor.Focus();
                }
                else if (parteInteira.Length > 8)
                {
                    MessageBox.Show("O valor do produto não pode ter mais de 8 dígitos antes da vírgula.", "Valor inválido");
                    txtValor.Focus();
                }
                else if (parteDecimal.Length > 2)
                {
                    MessageBox.Show("O valor do produto não pode ter mais de 2 dígitos depois da vírgula.", "Valor inválido");
                    txtValor.Focus();
                }
            }
        }


        private void txtQntdEstoque_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQntdEstoque.Text))
            {
                // Remover espaços em branco no início e no fim
                string qntdTexto = txtQntdEstoque.Text.Trim();

                // Separar a parte inteira da parte decimal
                string[] partes = qntdTexto.Split(new[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Verificar se a parte inteira tem até 8 dígitos
                string parteInteira = partes[0];

                // Verificar se a parte decimal tem até 2 dígitos
                string parteDecimal = "";
                if (partes.Length != 1)
                {
                    MessageBox.Show("A quantidade não pode ser número quebrado", "Quantidade inválida");
                    txtQntdEstoque.Focus();
                }
                else if (Regex.IsMatch(qntdTexto, @"[a-zA-Z]"))
                {
                    MessageBox.Show("Quantidade não pode conter letras.", "Quantidade inválido");
                    txtValor.Focus();
                }
            }
        }





        /////////////////////////////////   CATEGORIA E SUBCATEGORIA  /////////////////////////////////////////


        ///
        /// EVENTO PARA PUXAR AS DESCRIÇÕES DA CATEGORIA E SUBCATEGORIA
        ///
        private void txtCodSubcategoria_TextChanged(object sender, EventArgs e)
        {
            AcoesProdutos acoes = new AcoesProdutos();
            txtDescSubcategoria.Text = acoes.PuxarDescFK("nome_categoria", "categorias", "id_categoria", txtCodSubcategoria.Text);
        }

        private void txtCodSubcategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSubcategoria.Text) != true)
            {
                bool validacao = ValidarCampoSubcategoria();
                if (validacao == false)
                {
                    MessageBox.Show("Categoria inserida não cadastrada!", "Categoria inválida");
                    txtCodSubcategoria.Focus();
                }

            }
        }

        private bool ValidarCampoSubcategoria()
        {
            AcoesProdutos acoes = new AcoesProdutos();

            string tabela = acoes.PuxarDescFK("id_categoria", "categorias", "id_categoria", txtCodSubcategoria.Text);

            return !string.IsNullOrWhiteSpace(tabela);
        }



        /// 
        /// EVENTO DO BOTÃO BUSCA FK         
        /// 
        private void picBuscaSubcategoria_Click(object sender, EventArgs e)
        {
            Subcategoria_alt telaCategoria = new Subcategoria_alt(this);
            telaCategoria.Show();
        }



        public void SetSubcategoriaCode(string codigo)
        {
            txtCodSubcategoria.Text = codigo;
        }
















        ////////////////////////////////////////////    AÇÕES CRIADAS PARA OS EVENTOS   ////////////////////////////////////////////


        /// 
        /// AÇÃO PARA GARANTIR QUE O DADOS OBRIGATÓRIOS SEJAM INSERIDOS
        /// 
        private bool ValidarCamposObrigatorios()
        {
            return !string.IsNullOrWhiteSpace(txtDescProduto.Text)
                && !string.IsNullOrWhiteSpace(txtCodSubcategoria.Text)
                && !string.IsNullOrWhiteSpace(txtDescSubcategoria.Text)
                && !string.IsNullOrWhiteSpace(txtValor.Text)
                && !string.IsNullOrWhiteSpace(txtQntdEstoque.Text);
        }






        ////////////////////////////////////////////    BOTÕES DE MANIPULAÇÃO DA TELA   ////////////////////////////////////////////


        ///
        /// ANIMAÇÃO DO CURSOR EM CIMA DOS BOTÕES 
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;



        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"    /////////////////////////////////////////// PRECISA SER AJUSTADO AINDA
        /// 
        private void bttMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //  Alterar os botões visiveis
            bttRestaurar.Visible = true;
            bttMaximizar.Visible = false;

            /*  Redimensionar icones
            faixadaVerde.Size = new Size(1920, 200);
            dataGridView1.Size = new Size(1840, 740);
            picIcone.Size = new Size(155, 139);

            float newSize = 20.0f;
            Font newFont = new Font(lblAlterarFuncionarios.Font.FontFamily, newSize, lblAlterarFuncionarios.Font.Style);
            lblAlterarFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 228);
            bttAlterar.Location = new Point(180, 228);
            bttDeletar.Location = new Point(320, 228);
            dataGridView1.Location = new Point(40, 296);
            picIcone.Location = new Point(42, 61);
            lblAlterarFuncionarios.Location = new Point(208, 134);*/
        }


        /// 
        /// EVENTO BOTÃO "RESTAURAR"    /////////////////////////////////////////// PRECISA SER AJUSTADO AINDA
        /// 
        private void bttRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            //  Altera os botões visiveis
            bttRestaurar.Visible = false;
            bttMaximizar.Visible = true;

            //  Centraliza a tela
            //this.CenterToScreen();

            /*  Redimensionar icones
            ClientSize = new Size(960, 540);
            faixadaVerde.Size = new Size(960, 125);
            dataGridView1.Size = new Size(880, 280);
            picIcone.Size = new Size(100, 84);

            float newSize = 15.0f;
            Font newFont = new Font(lblAlterarFuncionarios.Font.FontFamily, newSize, lblAlterarFuncionarios.Font.Style);
            lblAlterarFuncionarios.Font = newFont;

            //  Colocar na localização na hora da redimensionação
            bttIncluir.Location = new Point(40, 153);
            bttAlterar.Location = new Point(180, 153);
            bttDeletar.Location = new Point(320, 153);
            dataGridView1.Location = new Point(40, 221);
            picIcone.Location = new Point(42, 41);
            lblAlterarFuncionarios.Location = new Point(151, 80);*/
        }


        /// 
        /// EVENTO BOTÃO "MINIMIZAR"
        /// 
        private void bttMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
