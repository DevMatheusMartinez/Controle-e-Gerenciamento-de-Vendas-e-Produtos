using CamadaDados;
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
    public partial class formMensagem : Form
    {
        public formMensagem()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            lbl_mensagem.Text = "Criando Area de trabalho...\b espera alguns segundos";
            Conexao.inserirDadosPadraoMarca();
            Conexao.inserirDadosPadraoCategoria();
            Close();
        }

        private void formMensagem_Load(object sender, EventArgs e)
        {

        }
    }
}
