using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CamadaNegocios;

namespace CamadaApresentacao
{
    public partial class formPrincipal : Form
    {
        bool protecao = false;
        DialogResult resultado;
        public Timer timerverificador = new Timer();
        public string periodo = "", horario = "";
        public DateTime data;
        public int diabackup;
        public formPrincipal()
        {
            InitializeComponent();
        }

        public formPrincipal(string nome)
        {
            InitializeComponent();
            lbl_nome.Text = nome;
            timerverificador.Interval = 1;
            timerverificador.Enabled = false;
            timerverificador.Tick += new EventHandler(verificadorBackup_Tick);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);
        private void formPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(menu_vertical.Width == 234)
            {
                menu_vertical.Width = 61;
            }
            else
            {
                menu_vertical.Width = 234;
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        public void AbrirFormInPanel(object FormAtual)
        {
            if(this.pn_conteudo.Controls.Count > 0)
            {
                this.pn_conteudo.Controls.RemoveAt(0);
            }
            Form fh = FormAtual as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pn_conteudo.Controls.Add(fh);
            this.pn_conteudo.Tag = fh;
            fh.Show();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            if (!protecao)
            {
                AbrirFormInPanel(new formProduto());
            }
            else
            {
                resultado = MessageBox.Show("Deseja mesmo sair dessa aba?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    protecao = false;
                    AbrirFormInPanel(new formProduto());
                }
            }
        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            if (!protecao)
            {
                AbrirFormInPanel(new formFinalizacaoVenda(this));
                protecao = true;
            }
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            if (!protecao)
            {
                AbrirFormInPanel(new formCliente());
            }
            else
            {
                resultado = MessageBox.Show("Deseja mesmo sair dessa aba?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    protecao = false;
                    AbrirFormInPanel(new formCliente());
                }
            }
        }

        private void btn_ficha_Click(object sender, EventArgs e)
        {
            if (!protecao)
            {
                AbrirFormInPanel(new formFicha());
            }
            else
            {
                resultado = MessageBox.Show("Deseja mesmo sair dessa aba?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    protecao = false;
                    AbrirFormInPanel(new formFicha());
                }
            }
        }

        private void btn_ferramentas_Click(object sender, EventArgs e)
        {
            if (!protecao)
            {
                AbrirFormInPanel(new formConfiguracao(this));
            }
            else
            {
                resultado = MessageBox.Show("Deseja mesmo sair dessa aba?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    protecao = false;
                    AbrirFormInPanel(new formConfiguracao(this));
                }
            }
        }

        private void verificadorBackup_Tick(object sender, EventArgs e)
        {
            if(periodo == "Anual")
            {
                if(DateTime.Compare(DateTime.Now, data) > 0)
                {
                    NOperacao.criarBackupProgramado();
                    data = data.AddYears(1);
                }
            }
            else if(periodo == "Mensal")
            {
                string[] tempo = new string[3];
                tempo = horario.Split(':');

                int hora = Convert.ToInt32(tempo[0]);
                int minuto = Convert.ToInt32(tempo[1]);
                int segundo = Convert.ToInt32(tempo[2]);

                int dia = Convert.ToInt32(DateTime.Today.Day);
                TimeSpan horarioatual = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                TimeSpan horariobackup = new TimeSpan(hora, minuto, segundo);
                if(dia == diabackup && (TimeSpan.Compare(horarioatual, horariobackup) == 0))
                {
                    NOperacao.criarBackupProgramado();
                }
            }
            else
            {
                string[] tempo = new string[3];
                tempo = horario.Split(':');

                int hora = Convert.ToInt32(tempo[0]);
                int minuto = Convert.ToInt32(tempo[1]);
                int segundo = Convert.ToInt32(tempo[2]);

                int dia = Convert.ToInt32(DateTime.Today.Day);
                TimeSpan horarioatual = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                TimeSpan horariobackup = new TimeSpan(hora, minuto, segundo);
                if (TimeSpan.Compare(horarioatual, horariobackup) == 0)
                {
                    NOperacao.criarBackupProgramado();
                }
            }
        }
    }
}
