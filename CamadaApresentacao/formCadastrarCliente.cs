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
    public partial class formCadastrarCliente : Form
    {
        List<string> lista_numero = new List<string>();
        public formCadastrarCliente()
        {
            InitializeComponent();
            lbl_mensagem_nome.Visible = false;
            lbl_mensagem_endereco.Visible = false;
            lbl_mensagem_email.Visible = false;
            lbl_mensagem_cpf.Visible = false;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            lista_numero.Add(txt_numero.Text);
            lista_de_numeros_telefone.DataSource = null;
            lista_de_numeros_telefone.DataSource = lista_numero;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string resp = "";
            if (txt_nome.Text != "")
            {
                if (ValidarDados.ValidarCpf(mtxt_cpf.Text))
                {
                    if(txt_endereco.Text != "")
                    {
                        if (ValidarDados.validarEmail(txt_email.Text))
                        {
                            resp = NCliente.InserirCliente(ValidarDados.arrumarTexto(txt_nome.Text), mtxt_cpf.Text, ValidarDados.arrumarTexto(txt_endereco.Text), ValidarDados.arrumarTexto(txt_email.Text));
                            int idcliente = NCliente.CarregarUltimoIdCliente();
                            foreach (string numero in lista_numero)
                            {
                                resp = NTelefone.InserirTelefone(numero, idcliente);
                            }
                            Close();
                        }
                        else
                        {
                            lbl_mensagem_nome.Visible = false;
                            lbl_mensagem_email.Visible = true;
                            lbl_mensagem_cpf.Visible = false;
                            lbl_mensagem_endereco.Visible = false;
                        }
                    }
                    else
                    {
                        lbl_mensagem_nome.Visible = false;
                        lbl_mensagem_email.Visible = false;
                        lbl_mensagem_cpf.Visible = false;
                        lbl_mensagem_endereco.Visible = true;
                    }
                }
                else
                {
                    lbl_mensagem_nome.Visible = false;
                    lbl_mensagem_email.Visible = false;
                    lbl_mensagem_cpf.Visible = true;
                    lbl_mensagem_endereco.Visible = false;
                }
            }
            else
            {
                lbl_mensagem_nome.Visible = true;
                lbl_mensagem_email.Visible = false;
                lbl_mensagem_cpf.Visible = false;
                lbl_mensagem_endereco.Visible = false;
            }
                
        }
    }
}
