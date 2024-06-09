using Interface.Model;
using Interface.View.Produtos.Subcategoria.Subcategoria_Cadastro;
using Interface.View.Produtos;
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
using Interface.View.Vendas.Telas_Extras;
using Npgsql;
using System.Reflection.Emit;
using static Interface.View.Vendas.AlterarVenda;
using Interface.View.Fornecedores;

namespace Interface.View.Vendas
{
    public partial class CadastrarVenda : Form
    {
        private TelaVendas formPrincipal;
        private TelaVendas produtos;


        public CadastrarVenda(string usuario, TelaVendas prod)
        {
            InitializeComponent();
            InitializeTabOrder();

            lblUsuario.Text = usuario;
            formPrincipal = prod;
        }

        private List<string> itensRemovidosTemporarios = new List<string>();

        private List<ItemVenda> itensVendaTemporarios = new List<ItemVenda>();

        public class ItemVenda
        {
            public string IdItem { get; set; }
            public string IdVenda { get; set; }
            public string CodProduto { get; set; }
            public string Quantidade { get; set; }
            public string ValorUnitario { get; set; }
            public string ValorTotal { get; set; }
        }




        private VisualizarProduto_cad produto;
        private VisualizarCliente_cad cliente;

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            if (produto != null && !produto.IsDisposed)
            {
                produto.Close();
            }

            if (cliente != null && !cliente.IsDisposed)
            {
                cliente.Close();
            }
        }



        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            mskDtVenda.TabIndex = 0;
            txtCodCliente.TabIndex = 1;
            txtCodProduto.TabIndex = 2;
            txtQntdProduto.TabIndex = 3;
            bttAdicionarProduto.TabIndex = 4;
            checkCrédito.TabIndex = 5;
            checkDebito.TabIndex = 6;
            checkPix.TabIndex = 7;
            checkBoleto.TabIndex = 8;
            checkA_Vista.TabIndex = 9;
            checkParcelado.TabIndex = 10;
            txtQntdParcelas.TabIndex = 11;
            bttConfirmar.TabIndex = 12;
            bttCancelar.TabIndex = 13;
        }


        /// 
        /// EVENTO DO BOTÃO "CANCELAR"
        /// 
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                // Verifica se há linhas no DataGridView antes de percorrê-las
                int totalLinhas = dataGridProdutos.Rows.Count;
                if (totalLinhas > 0)
                {
                    // Itera até a penúltima linha para evitar o erro ao tentar acessar a próxima linha
                    for (int i = 0; i < totalLinhas - 1; i++)
                    {
                        DataGridViewRow row = dataGridProdutos.Rows[i];

                        // Obtém os valores das células necessárias para a exclusão
                        string id = row.Cells["IdItem"].Value.ToString();
                        string qntd = row.Cells["Quantidade"].Value.ToString();
                        string id_produto = row.Cells["CodProduto"].Value.ToString();
                        string preco = row.Cells["valorTotal"].Value.ToString();

                        // Executa as ações necessárias para a exclusão
                        AcoesVendas acoes = new AcoesVendas();
                        acoes.DeletarItem("itens_venda", id, txtIdVenda.Text);

                        int qntdEstoque = acoes.PuxarQntdEstoque("qntd_estoque", "produtos", "id_produto", id_produto);
                        int somarQntdEstoque = qntdEstoque + int.Parse(qntd);

                        string valorSomado = somarQntdEstoque.ToString().Replace(",", ".");
                        acoes.UpdateQuantidade(valorSomado, id_produto);

                        double textValorTotal = Convert.ToDouble(txtValorTotal.Text);
                        double precoItem = Convert.ToDouble(preco);

                        double AlteracaoValorVenda = textValorTotal - precoItem;
                        txtValorTotal.Text = AlteracaoValorVenda.ToString();
                    }
                }
                else
                {
                    // Mensagem ou ação caso não haja linhas no DataGridView
                    MessageBox.Show("Não há itens para excluir.");
                }


                this.Close();
                
            }
        }



        /// 
        /// AÇÃO PARA GARANTIR QUE O DADOS OBRIGATÓRIOS SEJAM INSERIDOS
        /// 
        private bool ValidarCamposObrigatorios()
        { 
            return !string.IsNullOrWhiteSpace(mskDtVenda.Text)
                && !string.IsNullOrWhiteSpace(txtCodCliente.Text)
                && !string.IsNullOrWhiteSpace(txtQntdProduto.Text)
                && !string.IsNullOrWhiteSpace(txtQntdProduto.Text)
                && !string.IsNullOrWhiteSpace(mskDtVenda.Text);
        }

        private bool ValidarCamposObrigatoriosData()
        {

            string dataTexto = mskDtVenda.Text;

            string dataNumerico = new string(dataTexto.Where(char.IsDigit).ToArray());

            if (dataNumerico.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        /// 
        ///  EVENTO PARA ALTERAR OS CHECK
        /// 
        private void checkA_Vista_CheckedChanged(object sender, EventArgs e)
        {
            if (checkA_Vista.CheckState == CheckState.Checked)
            {
                txtQntdParcelas.ReadOnly = true;
                lblQntdParcelas.Text = "Qntd. Parcelas:";

                checkParcelado.Checked = false;
            }
        }

        private void checkParcelado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkParcelado.CheckState == CheckState.Checked)
            {
                txtQntdParcelas.ReadOnly = false;
                lblQntdParcelas.Text = "*Qntd. Parcelas:";

                checkA_Vista.Checked = false;
            }
            else
            {
                txtQntdParcelas.ReadOnly = true;
                lblQntdParcelas.Text = "Qntd. Parcelas:";
            }
        }

        private void checkCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCrédito.CheckState == CheckState.Checked)
            {
                checkParcelado.Enabled = true;

                checkA_Vista.Checked = false;
                checkA_Vista.Enabled = true;

                checkDebito.Checked = false;
                checkPix.Checked = false;
                checkBoleto.Checked = false;
            }
        }

        private void checkDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDebito.CheckState == CheckState.Checked)
            {
                checkParcelado.Enabled = false;

                checkA_Vista.Checked = true;
                checkA_Vista.Enabled = false;

                checkCrédito.Checked = false;
                checkPix.Checked = false;
                checkBoleto.Checked = false;
            }
        }

        private void checkPix_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPix.CheckState == CheckState.Checked)
            {
                checkParcelado.Enabled = false;

                checkA_Vista.Checked = true;
                checkA_Vista.Enabled = false;

                checkCrédito.Checked = false;
                checkDebito.Checked = false;
                checkBoleto.Checked = false;
            }
        }

        private void checkBoleto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoleto.CheckState == CheckState.Checked)
            {
                checkParcelado.Enabled = false;

                checkA_Vista.Checked = true;
                checkA_Vista.Enabled = false;

                checkCrédito.Checked = false;
                checkDebito.Checked = false;
                checkPix.Checked = false;
            }
        }



        ///
        /// EVENTO PARA QUANDO A TELA CARREGAR
        /// 
        private void CadastrarVenda_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();

            string ultimoId = acoes.NovaMatricula("vendas", "id_venda");
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

            txtIdVenda.Text = novaMatricula;

            IniciarDataGridProdutos();
        }



        ///
        /// VALIDAÇÕES DOS CAMPOS PARA GARANTIR INSERÇÃO CORRETA
        ///
        private bool ValidarCampoCliente()
        {
            AcoesVendas acoes = new AcoesVendas();

            string tabela = acoes.PuxarDescATIVOS("id_cliente", "clientes", "id_cliente", txtCodCliente.Text);

            return !string.IsNullOrWhiteSpace(tabela);
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text) != true)
            {
                bool validacao = ValidarCampoCliente();
                if (validacao == false)
                {
                    MessageBox.Show("Cliente inserido não cadastrado ou inativo!", "Cliente inválido");
                    txtCodCliente.Focus();
                }

            }
        }


        private bool ValidarCampoProduto()
        {
            AcoesVendas acoes = new AcoesVendas();

            string tabela = acoes.PuxarDescATIVOS("id_produto", "produtos", "id_produto", txtCodProduto.Text);

            return !string.IsNullOrWhiteSpace(tabela);
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodProduto.Text) != true)
            {
                bool validacao = ValidarCampoProduto();
                if (validacao == false)
                {
                    MessageBox.Show("Produto inserido não cadastrado ou inativo!", "Produto inválido");
                    txtCodProduto.Focus();
                }

            }
        }


        private void txtQntdProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQntdProduto.Text))
            {
                string qntdTexto = txtQntdProduto.Text.Trim();

                if (int.TryParse(txtQntdEstoque.Text, out int qntdEstoque) && int.TryParse(txtQntdProduto.Text, out int qntdProduto))
                {
                    if (qntdProduto > qntdEstoque)
                    {
                        MessageBox.Show("A quantidade não pode ser maior que a quantidade do produto em estoque", "Quantidade inválida");
                        txtQntdProduto.Focus();
                    }
                    else if (qntdProduto <= 0)
                    {
                        MessageBox.Show("A quantidade deve ser maior que zero", "Quantidade inválida");
                        txtQntdProduto.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Formato de número inválido.", "Erro de Formato");
                    txtQntdProduto.Focus();
                }
            }
        }

        private void txtQntdParcelas_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQntdParcelas.Text))
            {
                // Remover espaços em branco no início e no fim
                string qntdTexto = txtQntdParcelas.Text.Trim();

                // Separar a parte inteira da parte decimal
                string[] partes = qntdTexto.Split(new[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Verificar se a parte inteira tem até 8 dígitos
                string parteInteira = partes[0];

                // Verificar se a parte decimal tem até 2 dígitos
                string parteDecimal = "";
                if (partes.Length != 1)
                {
                    MessageBox.Show("A quantidade não pode ser número quebrado", "Quantidade inválida");
                    txtQntdParcelas.Focus();
                }
                else if (Regex.IsMatch(qntdTexto, @"[a-zA-Z]"))
                {
                    MessageBox.Show("Quantidade não pode conter letras.", "Quantidade inválido");
                    txtQntdParcelas.Focus();
                }
            }
        }


        private bool ValidarCampoData()
        {
            string dataTexto = mskDtVenda.Text;

            string dataNumerico = new string(dataTexto.Where(char.IsDigit).ToArray());

            if (dataNumerico.Length != 0)
            {
                if (DateTime.TryParse(mskDtVenda.Text, out DateTime data))
                {
                    // Verifica se o ano está dentro de um intervalo aceitável (por exemplo, de 1900 a 2100)
                    if (data.Year >= 1900 && data.Year <= 2024)
                    {
                        // Verifica se o dia corresponde ao mês e ao ano
                        if (data.Day >= 1 && data.Day <= DateTime.DaysInMonth(data.Year, data.Month))
                        {
                            // A data é válida
                            return true;
                        }
                    }
                }
                // Se não for possível converter para DateTime ou se a data não for válida
                return false;
            }
            return true;
        }

        private void mskDtVenda_Leave(object sender, EventArgs e)
        {
            if (mskDtVenda.Text != null)
            {
                bool validacao = ValidarCampoData();
                if (validacao == false)
                {
                    MessageBox.Show("Data inválida!", "Data inválida");
                    mskDtVenda.Focus();
                }
            }
        }




        ///
        /// EVENTOS PARA PUXAR AS DESCRIÇÕES DOS CÓDIGOS E VALOR PARCELA AUTOMÁTICO
        ///
        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            AcoesProdutos acoes = new AcoesProdutos();

            txtNomeCliente.Text = acoes.PuxarDescFK("nome", "clientes", "id_cliente", txtCodCliente.Text);
        }


        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            AcoesProdutos acoesReutilizacao = new AcoesProdutos();
            AcoesVendas acoes = new AcoesVendas();


            txtProduto.Text = acoesReutilizacao.PuxarDescFK("desc_produto", "produtos", "id_produto", txtCodProduto.Text);
            txtQntdEstoque.Text = acoes.PuxarQntdEstoque("qntd_estoque", "produtos", "id_produto", txtCodProduto.Text).ToString();
        }


        private void txtQntdParcelas_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtValorTotal.Text, out double valorTotal) && double.TryParse(txtQntdParcelas.Text, out double qntdParcela))
            {
                double valorParcela = valorTotal / qntdParcela;
                txtValorParcela.Text = valorParcela.ToString("F2");
            }
            else
            {
                MessageBox.Show("Formato de número inválido em Valor Total ou Quantidade de Parcelas.", "Erro de Formato");
            }
        }



        /// 
        /// EVENTO DO BOTÃO "CONFIRMAR"
        /// 
        private void bttConfirmar_Click(object sender, EventArgs e)
        {
            if (!checkCrédito.Checked && !checkDebito.Checked && !checkPix.Checked && !checkBoleto.Checked)
            {
                MessageBox.Show("Selecione uma forma de pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (checkCrédito.Checked && !checkA_Vista.Checked && !checkParcelado.Checked)
                {
                    MessageBox.Show("Selecione um modo de pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (checkParcelado.Checked && string.IsNullOrWhiteSpace(txtQntdParcelas.Text) || txtQntdParcelas.Text == "0")
                    {
                        MessageBox.Show("As parcelas não podem ser 0 ou em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    { 
                        {
                            if (ValidarCamposObrigatorios() && ValidarCamposObrigatoriosData())
                            {
                                AcoesVendas acoes = new AcoesVendas();

                                string valorTotal = txtValorTotal.Text.Replace(",", ".");

                                DateTime dtVenda = DateTime.ParseExact(mskDtVenda.Text, "dd/MM/yyyy", null);


                                //  Tranformar a forma de pagamento em seu respectivo código
                                string pagamento = "";

                                if (checkCrédito.Checked == true)
                                {
                                    pagamento = "1";
                                }
                                else if (checkDebito.Checked == true)
                                {
                                    pagamento = "2";
                                }
                                else if (checkPix.Checked == true)
                                {
                                    pagamento = "4";
                                }
                                else if (checkBoleto.Checked == true)
                                {
                                    pagamento = "3";
                                }

                                string valorParcela = "0";
                                string qntdParcela = "0";
                                if (checkParcelado.Checked == true)
                                {
                                    valorParcela = txtValorParcela.Text.Replace(",", ".");
                                    qntdParcela = txtQntdParcelas.Text;
                                }
                                int parcelas = Convert.ToInt32(qntdParcela);


                                //  Insere cadastro no banco
                                acoes.CadastrarDados(txtIdVenda.Text, dtVenda, txtCodCliente.Text, valorTotal, pagamento, parcelas, valorParcela);

                                // Remover itens do banco de dados
                                foreach (var id in itensRemovidosTemporarios)
                                {
                                    var itemRemovido = itensVendaTemporarios.FirstOrDefault(item => item.IdItem == id);
                                    if (itemRemovido != null)
                                    {
                                        acoes.DeletarItem("itens_venda", itemRemovido.IdItem, itemRemovido.IdVenda);
                                    }
                                }


                                foreach (var item in itensVendaTemporarios)
                                {
                                    acoes.CadastrarDadosItens(item.IdItem, item.IdVenda, item.CodProduto, item.Quantidade, item.ValorUnitario, item.ValorTotal);
                                }

                                itensVendaTemporarios.Clear(); // Limpar a lista temporária após salvar
                                AtualizarDataGridView(); // Atualizar o DataGridView para refletir as alteraçõe


                                MessageBox.Show("Inclusão feita com sucesso.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                formPrincipal.AtualizarDataGridView();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Algum dado obrigatório não foi preenchido, favor verificar se todos os campos com asterisco (*) foram preenchidos.", "Erro de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }



        /// 
        /// EVENTO DO BOTÃO BUSCA FK         
        /// 
        private void picBuscaCliente_Click(object sender, EventArgs e)
        {
            VisualizarCliente_cad telaCliente = new VisualizarCliente_cad(this);
            telaCliente.Show();
        }

        private void picBuscaProduto_Click(object sender, EventArgs e)
        {
            VisualizarProduto_cad telaProduto = new VisualizarProduto_cad(this);
            telaProduto.Show();
        }


        public void SetClienteCode(string codigo)
        {
            txtNomeCliente.Text = codigo;
        }

        public void SetProdutoCode(string codigo)
        {
            txtCodProduto.Text = codigo;
        }







        ///////////////////////////////////////////////////// AÇÃO DE ADICIONAR OS ITENS /////////////////////////////////////////////////////


        ///
        /// AÇÃO PARA ATUALIZAR O GRID
        /// 
        private void IniciarDataGridProdutos()
        {
            // Definir as colunas do DataGridView
            dataGridProdutos.Columns.Clear();
            dataGridProdutos.Columns.Add("IdItem", "ID Item");
            dataGridProdutos.Columns.Add("IdVenda", "ID Venda");
            dataGridProdutos.Columns.Add("CodProduto", "Código Produto");
            dataGridProdutos.Columns.Add("Quantidade", "Quantidade");
            dataGridProdutos.Columns.Add("ValorUnitario", "Valor Unitário");
            dataGridProdutos.Columns.Add("ValorTotal", "Valor Total");
    }

        private void AtualizarDataGridView()
        {            
            dataGridProdutos.Rows.Clear();
           

            foreach (var item in itensVendaTemporarios)
            {
                dataGridProdutos.Rows.Add(item.IdItem, item.IdVenda, item.CodProduto, item.Quantidade, item.ValorUnitario, item.ValorTotal);
            }

            txtValorTotal.Text = SomarValoresColuna("ValorTotal").ToString();
        }



        private void bttAdicionarProduto_Click(object sender, EventArgs e)
        {
            string idProduto = txtCodProduto.Text;
            // Verifica se a lista de itens temporários não é nula
            if (itensVendaTemporarios != null)
            {
                // Variável para controlar se o produto já está na lista
                bool produtoExistente = false;

                // Verifica se o produto já está na lista
                foreach (var item in itensVendaTemporarios)
                {
                    if (item.CodProduto == idProduto)
                    {
                        produtoExistente = true;
                        break;
                    }
                }

                // Se o produto não estiver na lista, adiciona-o
                if (!produtoExistente)
                {
                    AcoesVendas acoes = new AcoesVendas();

                    string ultimoId = acoes.NovoCódigo(txtIdVenda.Text, "itens_venda", "id_item", "id_venda", txtIdVenda.Text);
                    string novoIdItem = !string.IsNullOrEmpty(ultimoId) ? (int.Parse(ultimoId) + 1).ToString().PadLeft(6, '0') : "000001";

                    decimal valor_unitario = acoes.PuxarNumeric("valor_unitario", "produtos", "id_produto", txtCodProduto.Text);

                    double unitario = Convert.ToDouble(valor_unitario);
                    double qntd = Convert.ToDouble(txtQntdProduto.Text);
                    double valor_total_produto = unitario * qntd;

                    string valorUnitario = valor_unitario.ToString().Replace(",", ".");
                    string valorTotal = valor_total_produto.ToString().Replace(',', '.');



                    // Adicionar item à lista temporária
                    ItemVenda item = new ItemVenda
                    {
                        IdItem = novoIdItem,
                        IdVenda = txtIdVenda.Text,
                        CodProduto = txtCodProduto.Text,
                        Quantidade = txtQntdProduto.Text,
                        ValorUnitario = valorUnitario,
                        ValorTotal = valorTotal
                    };
                    itensVendaTemporarios.Add(item);

                    AtualizarDataGridView();

                }
                else
                {
                    MessageBox.Show("Item já adicionado à lista.\n\nCaso necessário alterar a quantidade, remova-o da lista e adicione-o novamente com a quantidade correta.");
                }
            }
            else
            {
                AcoesVendas acoes = new AcoesVendas();

                string ultimoId = acoes.NovoCódigo(txtIdVenda.Text, "itens_venda", "id_item", "id_venda", txtIdVenda.Text);
                string novoIdItem = !string.IsNullOrEmpty(ultimoId) ? (int.Parse(ultimoId) + 1).ToString().PadLeft(6, '0') : "000001";

                decimal valor_unitario = acoes.PuxarNumeric("valor_unitario", "produtos", "id_produto", txtCodProduto.Text);

                double unitario = Convert.ToDouble(valor_unitario);
                double qntd = Convert.ToDouble(txtQntdProduto.Text);
                double valor_total_produto = unitario * qntd;

                string valorUnitario = valor_unitario.ToString().Replace(",", ".");
                string valorTotal = valor_total_produto.ToString().Replace(',', '.');

                // Adicionar item à lista temporária
                ItemVenda item = new ItemVenda
                {
                    IdItem = novoIdItem,
                    IdVenda = txtIdVenda.Text,
                    CodProduto = txtCodProduto.Text,
                    Quantidade = txtQntdProduto.Text,
                    ValorUnitario = valorUnitario,
                    ValorTotal = valorTotal
                };
                itensVendaTemporarios.Add(item);

                AtualizarDataGridView();

                double valorTotalCompra = double.TryParse(txtValorTotal.Text.Replace(',', '.'), out double valorTotalCompraParsed) ? valorTotalCompraParsed : 0.0;
                txtValorTotal.Text = (valorTotalCompra + valor_total_produto).ToString().Replace(",", ".");
            }
        }


        private void bttRetirarItem_Click(object sender, EventArgs e)
        {
            if (dataGridProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um item.");
                return;
            }

            if (dataGridProdutos.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir mais de um item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
            }

            foreach (DataGridViewRow selectedRow in dataGridProdutos.SelectedRows)
            {
                string id = selectedRow.Cells["IdItem"].Value.ToString();
                string qntd = selectedRow.Cells["Quantidade"].Value.ToString();
                string id_produto = selectedRow.Cells["CodProduto"].Value.ToString();
                string preco = selectedRow.Cells["ValorTotal"].Value.ToString();

                // Adicionar o ID à lista de itens removidos temporariamente
                itensRemovidosTemporarios.Add(id);

                // Remover item da lista temporária de itens vendidos
                var itemRemovido = itensVendaTemporarios.FirstOrDefault(item => item.IdItem == id);
                if (itemRemovido != null)
                {
                    itensVendaTemporarios.Remove(itemRemovido);

                    // Atualizar o valor total da venda
                    double textValorTotal = Convert.ToDouble(txtValorTotal.Text);
                    double precoItem = Convert.ToDouble(preco);
                    double AlteracaoValorVenda = textValorTotal - precoItem;
                    txtValorTotal.Text = AlteracaoValorVenda.ToString();
                }
            }

            AtualizarDataGridView();
        }


        private void bttRemoverTodosItens_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover todos os itens?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridProdutos.Rows)
                {
                    string id = row.Cells["id_item"].Value.ToString();
                    string qntd = row.Cells["quantidade"].Value.ToString();
                    string id_produto = row.Cells["id_produto"].Value.ToString();
                    string preco = row.Cells["valor_total"].Value.ToString();

                    // Adicionar o ID à lista de itens removidos temporariamente
                    itensRemovidosTemporarios.Add(id);

                    // Atualizar o valor total da venda
                    double textValorTotal = Convert.ToDouble(txtValorTotal.Text);
                    double precoItem = Convert.ToDouble(preco);
                    double AlteracaoValorVenda = textValorTotal - precoItem;
                    txtValorTotal.Text = AlteracaoValorVenda.ToString();

                    // Atualizar a quantidade no estoque localmente
                    int qntdEstoqueAtual = int.Parse(txtQntdEstoque.Text);
                    int somarQntdEstoque = qntdEstoqueAtual + int.Parse(qntd);
                    txtQntdEstoque.Text = somarQntdEstoque.ToString();
                }

                // Limpar a lista temporária de itens vendidos
                itensVendaTemporarios.Clear();

                // Atualizar o DataGridView
                AtualizarDataGridView();
            }
        }



        private decimal SomarValoresColuna(string nomeColuna)
        {
            decimal soma = 0.0m;

            // Verifica se há pelo menos uma linha no DataGridView
            if (dataGridProdutos.Rows.Count > 0)
            {
                // Percorre todas as linhas do DataGridView
                foreach (DataGridViewRow row in dataGridProdutos.Rows)
                {
                    // Verifica se a célula da coluna especificada não está vazia
                    if (row.Cells[nomeColuna].Value != null)
                    {
                        // Obtém o valor da célula como string
                        string valorString = row.Cells[nomeColuna].Value.ToString().Replace(".",",");

                        // Tenta converter o valor para decimal
                        if (decimal.TryParse(valorString, out decimal valorDecimal))
                        {
                            // Adiciona o valor convertido à soma total
                            soma += valorDecimal;
                        }
                        else
                        {
                            // Se a conversão falhar, exibe uma mensagem de erro
                            MessageBox.Show($"Erro ao converter o valor '{valorString}' para decimal.", "Erro de Conversão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            return soma;
        }










        ////////////////////////////////////////////    BOTÕES DE MANIPULAÇÃO DA TELA   ////////////////////////////////////////////


        ///
        /// ANIMAÇÃO DO CURSOR EM CIMA DOS BOTÕES 
        /// 
        private void MouseHover(object sender, EventArgs e) => Cursor = Cursors.Hand;

        private void MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;



        /// 
        /// EVENTO BOTÃO "MAXIMIZAR"
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
        /// EVENTO BOTÃO "RESTAURAR"
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