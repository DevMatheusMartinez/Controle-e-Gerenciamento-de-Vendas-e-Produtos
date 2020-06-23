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
    public partial class formTelefones : Form
    {
        public formTelefones(int idcliente)
        {
            InitializeComponent();
            mostrar(idcliente);
        }

        public void mostrar(int _idcliente)
        {
            lista_telefones.BorderStyle = BorderStyle.None;
            lista_telefones.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lista_telefones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lista_telefones.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lista_telefones.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lista_telefones.BackgroundColor = Color.White;

            lista_telefones.EnableHeadersVisualStyles = false;
            lista_telefones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lista_telefones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 84, 84);
            lista_telefones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            lista_telefones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.lista_telefones.DataSource = NTelefone.mostrarTelefone(_idcliente);

            for (int i = 0; i < lista_telefones.ColumnCount; i++)
            {
                lista_telefones.Columns[i].ReadOnly = true;
            }
        }
    }
}
