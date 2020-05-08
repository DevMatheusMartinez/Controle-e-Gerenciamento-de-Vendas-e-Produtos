using CamadaDados;
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
    public partial class formCadastrarMarcaCategoria : Form
    {
        string modeloatributo;
        public formCadastrarMarcaCategoria(string atributo)
        {
            InitializeComponent();
            lbl_mensagem.Visible = false;
            modeloatributo = atributo;
            if(atributo == "Categoria")
            {
                lbl_nome.Text = "Nome da Categoria:";
                lbl_titulo.Text = "Cadastrar Categoria";
            }
            else
            {
                lbl_nome.Text = "Nome da Marca:";
                lbl_titulo.Text = "Cadastrar Marca";
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string resp = "";
            if (txt_nome.Text == "")
            {
                lbl_mensagem.Text = "Digite o nome da " + modeloatributo;
                lbl_mensagem.Visible = true;
            }
            else
            {
                if (modeloatributo == "Categoria")
                {
                    resp = NCategoria.InserirCategoria(txt_nome.Text);
                    Close();
                }
                else
                {
                    resp = NMarca.InserirMarca(txt_nome.Text);
                    Close();
                }
            }



            
        }
    }
}
