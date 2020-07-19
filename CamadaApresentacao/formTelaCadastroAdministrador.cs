using CamadaDados;
using CamadaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class formTelaCadastroAdministrador : Form
    {
        bool verifica = false;
        public formTelaCadastroAdministrador()
        {
            InitializeComponent();
            lbl_mensagem_nome.Visible = false;
            lbl_mensagem_usuario.Visible = false;
            lbl_mensagem_senha.Visible = false;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string resp = "";
            Conexao.criarBanco();
            if(txt_nome.Text == "")
            {
                lbl_mensagem_nome.Visible = true;
            }
            else
            {
                if(txt_login.Text == "")
                {
                    lbl_mensagem_usuario.Visible = true;
                }
                else
                {
                    if(txt_senha.Text == "")
                    {
                        lbl_mensagem_senha.Visible = true;
                    }
                    else
                    {
                        if (ValidarDados.conferirSenhas(txt_senha.Text, txt_confirmar.Text))
                        {
                            resp = NAdministrador.InserirAdministrador(ValidarDados.arrumarTexto(txt_nome.Text), txt_login.Text, txt_senha.Text);
                            formMensagem form = new formMensagem();
                            form.ShowDialog();
                            Close();
                        }
                        else
                        {
                            txt_confirmar.ForeColor = Color.Red;
                            txt_senha.ForeColor = Color.Red;
                            txt_confirmar.PasswordChar = '\u0000';
                            txt_confirmar.Text = "Senhas não são iguais.";
                            verifica = true;
                        }
                    }
                }
            } 
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_senha_Click(object sender, EventArgs e)
        {
            if(verifica == true)
            {
                txt_confirmar.Text = "";
                txt_senha.Text = "";
                txt_confirmar.ForeColor = Color.Black;
                txt_senha.ForeColor = Color.Black;
                txt_confirmar.PasswordChar = '*';
                verifica = false;
            }
        }

        private void txt_confirmar_Click(object sender, EventArgs e)
        {
            if (verifica == true)
            {
                txt_confirmar.Text = "";
                txt_senha.Text = "";
                txt_confirmar.ForeColor = Color.Black;
                txt_senha.ForeColor = Color.Black;
                txt_confirmar.PasswordChar = '*';
                verifica = false;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_confirmar.Text = "";
            txt_login.Text = "";
            txt_nome.Text = "";
            txt_senha.Text = "";
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            lbl_mensagem_nome.Visible = false;
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            lbl_mensagem_usuario.Visible = false;
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            lbl_mensagem_senha.Visible = false;
        }
    }
}
