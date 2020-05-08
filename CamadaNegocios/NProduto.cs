using CamadaDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocios
{
    public class NProduto
    {
        public static string InserirProduto(string nome, string categoria, string marca, float preco, int estoque)
        {
            DProduto Produto = new DProduto();
            Produto.Nome = nome;
            Produto.Categoria = categoria;
            Produto.Marca = marca;
            Produto.Preco = preco;
            Produto.Estoque = estoque;
            return Produto.inserirProduto(Produto);
        }

        public static DataTable Mostrar()
        {
            return new DProduto().Mostrar();
        }
    }
}
