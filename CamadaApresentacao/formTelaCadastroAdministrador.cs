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
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string resp = "";
            Conexao.criarBanco();
            if (ValidarDados.conferirSenhas(txt_senha.Text, txt_confirmar.Text))
            {
                resp = NAdministrador.InserirAdministrador(ValidarDados.ValidarNome(txt_nome.Text), txt_login.Text, txt_senha.Text);
                formMensagem form = new formMensagem();
                form.ShowDialog();
                Close();
            }
            else
            {
                txt_confirmar.ForeColor = Color.Red;
                txt_senha.ForeColor = Color.Red;
                txt_confirmar.Text = "Senha não se conferem.";
                verifica = true;
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
    }
}
