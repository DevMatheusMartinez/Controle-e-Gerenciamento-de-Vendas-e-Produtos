using CamadaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class formEditarProduto : Form
    {
        string valor;
        bool sucesso = false;
        int idproduto;
        public formEditarProduto(int id)
        {
            InitializeComponent();

            NMarca.preencherCBMarca(comboMarca);
            comboMarca.DropDownStyle = ComboBoxStyle.DropDown;
            comboMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            NCategoria.preencherCBCategoria(comboCategoria);
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            comboCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

            idproduto = id;

            string[] dados = new string[6];
            dados = NProduto.CarregarDadosProduto(id);
            txt_nome.Text = dados[1];
            comboCategoria.Text = dados[2];
            comboMarca.Text = dados[3];
            txt_preco.Text = dados[4];
            quantidade_num.Value = Convert.ToDecimal(dados[5]);

            criarModoMoeda();
        }

        public void criarModoMoeda()
        {
            try
            {
                valor = txt_preco.Text.Replace("R$", "");
                txt_preco.Text = string.Format("{0:C}", Convert.ToDecimal(valor));
            }
            catch
            {

            }
            
        }

        public void reverterFormulario()
        {
            lbl_mensagem.Visible = false;
            btn_ok.Visible = false;
            lbl_categoria.Visible = true;
            lbl_marca.Visible = true;
            lbl_preco.Visible = true;
            lbl_quantidade.Visible = true;
            lbl_titulo.Visible = true;
            lbl_usuario.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            txt_nome.Visible = true;
            txt_preco.Visible = true;
            comboCategoria.Visible = true;
            comboMarca.Visible = true;
            quantidade_num.Visible = true;
            btn_editar.Visible = true;
            btn_categoria.Visible = true;
            btn_marca.Visible = true;
            btn_limpar.Visible = true;
            btn_ok.Visible = false;

            txt_nome.Enabled = true;
            txt_preco.Enabled = true;
            comboCategoria.Enabled = true;
            comboMarca.Enabled = true;
            quantidade_num.Enabled = true;
            btn_editar.Enabled = true;
            btn_categoria.Enabled = true;
            btn_marca.Enabled = true;
            btn_limpar.Enabled = true;
            btn_ok.Enabled = false;
        }

        public void mostrarMensagem(string mensagem, int x_location)
        {
            lbl_mensagem.Visible = true;
            btn_ok.Visible = true;
            lbl_categoria.Visible = false;
            lbl_marca.Visible = false;
            lbl_preco.Visible = false;
            lbl_quantidade.Visible = false;
            lbl_titulo.Visible = false;
            lbl_usuario.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            txt_nome.Visible = false;
            txt_preco.Visible = false;
            comboCategoria.Visible = false;
            comboMarca.Visible = false;
            quantidade_num.Visible = false;
            btn_editar.Visible = false;
            btn_categoria.Visible = false;
            btn_marca.Visible = false;
            btn_limpar.Visible = false;
            btn_ok.Visible = true;

            txt_nome.Enabled = false;
            txt_preco.Enabled = false;
            comboCategoria.Enabled = false;
            comboMarca.Enabled = false;
            quantidade_num.Enabled = false;
            btn_editar.Enabled = false;
            btn_categoria.Enabled = false;
            btn_marca.Enabled = false;
            btn_limpar.Enabled = false;
            btn_ok.Enabled = true;

            lbl_mensagem.Text = mensagem;
            lbl_mensagem.Location = new Point(x_location, lbl_mensagem.Location.Y);
        }

        private void formEditarProduto_Load(object sender, EventArgs e)
        {
            reverterFormulario();

            lbl_mensagem_nome.Visible = false;
            lbl_mensagem_preco.Visible = false;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            comboCategoria.SelectedIndex = 1;
            comboMarca.SelectedIndex = 1;
            txt_nome.Text = "";
            quantidade_num.Value = 0;
            txt_preco.Text = "R$ 0,00";
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            formCadastrarMarcaCategoria form = new formCadastrarMarcaCategoria("Categoria");
            form.ShowDialog();
            NCategoria.preencherCBCategoria(comboCategoria);
            comboCategoria.SelectedIndex = comboCategoria.Items.Count - 1;
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            formCadastrarMarcaCategoria form = new formCadastrarMarcaCategoria("Marca");
            form.ShowDialog();
            NMarca.preencherCBMarca(comboMarca);
            comboMarca.SelectedIndex = comboMarca.Items.Count - 1;
        }

        private void txt_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt_preco.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txt_preco_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txt_preco.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txt_preco.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txt_preco.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txt_preco.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt_preco.Text.StartsWith("0,"))
                {
                    txt_preco.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt_preco.Text.Contains("00,"))
                {
                    txt_preco.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt_preco.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txt_preco.Text;
            txt_preco.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txt_preco.Select(txt_preco.Text.Length, 0);
        }

        private void txt_preco_Leave(object sender, EventArgs e)
        {
            criarModoMoeda();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                lbl_mensagem_nome.Visible = true;
                sucesso = false;
            }
            else if (txt_preco.Text == "R$ 0,00")
            {
                lbl_mensagem_preco.Visible = true;
                sucesso = false;
            }
            else
            {
                int quantidade = Convert.ToInt32(quantidade_num.Value);
                string preco = txt_preco.Text.Replace(".", ",");
                preco = preco.Replace("R$", "").Trim();

                string resp = "";
                resp = NProduto.EditarProduto(idproduto, txt_nome.Text, comboCategoria.Text, comboMarca.Text, Convert.ToDecimal(preco), quantidade);
                sucesso = true;
                mostrarMensagem("Produto editado com sucesso", 43);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (sucesso)
            {
                Close();
            }
            else
            {
                reverterFormulario();
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            lbl_mensagem_nome.Visible = false;
        }

        private void txt_preco_TextChanged(object sender, EventArgs e)
        {
            lbl_mensagem_preco.Visible = false;
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboCategoria.SelectedIndex == 0)
            {
                comboCategoria.SelectedIndex = 1;
            }
        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboMarca.SelectedIndex == 0)
            {
                comboMarca.SelectedIndex = 1;
            }
        }
    }
}

