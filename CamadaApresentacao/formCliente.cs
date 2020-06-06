using CamadaDados;
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
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }

        public void dimensionarColunas()
        {
            lista_clientes.Columns[0].Width = 102;
            lista_clientes.Columns[1].Width = 533;
            lista_clientes.Columns[2].Width = 164;
            lista_clientes.Columns[3].Width = 148;
            lista_clientes.Columns[4].Width = 148;
            lista_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Mostrar()
        {
            this.lista_clientes.DataSource = NCliente.Mostrar();
            lista_clientes.Columns[0].HeaderText = "CÓDIGO";
            lista_clientes.Columns[1].HeaderText = "NOME";
            lista_clientes.Columns[2].HeaderText = "CPF";
            lista_clientes.Columns[3].HeaderText = "ENDEREÇO";
            lista_clientes.Columns[4].HeaderText = "EMAIL";
            lista_clientes.Columns.Add("telefone", "Telefones");

            dimensionarColunas();
        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            txt_buscar.Text = "Buscar...";
            Conexao.criarBanco();
            lista_clientes.BorderStyle = BorderStyle.None;
            lista_clientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_clientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_clientes.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_clientes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lista_clientes.BackgroundColor = Color.White;

            lista_clientes.EnableHeadersVisualStyles = false;
            lista_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_clientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Mostrar();

            for (int i = 0; i < 5; i++)
            {
                lista_clientes.Columns[i].ReadOnly = true;
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            formCadastrarCliente form = new formCadastrarCliente();
            form.ShowDialog();
        }
    }
}
