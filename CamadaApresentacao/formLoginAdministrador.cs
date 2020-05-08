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
            if (controle.tem)
            {
                formPrincipal form = new formPrincipal("teste");
                form.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
