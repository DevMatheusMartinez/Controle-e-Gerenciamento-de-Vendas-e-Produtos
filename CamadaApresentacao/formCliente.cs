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
        string idcliente;
        public formCliente()
        {
            InitializeComponent();
        }

        public void dimensionarColunas()
        {
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
            Mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            formEditarCliente form = new formEditarCliente(idcliente);
            form.ShowDialog();
            Mostrar();
        }

        private void lista_clientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idcliente = Convert.ToString(this.lista_clientes.CurrentRow.Cells["ID_CLIENTE"].Value);
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja deletar este cliente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(confirm.ToString().ToUpper() == "YES")
            {
                string resp = "";
                resp = NTelefone.DeletarTelefone(Convert.ToInt32(idcliente));
                resp = NCliente.DeletarCliente(Convert.ToInt32(idcliente));
                Mostrar();
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar.Text != "Buscar...")
            {
                NCliente.FiltrarDados(txt_buscar, lista_clientes);
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
    }
}
