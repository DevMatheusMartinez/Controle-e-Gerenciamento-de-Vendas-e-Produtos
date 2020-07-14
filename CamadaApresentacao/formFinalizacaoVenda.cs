using CamadaDados;
using CamadaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class formFinalizacaoVenda : Form
    {
        public bool decisao = false;
        public bool decisaocancelar = false;
        int idproduto, itemproduto;
        string[] dados = new string[6];
        string[] cliente = new string[5];
        decimal precototallista;
        List<decimal> precolista = new List<decimal>();
        string verifica = "1", valor;
        private Timer timerverificador = new Timer();
        formPrincipal _pai;

        public formFinalizacaoVenda(formPrincipal pai)
        {
            InitializeComponent();
            _pai = pai;
        }

        public void mostrarCarrinho()
        {
            lista_carrinho.ColumnCount = 6;
            lista_carrinho.Columns[0].Name = "Código";
            lista_carrinho.Columns[1].Name = "Nome";
            lista_carrinho.Columns[2].Name = "Preço";
            lista_carrinho.Columns[3].Name = "Quantidade";
            lista_carrinho.Columns[4].Name = "Valor Total";
            lista_carrinho.Columns[4].DefaultCellStyle.Format = "c";
            lista_carrinho.Columns[2].DefaultCellStyle.Format = "c";

            lista_carrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lista_carrinho.BorderStyle = BorderStyle.None;
            lista_carrinho.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_carrinho.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_carrinho.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_carrinho.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            lista_carrinho.EnableHeadersVisualStyles = false;
            lista_carrinho.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_carrinho.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_carrinho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void Mostrar()
        {
            lista_produtos.DataSource = NProduto.MostrarCaixa();
            lista_produtos.Columns[0].HeaderText = "CÓDIGO";
            lista_produtos.Columns[1].HeaderText = "DESCRIÇÃO";
            lista_produtos.Columns[2].HeaderText = "PREÇO";
            lista_produtos.Columns[2].DefaultCellStyle.Format = "c";

            lista_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lista_produtos.BorderStyle = BorderStyle.None;
            lista_produtos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_produtos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_produtos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_produtos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            lista_produtos.EnableHeadersVisualStyles = false;
            lista_produtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_produtos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_produtos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            for (int i = 0; i < 3; i++)
            {
                lista_produtos.Columns[i].ReadOnly = true;
            }

            timerverificador.Interval = 1;
            timerverificador.Enabled = true;
            timerverificador.Tick += new EventHandler(verificador_Tick);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formFinalizacaoVenda_Load(object sender, EventArgs e)
        {
            Mostrar();
            mostrarCarrinho();
            txt_dinheiro.Text = " 0,00";
            NCliente.preencherCBCliente(comboCliente);
            comboCliente.DropDownStyle = ComboBoxStyle.DropDown;
            comboCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboCliente.SelectedIndex = 1;
            comboPagamento.SelectedIndex = 0;
            txt_dataPedido.Text = NOperacao.DataAtual();
            txt_vencimento.Text = NOperacao.DataVencimento();
        }

        private void lista_produtos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idproduto = Convert.ToInt32(this.lista_produtos.CurrentRow.Cells["ID_PRODUTO"].Value);
            dados = NProduto.CarregarDadosProduto(idproduto);
            lbl_produto.Text = dados[0] + " - " + dados[1].ToUpper();
            txt_precoUnitario.Text = Convert.ToDecimal(dados[4]).ToString("N2", CultureInfo.CurrentCulture);
            txt_valorTotalProduto.Text = NOperacao.CalcularValorQuantidade(Convert.ToInt32(numericQuantidade.Text), Convert.ToDecimal(dados[4])).ToString("N2", CultureInfo.CurrentCulture);
        }

        private void numericQuantidade_Leave(object sender, EventArgs e)
        {
           
        }

        private void verificador_Tick(object sender, EventArgs e)
        {
            if(Convert.ToString(numericQuantidade.Value) != verifica)
            {
                txt_valorTotalProduto.Text = NOperacao.CalcularValorQuantidade(Convert.ToInt32(numericQuantidade.Text), Convert.ToDecimal(dados[4])).ToString("N2", CultureInfo.CurrentCulture);
                verifica = Convert.ToString(numericQuantidade.Value);
            }

            if(txt_dinheiro.Text != " 0,00")
            {
                try
                {
                    decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
                    decimal total = Convert.ToDecimal(txt_valorTotalCarrinho.Text);
                    txt_troco.Text = NOperacao.SubtrairValor(dinheiro, total).ToString("N2", CultureInfo.CurrentCulture);
                }
                catch
                {

                }
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            String codigo, nome, quantidade, preco;
            decimal precototal;
            string[] dados = new string[6];
            dados = NProduto.CarregarDadosProduto(idproduto);
            codigo = dados[0];
            nome = dados[1];
            preco = dados[4];
            quantidade = Convert.ToString(numericQuantidade.Value);
            precototal = NOperacao.CalcularValorQuantidade(Convert.ToInt32(quantidade), Convert.ToDecimal(preco));

            if (NOperacao.VerificarExistenciaProduto(lista_carrinho, Convert.ToInt32(codigo)))
            {
               NOperacao.SomarQuantidadeDatagrid(lista_carrinho, NOperacao.RetornarLinha(lista_carrinho, Convert.ToInt32(codigo)), Convert.ToInt32(numericQuantidade.Value), Convert.ToDecimal(preco));
            }
            else
            {
                this.lista_carrinho.Rows.Insert(0, codigo, nome, preco, quantidade, precototal);
            }

            NOperacao.CalcularListaValorQuantidade(Convert.ToInt32(quantidade), Convert.ToDecimal(preco), precolista);
            precototallista = NOperacao.SomarValorTotal(precolista);
            txt_valorTotalCarrinho.Text = precototallista.ToString("N2", CultureInfo.CurrentCulture);
            NOperacao.numerarGrid(lista_carrinho);
        }

        private void lista_carrinho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            itemproduto = Convert.ToInt32(lista_carrinho.CurrentCell.RowIndex);
        }

        private void txt_dinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt_dinheiro.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            cliente = NCliente.CarregarDadosCliente(comboCliente.Text, "NOME_CLIENTE");
            decimal troco = Convert.ToDecimal(txt_troco.Text);
            decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
            if(precolista.Count > 0)
            {
                formMensagemCaixa form = new formMensagemCaixa(precototallista, txt_dataPedido.Text, txt_vencimento.Text, Convert.ToInt32(cliente[0]), Convert.ToString(comboPagamento.SelectedValue), this, lista_carrinho);
                form.ShowDialog();
                if (decisao)
                {
                    _pai.AbrirFormInPanel(new formFinalizacaoVenda(_pai));
                }
            }
            else
            {
                MessageBox.Show("Nenhum item no carrinho", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            cliente = NCliente.CarregarDadosCliente(comboCliente.Text, "NOME_CLIENTE");
            decimal troco = Convert.ToDecimal(txt_troco.Text);
            decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
            if(precolista.Count > 0)
            {
                if (troco >= 0 && dinheiro > 0)
                {
                    formMensagemCaixaFinalizacao form = new formMensagemCaixaFinalizacao(precototallista, txt_dataPedido.Text, txt_vencimento.Text, Convert.ToInt32(cliente[0]), Convert.ToString(comboPagamento.SelectedItem), this, lista_carrinho);
                    form.ShowDialog();
                    if (decisao)
                    {
                        _pai.AbrirFormInPanel(new formFinalizacaoVenda(_pai));
                    }
                }
                else
                {
                    MessageBox.Show("Dinheiro insuficiente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item no carrinho", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar.Text != "Buscar...")
            {
                NProduto.FiltrarDados(txt_buscar, lista_produtos, "C");
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Buscar...";
            }
        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Buscar...")
            {
                txt_buscar.Text = "";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            formMensagemCancelarVenda form = new formMensagemCancelarVenda(this);
            form.ShowDialog();
            if (decisaocancelar)
            {
                _pai.AbrirFormInPanel(new formFinalizacaoVenda(_pai));
            }
        }

        private void comboCliente_Leave(object sender, EventArgs e)
        {
            if (!NCliente.VerificarExistencia(comboCliente.Text))
            {
                MessageBox.Show("Cliente não existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCliente.Text = "Padrão";
            }
        }

        private void txt_vencimento_Leave(object sender, EventArgs e)
        {
            string[] data = new string[3];
            string datatexto = txt_dataPedido.Text;
            data = datatexto.Split('/');
            DateTime inicio = new DateTime(Convert.ToInt32(data[2]), Convert.ToInt32(data[1]), Convert.ToInt32(data[0]));
            datatexto = txt_vencimento.Text;
            data = datatexto.Split('/');
            if (Convert.ToInt32(data[1]) > 0 && Convert.ToInt32(data[1]) < 13)
            {
                if(data[2].Length == 4)
                {
                    DateTime fim = new DateTime(Convert.ToInt32(data[2]), Convert.ToInt32(data[1]), Convert.ToInt32(data[0]));

                    if (DateTime.Compare(inicio, fim) > 0)
                    {
                        MessageBox.Show("Data de vencimento da ficha inválida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_vencimento.Text = NOperacao.DataVencimento();
                    }
                }
                else
                {
                    MessageBox.Show("Data de vencimento da ficha inválida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_vencimento.Text = NOperacao.DataVencimento();
                }
            }
            else
            {
                MessageBox.Show("Data de vencimento da ficha inválida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_vencimento.Text = NOperacao.DataVencimento();
            }
            
            

        }

        private void txt_dinheiro_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txt_dinheiro.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txt_dinheiro.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txt_dinheiro.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txt_dinheiro.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt_dinheiro.Text.StartsWith("0,"))
                {
                    txt_dinheiro.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt_dinheiro.Text.Contains("00,"))
                {
                    txt_dinheiro.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt_dinheiro.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txt_dinheiro.Text;
            txt_dinheiro.Text = string.Format("{0:C}", Convert.ToDouble(valor)).Replace("R$", "");
            txt_dinheiro.Select(txt_dinheiro.Text.Length, 0);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (itemproduto >= 0 && itemproduto < lista_carrinho.Rows.Count - 1)
            {
                NOperacao.SubtrairValorTotal(precolista, itemproduto);
                precototallista = NOperacao.SomarValorTotal(precolista);
                txt_valorTotalCarrinho.Text = precototallista.ToString("N2", CultureInfo.CurrentCulture);
                NOperacao.SubtrairQuantidadeDatagrid(lista_carrinho, itemproduto);
                NOperacao.numerarGrid(lista_carrinho);
            }
        }
    }
}
