using System;
using System.Collections.Generic;
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
            decimal preco = Convert.ToDecimal(datagrid.Rows[linha].Cells[4].Value)/quantidadeatual;
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


    }
}
