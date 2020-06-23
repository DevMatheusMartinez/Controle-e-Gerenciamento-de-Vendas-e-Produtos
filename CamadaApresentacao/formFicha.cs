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
    public partial class formFicha : Form
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        string ficha;
        public formFicha()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            lista_fichas.BorderStyle = BorderStyle.None;
            lista_fichas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_fichas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_fichas.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_fichas.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lista_fichas.BackgroundColor = Color.White;

            lista_fichas.EnableHeadersVisualStyles = false;
            lista_fichas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_fichas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_fichas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            lista_fichas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.lista_fichas.DataSource = NFicha.Mostrar();

            lista_fichas.Columns[0].HeaderText = "FICHA";
            lista_fichas.Columns[1].HeaderText = "CLIENTE";
            lista_fichas.Columns[2].HeaderText = "DATA DA COMPRA";
            lista_fichas.Columns[3].HeaderText = "DATA DO PAGAMENTO";
            lista_fichas.Columns[4].HeaderText = "DATA DO VENCIMENTO";
            lista_fichas.Columns[5].HeaderText = "PREÇO";
            lista_fichas.Columns[6].HeaderText = "SITUAÇÃO";
            lista_fichas.Columns[5].DefaultCellStyle.Format = "c";
        }

        private void formFicha_Load(object sender, EventArgs e)
        {
            dic.Add("Ficha", 0);
            dic.Add("Cliente", 1);
            dic.Add("Data de compra", 2);
            dic.Add("Data de vencimento", 3);
            dic.Add("Data de pagamento", 4);
            dic.Add("Preço", 5);
            dic.Add("Situação", 6);

            Mostrar();

            DataGridViewButtonColumn fichaButtonColumn = new DataGridViewButtonColumn();
            fichaButtonColumn.UseColumnTextForButtonValue = true;
            fichaButtonColumn.HeaderText = "";
            fichaButtonColumn.Name = "abrirFicha";
            fichaButtonColumn.Text = "Abrir ficha";
            fichaButtonColumn.FlatStyle = FlatStyle.Flat;

            lista_fichas.Columns.Insert(lista_fichas.Columns.Count, fichaButtonColumn);

            OrdenarCombo.SelectedIndex = 1;

            for (int i = 0; i < lista_fichas.ColumnCount; i++)
            {
                lista_fichas.Columns[i].ReadOnly = true;
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Buscar...";
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar.Text != "Buscar...")
            {
                NFicha.FiltrarDados(txt_buscar, lista_fichas);
            }
        }

        private void OrdenarCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            lista_fichas.Sort(lista_fichas.Columns[dic[Convert.ToString(OrdenarCombo.SelectedItem)]], ListSortDirection.Ascending);
        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Buscar...")
            {
                txt_buscar.Text = "";
            }
        }

        private void lista_fichas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ficha = Convert.ToString(this.lista_fichas.CurrentRow.Cells["IDENTIFICACAO_FICHA"].Value);
        }

        private void lista_fichas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formFichaCompra form = new formFichaCompra(ficha);
            form.ShowDialog();
            Mostrar();
        }

        private void lista_fichas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                formFichaCompra form = new formFichaCompra(ficha);
                form.ShowDialog();
                Mostrar();
            }
        }
    }
}
