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
    public partial class formFichaCompra : Form
    {
        int codcliente, idficha;
        decimal precototal;
        string valor;
        string[] dados = new string[13];
        private Timer timerverificador = new Timer();
        public formFichaCompra(string ficha)
        {
            InitializeComponent();
            Dictionary<string, int> dicformapagamento = new Dictionary<string, int>();
            dicformapagamento.Add("Dinheiro", 0);
            dicformapagamento.Add("Crédito", 1);
            dicformapagamento.Add("Débito", 2);

            
            dados = NFicha.CarregarDadosFicha(ficha);
            codcliente = Convert.ToInt32(dados[6]);
            precototal = Convert.ToDecimal(dados[2]);
            idficha = Convert.ToInt32(dados[0]);

            txt_dinheiro.Text = " 0,00";
            lbl_titulo.Text = dados[1].ToUpper();
            lbl_data_compra.Text = dados[3];
            lbl_pagamento.Text = dados[4];
            lbl_vencimento.Text = dados[5];
            lbl_nome.Text = dados[9];
            mtxt_cpf.Text = dados[10];
            lbl_endereco.Text = dados[11];
            lbl_email.Text = dados[12];
            lbl_situacao.Text = dados[8];
            lbl_valortotal.Text = " " + precototal.ToString("N2", CultureInfo.CurrentCulture);

            combo_pagamento.SelectedIndex = 0;

            if(dados[8] == "Pago")
            {
                combo_pagamento.SelectedIndex = dicformapagamento[dados[7]];
                combo_pagamento.Enabled = false;
                btn_pagar.Enabled = false;
                txt_dinheiro.Enabled = false;
            }

            mostrar(Convert.ToInt32(dados[0]));
        }

        public void mostrar(int idficha)
        {
            lista_produtos_comprados.BorderStyle = BorderStyle.None;
            lista_produtos_comprados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_produtos_comprados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_produtos_comprados.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_produtos_comprados.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lista_produtos_comprados.BackgroundColor = Color.White;

            lista_produtos_comprados.EnableHeadersVisualStyles = false;
            lista_produtos_comprados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_produtos_comprados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_produtos_comprados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.lista_produtos_comprados.DataSource = NProduto_Comprado.mostrarProdutosComprados(idficha);

            lista_produtos_comprados.Columns[0].HeaderText = "NOME";
            lista_produtos_comprados.Columns[1].HeaderText = "QUANTIDADE";
            lista_produtos_comprados.Columns[2].HeaderText = "VALOR TOTAL";

            lista_produtos_comprados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < 3; i++)
            {
                lista_produtos_comprados.Columns[i].ReadOnly = true;
            }

            NOperacao.numerarGrid(lista_produtos_comprados);
        }

        private void formFichaCompra_Load(object sender, EventArgs e)
        {
            timerverificador.Interval = 1;
            timerverificador.Enabled = true;
            timerverificador.Tick += new EventHandler(verificador_Tick);
        }

        private void btn_lista_telefone_Click(object sender, EventArgs e)
        {
            formTelefones form = new formTelefones(codcliente);
            form.ShowDialog();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {

        }

        private void verificador_Tick(object sender, EventArgs e)
        {
            if (txt_dinheiro.Text != " 0,00")
            {
                decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
                decimal total = Convert.ToDecimal(lbl_valortotal.Text);
                lbl_troco.Text = NOperacao.SubtrairValor(dinheiro, total).ToString("N2", CultureInfo.CurrentCulture);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(txt_dinheiro.Text) < Convert.ToDecimal(lbl_valortotal.Text) && combo_pagamento.SelectedIndex == 0)
            {
                MessageBox.Show("Dinheiro insuficiente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string resp = "";
                resp = NFicha.EditarFicha(Convert.ToInt32(dados[0]), NOperacao.DataAtual(), "Pago", combo_pagamento.SelectedItem.ToString());
                MessageBox.Show("Ficha paga com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
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

        private void combo_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(combo_pagamento.SelectedIndex == 0))
            {
                txt_dinheiro.Enabled = false;
            }
            else
            {
                txt_dinheiro.Enabled = true;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
