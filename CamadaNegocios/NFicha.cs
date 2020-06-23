using CamadaDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaNegocios
{
    public class NFicha
    {
        public static string InserirFicha(string identificacao, decimal preco, string data_compra, string data_pagamento, string data_vencimento, string situacao, string formapagamento, int codcliente)
        {
            DFicha ficha = new DFicha();
            ficha.IdentificacaoFicha = identificacao;
            ficha.PrecoFicha = preco;
            ficha.DataCompraFicha = data_compra;
            ficha.DataPagoFicha = data_pagamento;
            ficha.DataVencimentoFicha = data_vencimento;
            ficha.Situacao = situacao;
            ficha.FormaPagamento = formapagamento;
            ficha.CodClienteFicha = codcliente;
            return ficha.inserirFicha(ficha);
        }

        public static string EditarFicha(int id, string data_pagamento, string situacao, string forma_pagamento)
        {
            DFicha ficha = new DFicha();
            ficha.IdFicha = id;
            ficha.DataPagoFicha = data_pagamento;
            ficha.Situacao = situacao;
            ficha.FormaPagamento = forma_pagamento;
            
            return ficha.editarFichaPagamentoPosSalvamento(ficha);
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

        public static DataTable Mostrar()
        {
            return new DFicha().mostrarFicha();
        }

        public static string[] CarregarDadosFicha(string identificacaoficha)
        {
            DFicha ficha = new DFicha();
            ficha.IdentificacaoFicha = identificacaoficha;
            return ficha.carregarDadosFicha(ficha);
        }

        public static void FiltrarDados(TextBox txt, DataGridView datagrid)
        {
            DFicha ficha = new DFicha();
            ficha.filtrarDados(txt, datagrid);
        }
    }
}
