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

        public static decimal SomarValorTotal(List<decimal> lista)
        {
            var resultado = lista.Sum(x => Convert.ToDecimal(x));
            return resultado;
        }
        
        public static void SubtrairValorTotal(List<decimal> lista, int index)
        {
            lista.RemoveAt(index);
        }


    }
}
