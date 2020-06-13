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
    public partial class formMensagemCancelarVenda : Form
    {
        formFinalizacaoVenda pai;
        public formMensagemCancelarVenda(formFinalizacaoVenda _pai)
        {
            InitializeComponent();
            pai = _pai;
            btn_OK.Enabled = false;
            btn_OK.Visible = false;
            lbl_ok.Visible = false;
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            pai.decisaocancelar = true;
            btn_nao.Visible = false;
            btn_sim.Visible = false;
            btn_sim.Enabled = false;
            btn_nao.Enabled = false;
            lbl_mensagem.Visible = false;
            btn_OK.Enabled = true;
            btn_OK.Visible = true;
            lbl_ok.Visible = true;
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            pai.decisaocancelar = false;
            Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
