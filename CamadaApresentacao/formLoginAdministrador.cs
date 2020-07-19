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
    public partial class formCadastroAdministrador : Form
    {
        public formCadastroAdministrador()
        {
            InitializeComponent();
            lbl_mensagem_login.Visible = false;
            lbl_mensagem_senha.Visible = false;
            lbl_mensagem_incorreta.Visible = false;
        }

        private void formCadastroAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            formTelaCadastroAdministrador formcadastro = new formTelaCadastroAdministrador();
            formcadastro.Show();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                    Application.OpenForms[intIndex].Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            ControleLogin controle = new ControleLogin();
            controle.Acessar(txt_login.Text, txt_senha.Text);

            if(txt_login.Text == "")
            {
                lbl_mensagem_login.Visible = true;
            }
            else
            {
                if(txt_senha.Text == "")
                {
                    lbl_mensagem_senha.Visible = true;
                }
                else
                {
                    if (controle.tem)
                    {
                        int id = Convert.ToInt32(NAdministrador.carregarIdAdministrador(txt_login.Text));
                        formPrincipal form = new formPrincipal(id);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbl_mensagem_incorreta.Visible = true;
                    }
                }
            }
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            lbl_mensagem_login.Visible = false;
            lbl_mensagem_incorreta.Visible = false;
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            lbl_mensagem_senha.Visible = false;
            lbl_mensagem_incorreta.Visible = false;
        }
    }
}
