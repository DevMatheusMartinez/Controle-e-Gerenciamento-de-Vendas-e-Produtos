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
    public partial class formMensagemClienteDeletado : Form
    {
        public formMensagemClienteDeletado(string idcliente)
        {
            InitializeComponent();
            btn_ok.Visible = false;
            btn_ok.Enabled = false;
            lbl_confirmado.Visible = false;
            string[] dados = new string[5];
            dados = NCliente.CarregarDadosCliente(idcliente, "ID_CLIENTE");
            lbl_cliente.Text = dados[1];
            


        }
    }
}
