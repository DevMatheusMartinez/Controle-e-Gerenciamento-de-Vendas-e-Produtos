using CamadaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class formMensagemCaixaFinalizacao : Form
    {
        decimal _precototallista;
        string _datapedido, _vencimento, _formapagamento;
        int _cliente, _idficha;
        DataGridView _datagrid;
        formFinalizacaoVenda _pai;

        public formMensagemCaixaFinalizacao(decimal precototallista, string datapedido, string vencimento, int cliente, string formapagamento, formFinalizacaoVenda pai, DataGridView datagrid)
        {
            InitializeComponent();
            btn_OK.Enabled = false;
            btn_OK.Visible = false;
            lbl_ok.Visible = false;
            this._precototallista = precototallista;
            this._datapedido = datapedido;
            this._vencimento = vencimento;
            this._cliente = cliente;
            this._formapagamento = formapagamento;
            this._datagrid = datagrid;
            this._pai = pai;
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            string resp = "";

            resp = NFicha.InserirFicha("Ficha " + Convert.ToString(NFicha.CarregarUltimoIdFicha() + 1), _precototallista, _datapedido, _datapedido, _vencimento, "Pago", _formapagamento, _cliente);
            for (int i = 0; i < _datagrid.Rows.Count - 1; i++)
             {
                resp = NProduto_Comprado.InserirProdutoComprado(Convert.ToInt32(_datagrid.Rows[i].Cells[3].Value), NFicha.CarregarUltimoIdFicha(), Convert.ToInt32(_datagrid.Rows[i].Cells[0].Value), Convert.ToString(_datagrid.Rows[i].Cells[4].Value));

                resp = NProduto.EditarEstoque(Convert.ToInt32(_datagrid.Rows[i].Cells[0].Value), NOperacao.SubtrairEstoque(Convert.ToInt32(_datagrid.Rows[i].Cells[0].Value), Convert.ToInt32(_datagrid.Rows[i].Cells[3].Value)));
            }
            _pai.decisao = true;
            
            btn_nao.Enabled = false;
            btn_sim.Enabled = false;
            btn_nao.Visible = false;
            btn_sim.Visible = false;
            lbl_mensagem.Visible = false;
            lbl_ok.Visible = true;
            btn_OK.Visible = true;
            btn_OK.Enabled = true;
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_ok_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
