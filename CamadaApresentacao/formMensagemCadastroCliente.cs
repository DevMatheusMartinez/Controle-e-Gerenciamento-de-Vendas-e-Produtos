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
    public partial class formMensagemCadastroCliente : Form
    {
        public formMensagemCadastroCliente()
        {
            InitializeComponent();
            lbl_mensagem2.Visible = false;
        }

        public formMensagemCadastroCliente(char editar)
        {
            InitializeComponent();
            lbl_mensagem.Visible = false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
