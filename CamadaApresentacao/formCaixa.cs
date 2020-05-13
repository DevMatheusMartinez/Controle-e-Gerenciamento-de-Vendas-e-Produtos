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
    public partial class formCaixa : Form
    {
        decimal precototallista;
        int idproduto, itemproduto;
        List<decimal> precolista = new List<decimal>();
        public formCaixa()
        {
            InitializeComponent();
        }

        public void Mostrar()
        {
            lista_produtos.DataSource = NProduto.MostrarCaixa();
            lista_produtos.Columns[0].HeaderText = "CÓDIGO";
            lista_produtos.Columns[1].HeaderText = "NOME";
            lista_produtos.Columns[2].HeaderText = "CATEGORIA";
            lista_produtos.Columns[3].HeaderText = "MARCA";
            lista_produtos.Columns[4].HeaderText = "PREÇO";
            lista_produtos.Columns[4].DefaultCellStyle.Format = "c";
            lista_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void formCaixa_Load(object sender, EventArgs e)
        {
            Conexao.criarBanco();
            lista_produtos.BorderStyle = BorderStyle.None;
            lista_produtos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_produtos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_produtos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_produtos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            lista_produtos.EnableHeadersVisualStyles = false;
            lista_produtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_produtos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_produtos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            lista_carrinho.ColumnCount = 6;
            lista_carrinho.Columns[0].Name = "Código";
            lista_carrinho.Columns[1].Name = "Nome";
            lista_carrinho.Columns[2].Name = "Categoria";
            lista_carrinho.Columns[3].Name = "Marca";
            lista_carrinho.Columns[4].Name = "Quantidade";
            lista_carrinho.Columns[5].Name = "Preço";
            lista_carrinho.Columns[5].DefaultCellStyle.Format = "c";
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

            Mostrar();

            for (int i = 0; i < 5; i++)
            {
                lista_produtos.Columns[i].ReadOnly = true;
            }

            for (int i = 0; i < 6; i++)
            {
                lista_carrinho.Columns[i].ReadOnly = true;
            }
        }

        private void lista_produtos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idproduto = Convert.ToInt32(this.lista_produtos.CurrentRow.Cells["ID_PRODUTO"].Value);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            String codigo, nome, categoria, marca, quantidade, preco;
            decimal precototal;
            string[] dados = new string[6];
            dados = NProduto.CarregarDadosProduto(idproduto);
            codigo = dados[0];
            nome = dados[1];
            categoria = dados[2];
            marca = dados[3];
            preco = dados[4];
            quantidade = Convert.ToString(num_quantidade.Value);
            precototal = NOperacao.CalcularValorQuantidade(Convert.ToInt32(quantidade), Convert.ToDecimal(preco));

            this.lista_carrinho.Rows.Insert(0, codigo, nome, categoria, marca, quantidade, precototal) ;
            precolista.Insert(0, precototal);

            precototallista = NOperacao.SomarValorTotal(precolista);

            lbl_total.Text = "Total: " + precototallista.ToString("C2", CultureInfo.CurrentCulture);

            numerarGrid(lista_carrinho);
        }

        private void lista_carrinho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (itemproduto >= 0 && itemproduto < precolista.Count)
            {
                NOperacao.SubtrairValorTotal(precolista, itemproduto);
                precototallista = NOperacao.SomarValorTotal(precolista);
                lbl_total.Text = "Valor Total: " + precototallista.ToString("C2", CultureInfo.CurrentCulture);
                this.lista_carrinho.Rows.RemoveAt(itemproduto);
                numerarGrid(lista_carrinho);
            }
        }

        private void lista_carrinho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            itemproduto = Convert.ToInt32(lista_carrinho.CurrentCell.RowIndex);
        }



        public void numerarGrid(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                for (int count = 0; (count <= (dataGridView.Rows.Count - 1)); count++)
                {
                    dataGridView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
        }
    }
}
