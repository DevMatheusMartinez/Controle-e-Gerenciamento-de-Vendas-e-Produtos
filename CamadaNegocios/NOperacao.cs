﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaNegocios
{
    public class NOperacao
    {
        public static decimal CalcularValorQuantidade(int quantidade, decimal valor)
        {
            decimal resultado;

            resultado = valor * quantidade;

            return resultado;
        }

        public static void CalcularListaValorQuantidade(int quantidade, decimal valor, List<decimal> lista)
        {
            for(int i=1; i<=quantidade; i++)
            {
                lista.Insert(0, valor);
            }
        }

        public static int SubtrairEstoque(int codproduto, int quantidade)
        {
            string[] dados = new string[6];
            dados = NProduto.CarregarDadosProduto(codproduto);
            int resultado = Convert.ToInt32(dados[5]) - quantidade;

            if(resultado < 0)
            {
                return 0;
            }
            return resultado;
        }

        public static decimal SomarValorTotal(List<decimal> lista)
        {
            var resultado = lista.Sum(x => Convert.ToDecimal(x));
            return resultado;
        }

        public static int SomarQuantidadeTotal(List<int> lista)
        {
            var resultado = lista.Sum(x => Convert.ToInt32(x));
            return resultado;
        }
        
        public static void SubtrairValorTotal(List<decimal> lista, int index)
        {
            lista.RemoveAt(index);
        }

        public static decimal SubtrairValor(decimal dinheiro, decimal total)
        {
            return dinheiro - total;
        }

        public static void SubtrairQuantidadeTotal(List<int> lista, int index)
        {
            lista.RemoveAt(index);
        }

        public static string DataAtual()
        {
            string datahora = Convert.ToString(DateTime.Today);
            string[] data = new string[2];
            data = datahora.Split(' ');
            return data[0];
        }

        public static string DataVencimento()
        {
            string datahora = Convert.ToString(DateTime.Today.AddDays(7));
            string[] data = new string[2];
            data = datahora.Split(' ');
            return data[0];
        }

        public static bool VerificarExistenciaProduto(DataGridView datagrid, int codigo)
        {
            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                if(codigo == Convert.ToInt32(datagrid.Rows[i].Cells[0].Value))
                {
                    return true;
                }
            }
            return false;
        }

        public static int RetornarLinha(DataGridView datagrid, int codigo)
        {
            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                if (codigo == Convert.ToInt32(datagrid.Rows[i].Cells[0].Value))
                {
                    return i;
                }
            }
            return 0;
        }

        public static void SomarQuantidadeDatagrid(DataGridView datagrid, int linha, int quantidadedigitada, decimal preco)
        {
            int quantidadeatual = Convert.ToInt32(datagrid.Rows[linha].Cells[3].Value);
            int resultado = quantidadeatual + quantidadedigitada;
            datagrid.Rows[linha].Cells[3].Value = resultado;
            datagrid.Rows[linha].Cells[4].Value = preco * resultado;
        }

        public static void SubtrairQuantidadeDatagrid(DataGridView datagrid, int linha)
        {
            int quantidadeatual = Convert.ToInt32(datagrid.Rows[linha].Cells[3].Value);
            decimal preco = Convert.ToDecimal(datagrid.Rows[linha].Cells[4].Value) / quantidadeatual;
            int resultado = quantidadeatual - 1;
            if (resultado >= 1)
            {
                datagrid.Rows[linha].Cells[3].Value = resultado;
                datagrid.Rows[linha].Cells[4].Value = preco*resultado;
            }
            else
            {
                datagrid.Rows.RemoveAt(linha);
            }
        }

        public static void numerarGrid(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                for (int count = 0; (count <= (dataGridView.Rows.Count - 1)); count++)
                {
                    dataGridView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
        }

        public static void criarBackupAgora()
        {
            using (SQLiteConnection source = new SQLiteConnection(String.Format("Data Source = {0}", "Banco.db")))
            using (SQLiteConnection destination = new SQLiteConnection(String.Format("Data Source = {0}", "Backup\\Bancobackup - " + NOperacao.DataAtual().Replace("/", ".") + ".db")))
            {
                source.Open();
                destination.Open();
                source.BackupDatabase(destination, "main", "main", -1, null, -1);
            }

            string pasta = Path.GetDirectoryName(Application.ExecutablePath) + @"\Backup\";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            Process.Start("explorer.exe", pasta);
        }

        public static void criarBackupProgramado()
        {
            using (SQLiteConnection source = new SQLiteConnection(String.Format("Data Source = {0}", "Banco.db")))
            using (SQLiteConnection destination = new SQLiteConnection(String.Format("Data Source = {0}", "Backup\\Bancobackup - " + NOperacao.DataAtual().Replace("/", ".") + ".db")))
            {
                source.Open();
                destination.Open();
                source.BackupDatabase(destination, "main", "main", -1, null, -1);
            }
        }
    }
}
