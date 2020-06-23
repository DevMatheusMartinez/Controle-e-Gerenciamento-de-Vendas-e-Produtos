using CamadaDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocios
{
    public class NProduto_Comprado
    {
        public static string InserirProdutoComprado(int quantidade, int cod_ficha, int cod_produto, string preco_produto)
        {
            DProduto_Comprado Produto_comprado = new DProduto_Comprado();
            Produto_comprado.QuantidadeProdutoComprado = quantidade;
            Produto_comprado.CodFicha = cod_ficha;
            Produto_comprado.CodProduto = cod_produto;
            Produto_comprado.PrecoProduto = preco_produto;
            return Produto_comprado.inserirProdutoComprado(Produto_comprado);
        }

        public static DataTable mostrarProdutosComprados(int cod_ficha)
        {
            DProduto_Comprado produto_comprado = new DProduto_Comprado();
            produto_comprado.CodFicha = cod_ficha;
            return produto_comprado.mostrarProdutosComprados(produto_comprado);
        }
    }
}
