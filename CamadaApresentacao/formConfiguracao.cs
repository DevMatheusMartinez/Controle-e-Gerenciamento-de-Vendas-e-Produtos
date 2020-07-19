using CamadaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class formConfiguracao : Form
    {
        formPrincipal _pai;
        public formConfiguracao(formPrincipal pai)
        {
            InitializeComponent();
            txt_dia.MaxLength = 2;
            txt_dia.Text = "------";
            txt_dia.Enabled = false;
            comboMes.Enabled = false;
            comboMes.SelectedIndex = 0;
            txt_horario.Enabled = false;
            _pai = pai;
        }

        private void btn_backup_agora_Click(object sender, EventArgs e)
        {
            NOperacao.criarBackupAgora();
        }

        private void checkDiario_CheckedChanged(object sender, EventArgs e)
        {
            if(checkDiario.Checked == true)
            {
                checkMensal.Checked = false;
                checkAnual.Checked = false;
                txt_dia.Text = "------";
                txt_dia.Enabled = false;
                comboMes.SelectedIndex = 0;
                comboMes.Enabled = false;
                txt_horario.Enabled = true;
            }
        }

        private void checkMensal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMensal.Checked == true)
            {
                checkDiario.Checked = false;
                checkAnual.Checked = false;
                txt_dia.Enabled = true;
                txt_dia.Text = "";
                comboMes.SelectedIndex = 0;
                comboMes.Enabled = false;
                txt_horario.Enabled = true;
            }
        }

        private void checkAnual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAnual.Checked == true)
            {
                checkDiario.Checked = false;
                checkMensal.Checked = false;
                txt_dia.Text = "";
                txt_dia.Enabled = true;
                comboMes.Enabled = true;
                txt_horario.Enabled = true;
            }
        }

        private void checkSem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_horario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_dia_Leave(object sender, EventArgs e)
        {
        }

        private void comboMes_Leave(object sender, EventArgs e)
        {
        }

        private bool validarData()
        {
            if(checkAnual.Checked == false && checkDiario.Checked == false && checkMensal.Checked == false)
            {
                MessageBox.Show("Selecione o periodo do backup que deseja", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               if(checkAnual.Checked == true || checkMensal.Checked == true) 
                {
                    int dia;
                    if(txt_dia.Text == "")
                    {
                        MessageBox.Show("Dia inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dia = Convert.ToInt32(txt_dia.Text);
                        if (checkAnual.Checked == true && (dia >= 1 && dia <= 31))
                        {
                            if(comboMes.SelectedIndex == 0)
                            {
                                MessageBox.Show("Selecione o mês que deseja fazer o backup anual", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (dia > 28)
                                {
                                    MessageBox.Show("Em fevereiro o backup será realizado automaticamente todo dia 28", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                if (dia > 30)
                                {
                                    MessageBox.Show("Em novembro, abril, junho e setembro o backup será realizado automaticamente todo dia 30", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                if (validarHorario())
                                {
                                    return true;
                                }
                            }    
                        }
                        else if (checkMensal.Checked == true && (dia >= 1 && dia <= 31))
                        {
                            if (comboMes.SelectedIndex == 2 && dia > 28)
                            {
                                MessageBox.Show("Em fevereiro o backup será realizado automaticamente todo dia 28", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            if (dia > 30)
                            {
                                MessageBox.Show("Em novembro, abril, junho e setembro o backup será realizado automaticamente todo dia 30", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            if (validarHorario())
                            {
                                return true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dia inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_dia.Text = "";
                        }
                    }
                }
                else if(checkDiario.Checked == true)
                {
                    if(validarHorario())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool validarHorario()
        {
            if(txt_horario.Text.Length == 3)
            {
                MessageBox.Show("Horário inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] tempo = new string[2];
                string horario = txt_horario.Text;
                tempo = horario.Split(':');
                int hora = Convert.ToInt32(tempo[0]);
                int minuto = Convert.ToInt32(tempo[1]);
                if (hora > 24)
                {
                    MessageBox.Show("Horario invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_horario.Text = "";
                    return false;
                }
                else if (minuto > 59)
                {
                    MessageBox.Show("Horario invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_horario.Text = "";
                    return false;
                }
                return true;
            }
            return false;
        }
        private void txt_horario_Leave(object sender, EventArgs e)
        {
            string[] tempo = new string[2];
            string horario = txt_horario.Text;
            tempo = horario.Split(':');
            int hora = Convert.ToInt32(tempo[0]);
            int minuto = Convert.ToInt32(tempo[1]);

            if (hora.ToString().Length == 1)
            {
                tempo[0] = "0" + hora;
            }
            if(minuto.ToString().Length == 1)
            {
                tempo[1] = "0" + minuto;
            }

            txt_horario.Text = tempo[0] + tempo[1];

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (validarData())
            {
                if(checkAnual.Checked == true)
                {
                    DateTime data = Convert.ToDateTime(txt_dia.Text + "/" + comboMes.SelectedIndex + "/" + DateTime.Now.Year + " " + txt_horario.Text + ":00");
                    if(DateTime.Compare(data, DateTime.Now) < 0)
                    {
                        data.AddYears(1);
                    }
                    _pai.timerverificador.Enabled = true;
                    _pai.periodo = "Anual";
                    _pai.data = data;

                    MessageBox.Show("Backup programado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(checkMensal.Checked == true)
                {
                    int dia = Convert.ToInt32(txt_dia.Text);
                    string hora = txt_horario.Text + ":00";
                    _pai.timerverificador.Enabled = true;
                    _pai.periodo = "Mensal";
                    _pai.diabackup = dia;
                    _pai.horario = hora;

                    MessageBox.Show("Backup programado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string hora = txt_horario.Text + ":00";
                    _pai.timerverificador.Enabled = true;
                    _pai.periodo = "Diario";
                    _pai.horario = hora;
                    MessageBox.Show("Backup programado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_pasta_Click(object sender, EventArgs e)
        {
            string pasta = Path.GetDirectoryName(Application.ExecutablePath) + @"\Backup\";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            Process.Start("explorer.exe", pasta);
        }
    }
}
