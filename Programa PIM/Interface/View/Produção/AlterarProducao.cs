using Interface.Model;
using Interface.View.Produção.Tela_Extras.Area.Area_alt;
using Interface.View.Produção.Tela_Extras.Area.Area_cad;
using Interface.View.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Interface.View.Produção
{
    public partial class AlterarProducao : Form
    {
        private TelaProducao formPrincipal;


        public AlterarProducao(string id, string usuario, TelaProducao prod)
        {
            InitializeComponent();
            InitializeTabOrder();

            txtIdProducao.Text = id;
            lblUsuario.Text = usuario;
            formPrincipal = prod;
        }


        private TelaArea_alt area;
        private Tela_Extras.VisualizarProduto_alt produto;

        private void _FormClosed(object sender, FormClosedEventArgs e)
        {
            if (area != null && !area.IsDisposed)
            {
                area.Close();
            }

            if (produto != null && !produto.IsDisposed)
            {
                produto.Close();
            }
        }



        /// 
        /// Evento para definir a ordem do TAB
        /// 
        private void InitializeTabOrder()
        {
            mskDtPlantio.TabIndex = 0;
            txtArea.TabIndex = 1;
            txtCodProduto.TabIndex = 2;
            txtQntdPlantada.TabIndex = 3;
            bttConfirmar.TabIndex = 12;
            bttCancelar.TabIndex = 13;
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
        /// AÇÃO PARA GARANTIR QUE O DADOS OBRIGATÓRIOS SEJAM INSERIDOS
        /// 
        private bool ValidarCamposObrigatorios()
        {
            return !string.IsNullOrWhiteSpace(txtArea.Text)
                && !string.IsNullOrWhiteSpace(txtQntdPlantada.Text)
                && !string.IsNullOrWhiteSpace(txtCodProduto.Text);
        }

        private bool ValidarCamposObrigatoriosData()
        {

            string dataTexto = mskDtPlantio.Text;

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

        private bool ValidarCamposObrigatoriosDataColheita()

        {
            string dtColheira = mskDtColheita.Text;

            string dataNumerico = new string(dtColheira.Where(char.IsDigit).ToArray());

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
        /// EVENTO PARA QUANDO A TELA CARREGAR
        /// 
        private void AlterarProducao_Load(object sender, EventArgs e)
        {
            AcoesFuncionarios acoes = new AcoesFuncionarios();
            AcoesVendas acoesVendas = new AcoesVendas();

            mskDtPlantio.Text = acoes.preencherDadosExistentesDATA("data_plantio", "producao", "id_producao", txtIdProducao.Text).ToString();
            mskDtColheita.Text = acoes.preencherDadosExistentesDATA("data_prevista_colheita", "producao", "id_producao", txtIdProducao.Text).ToString();

            txtArea.Text = acoes.preencherDadosExistentes("area", "producao", "id_producao", txtIdProducao.Text);
            txtNomeArea.Text = acoes.preencherDadosExistentes("nome", "area", "id_area", txtArea.Text);

            txtCodProduto.Text = acoes.preencherDadosExistentes("id_produto", "producao", "id_producao", txtIdProducao.Text);
            txtProduto.Text = acoes.preencherDadosExistentes("desc_produto", "produtos", "id_produto", txtCodProduto.Text);
            txtQntdEstoque.Text = acoesVendas.preencherDadosExistentesINT("qntd_estoque", "produtos", "id_produto", txtCodProduto.Text).ToString();

            txtQntdPlantada.Text = acoesVendas.preencherDadosExistentesINT("qntd_plantada", "producao", "id_producao", txtIdProducao.Text).ToString();
        }



        ///
        /// VALIDAÇÕES DOS CAMPOS PARA GARANTIR INSERÇÃO CORRETA
        ///
        private bool ValidarCampoArea()
    {
        AcoesVendas acoes = new AcoesVendas();

        string tabela = acoes.PuxarDescFK("nome", "area", "id_area", txtArea.Text);

        return !string.IsNullOrWhiteSpace(tabela);
    }

        private void txtCodArea_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArea.Text) != true)
            {
                bool validacao = ValidarCampoArea();
                if (validacao == false)
                {
                    MessageBox.Show("Área inserida não cadastrada!", "Área inválido");
                    txtArea.Focus();
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
            if (!string.IsNullOrWhiteSpace(txtQntdPlantada.Text))
            {
                string qntdTexto = txtQntdPlantada.Text.Trim();

                if (int.TryParse(txtQntdEstoque.Text, out int qntdEstoque) && int.TryParse(txtQntdPlantada.Text, out int qntdProduto))
                {
                    if (qntdProduto > qntdEstoque)
                    {
                        MessageBox.Show("A quantidade não pode ser maior que a quantidade do produto em estoque", "Quantidade inválida");
                        txtQntdPlantada.Focus();
                    }
                    else if (qntdProduto <= 0)
                    {
                        MessageBox.Show("A quantidade deve ser maior que zero", "Quantidade inválida");
                        txtQntdPlantada.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Formato de número inválido.", "Erro de Formato");
                    txtQntdPlantada.Focus();
                }
            }
        }


        private bool ValidarCampoData()
        {
            string dataTexto = mskDtPlantio.Text;

            string dataNumerico = new string(dataTexto.Where(char.IsDigit).ToArray());

            if (dataNumerico.Length != 0)
            {
                if (DateTime.TryParse(mskDtPlantio.Text, out DateTime data))
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

        private bool ValidarCampoData2()
        {
            string dataTexto = mskDtColheita.Text;

            string dataNumerico = new string(dataTexto.Where(char.IsDigit).ToArray());

            if (dataNumerico.Length != 0)
            {
                if (DateTime.TryParse(mskDtPlantio.Text, out DateTime data))
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


        private void mskDtPlantio_Leave(object sender, EventArgs e)
        {
            if (mskDtPlantio.Text != null)
            {
                bool validacao = ValidarCampoData();
                if (validacao == false)
                {
                    MessageBox.Show("Data inválida!", "Data inválida");
                    mskDtPlantio.Focus();
                }
            }
        }


        private void mskDtColheita_Leave(object sender, EventArgs e)
        {
            if (mskDtColheita.Text != null)
            {
                bool validacao = ValidarCampoData2();
                if (validacao == false)
                {
                    MessageBox.Show("Data inválida!", "Data inválida");
                    mskDtColheita.Focus();
                }
            }
        }




        ///
        /// EVENTOS PARA PUXAR AS DESCRIÇÕES DOS CÓDIGOS 
        ///
        private void txtCodArea_TextChanged(object sender, EventArgs e)
        {
            AcoesProdutos acoes = new AcoesProdutos();

            txtNomeArea.Text = acoes.PuxarDescFK("nome", "area", "id_area", txtArea.Text);
        }


        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            AcoesProdutos acoesReutilizacao = new AcoesProdutos();
            AcoesVendas acoes = new AcoesVendas();


            txtProduto.Text = acoesReutilizacao.PuxarDescFK("desc_produto", "produtos", "id_produto", txtCodProduto.Text);
            txtQntdEstoque.Text = acoes.PuxarQntdEstoque("qntd_estoque", "produtos", "id_produto", txtCodProduto.Text).ToString();
        }



        /// 
        /// EVENTO DO BOTÃO "CONFIRMAR"
        /// 
        private void bttConfirmar_Click(object sender, EventArgs e)
        {

            if (ValidarCamposObrigatorios() && ValidarCamposObrigatoriosData() && ValidarCamposObrigatoriosDataColheita())
            {
                AcoesProducao acoes = new AcoesProducao();

                DateTime dtPlantio = DateTime.ParseExact(mskDtPlantio.Text, "dd/MM/yyyy", null);
                DateTime dtColheita = DateTime.ParseExact(mskDtColheita.Text, "dd/MM/yyyy", null);

                //  Insere cadastro no banco
                acoes.AtualizarDados(txtIdProducao.Text, txtCodProduto.Text, dtPlantio, dtColheita, txtQntdPlantada.Text, txtArea.Text);


                MessageBox.Show("Alteração feita com sucesso.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                formPrincipal.AtualizarDataGridView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Algum dado obrigatório não foi preenchido, favor verificar se todos os campos com asterisco (*) foram preenchidos.", "Erro de Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        /// 
        /// EVENTO DO BOTÃO BUSCA FK         
        /// 
        private void picBuscaArea_Click(object sender, EventArgs e)
        {
            TelaArea_alt telaArea = new TelaArea_alt(this);
            telaArea.Show();
        }

        private void picBuscaProduto_Click(object sender, EventArgs e)
        {
            Tela_Extras.VisualizarProduto_alt telaProduto = new Tela_Extras.VisualizarProduto_alt(this);
            telaProduto.Show();
        }


        public void SetAreaCode(string codigo)
        {
            txtArea.Text = codigo;
        }

        public void SetProdutoCode(string codigo)
        {
            txtCodProduto.Text = codigo;
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