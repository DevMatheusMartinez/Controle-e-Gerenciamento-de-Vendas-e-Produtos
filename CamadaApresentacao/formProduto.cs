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
        public formProduto()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            this.lista_produtos.DataSource = NProduto.Mostrar();
        }

        private void formProduto_Load(object sender, EventArgs e)
        {
            txt_buscar.Text = "Buscar...";
            Mostrar();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            formCadastrarProduto form = new formCadastrarProduto();
            form.ShowDialog();
        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
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
    }
}
