using CamadaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocios
{
    public class NFicha
    {
        public static string InserirFicha(string identificacao, decimal preco, string data_compra, string data_pagamento, string data_vencimento, string situacao, int codcliente)
        {
            DFicha ficha = new DFicha();
            ficha.IdentificacaoFicha = identificacao;
            ficha.PrecoFicha = preco;
            ficha.DataCompraFicha = data_compra;
            ficha.DataPagoFicha = data_pagamento;
            ficha.DataVencimentoFicha = data_vencimento;
            ficha.Situacao = situacao;
            ficha.CodClienteFicha = codcliente;
            return ficha.inserirFicha(ficha);
        }

        public static bool verificarFicha()
        {
            DFicha ficha = new DFicha();
            return ficha.verificarFicha();
        }

        public static int CarregarUltimoIdFicha()
        {
            DFicha ficha = new DFicha();
            return ficha.carregarUltimoIdFicha();
        }

    }
}
