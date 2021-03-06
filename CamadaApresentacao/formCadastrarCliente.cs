﻿using CamadaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            lbl_mensagem_telefone.Visible = false;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(txt_numero.MaskCompleted == true)
            {
                lista_numero.Add(txt_numero.Text);
                lista_de_numeros_telefone.DataSource = null;
                lista_de_numeros_telefone.DataSource = lista_numero;
                txt_numero.Text = "";
                lbl_mensagem_telefone.Visible = false;
            }
            else
            {
                lbl_mensagem_telefone.Visible = true;
            }
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            bool existeCaracterEspecial = Regex.IsMatch(txt_nome.Text, (@"[^a-zA-Z0-9 áàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]"));
            string resp = "";
            if (txt_nome.Text != "" && !existeCaracterEspecial)
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
                            formMensagemCadastroCliente form = new formMensagemCadastroCliente();
                            form.ShowDialog();
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

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsWhiteSpace(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            } 
        }

        private void formCadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_endereco.Text = "";
            txt_numero.Text = "";
            txt_email.Text = "";
            mtxt_cpf.Text = "";
            lista_de_numeros_telefone.DataSource = null;
            lista_numero.Clear();
            lbl_mensagem_nome.Visible = false;
            lbl_mensagem_endereco.Visible = false;
            lbl_mensagem_email.Visible = false;
            lbl_mensagem_cpf.Visible = false;
            lbl_mensagem_telefone.Visible = false;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lista_numero.Remove(Convert.ToString(lista_de_numeros_telefone.SelectedItem));
            lista_de_numeros_telefone.DataSource = null;
            lista_de_numeros_telefone.DataSource = lista_numero;
        }
    }
}
