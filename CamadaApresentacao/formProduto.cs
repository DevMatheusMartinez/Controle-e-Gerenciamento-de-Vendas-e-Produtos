using CamadaDados;
using CamadaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class formProduto : Form
    {
        int idproduto;
        public formProduto()
        {
            InitializeComponent();
        }

        public void dimensionarColunas()
        {
            lista_produtos.Columns[0].Width = 102;
            lista_produtos.Columns[1].Width = 533;
            lista_produtos.Columns[2].Width = 164;
            lista_produtos.Columns[3].Width = 148;
            lista_produtos.Columns[4].Width = 148;
            lista_produtos.Columns[5].Width = 102;
            lista_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Mostrar()
        {
            this.lista_produtos.DataSource = NProduto.Mostrar();
            lista_produtos.Columns[0].HeaderText = "CÓDIGO";
            lista_produtos.Columns[1].HeaderText = "NOME";
            lista_produtos.Columns[2].HeaderText = "CATEGORIA";
            lista_produtos.Columns[3].HeaderText = "MARCA";
            lista_produtos.Columns[4].HeaderText = "PREÇO";
            lista_produtos.Columns[4].DefaultCellStyle.Format = "c";
            lista_produtos.Columns[5].HeaderText = "QUANTIDADE EM ESTOQUE";

            dimensionarColunas();
        }

        private void formProduto_Load(object sender, EventArgs e)
        {
            txt_buscar.Text = "Buscar...";
            Conexao.criarBanco();
            lista_produtos.BorderStyle = BorderStyle.None;
            lista_produtos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_produtos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_produtos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_produtos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lista_produtos.BackgroundColor = Color.White;

            lista_produtos.EnableHeadersVisualStyles = false;
            lista_produtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_produtos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_produtos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Mostrar();

            for(int i = 0; i<6; i++)
            {
                lista_produtos.Columns[i].ReadOnly = true;
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            formCadastrarProduto form = new formCadastrarProduto();
            form.ShowDialog();
            Mostrar();
        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            if(txt_buscar.Text == "Buscar...")
            {
                txt_buscar.Text = "";
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if(txt_buscar.Text == "")
            {
                txt_buscar.Text = "Buscar...";
            }
        }

        private void lista_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            formEditarProduto form = new formEditarProduto(idproduto);
            form.ShowDialog();
            Mostrar();
        }

        private void lista_produtos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idproduto = Convert.ToInt32(this.lista_produtos.CurrentRow.Cells["ID_PRODUTO"].Value);
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            formMensagemDeletado form = new formMensagemDeletado(idproduto);
            form.ShowDialog();
            Mostrar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if(txt_buscar.Text != "Buscar...")
            {
                NProduto.FiltrarDados(txt_buscar, lista_produtos);
            }
        }
    }
}
