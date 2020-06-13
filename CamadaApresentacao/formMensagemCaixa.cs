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
    public partial class formMensagemCaixa : Form
    {
        decimal _precototallista;
        string _datapedido;
        string _vencimento;
        int _cliente;
        DataGridView _datagrid;
        formFinalizacaoVenda _pai;

        public formMensagemCaixa(decimal precototallista, string datapedido, string vencimento, int cliente, formFinalizacaoVenda pai, DataGridView datagrid)
        {
            InitializeComponent();
            this._precototallista = precototallista;
            this._datapedido = datapedido;
            this._vencimento = vencimento;
            this._cliente = cliente;
            this._pai = pai;
            this._datagrid = datagrid;
            lbl_ok.Visible = false;
            btn_OK.Visible = false;
            btn_OK.Enabled = false;
            
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            string resp = "", resp2 = "";
            resp = NFicha.InserirFicha("Ficha " + Convert.ToString(NFicha.CarregarUltimoIdFicha() + 1), _precototallista, _datapedido, "---", _vencimento, "Pendente", _cliente);
            for (int i = 0; i < _datagrid.Rows.Count-1; i++)
            {
                resp2 = NProduto_Comprado.InserirProdutoComprado(Convert.ToInt32(_datagrid.Rows[i].Cells[3].Value), NFicha.CarregarUltimoIdFicha(), Convert.ToInt32(_datagrid.Rows[i].Cells[0].Value));
            }
            btn_nao.Enabled = false;
            btn_sim.Enabled = false;
            btn_nao.Visible = false;
            btn_sim.Visible = false;
            lbl_mensagem.Visible = false;
            lbl_ok.Visible = true;
            btn_OK.Visible = true;
            btn_OK.Enabled = true;
            _pai.decisao = true;
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
