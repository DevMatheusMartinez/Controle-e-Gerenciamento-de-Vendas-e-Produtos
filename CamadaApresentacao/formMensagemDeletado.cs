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
    public partial class formMensagemDeletado : Form
    {
        int idproduto;
        public formMensagemDeletado(int id)
        {
            InitializeComponent();
            string[] dados = new string[5];
            dados = NProduto.CarregarDadosProduto(id);
            lbl_nome_produto.Text = dados[0];
            lbl_nome_produto.AutoSize = false;
            lbl_nome_produto.Dock = DockStyle.Fill; 
            lbl_nome_produto.TextAlign = ContentAlignment.MiddleCenter;

            lbl_mensagem.Visible = true;
            lbl_nome_produto.Visible = true;
            btn_não.Visible = true;
            btn_sim.Visible = true;
            btn_não.Enabled = true;
            btn_sim.Enabled = true;

            btn_ok.Visible = false;
            lbl_sucesso.Visible = false;
            btn_ok.Enabled = false;

            idproduto = id;

        }

        private void btn_não_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            string resp = "";
            resp = NProduto.DeletarProduto(idproduto);

            lbl_mensagem.Visible = false;
            lbl_nome_produto.Visible = false;
            btn_não.Visible = false;
            btn_sim.Visible = false;
            btn_não.Enabled = false;
            btn_sim.Enabled = false;

            btn_ok.Visible = true;
            lbl_sucesso.Visible = true;
            btn_ok.Enabled = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
