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
    public class NProduto
    {
        public static string InserirProduto(string nome, string categoria, string marca, decimal preco, int estoque)
        {
            DProduto Produto = new DProduto();
            Produto.Nome = nome;
            Produto.Categoria = categoria;
            Produto.Marca = marca;
            Produto.Preco = preco;
            Produto.Estoque = estoque;
            return Produto.inserirProduto(Produto);
        }

        public static string EditarProduto(int id, string nome, string categoria, string marca, decimal preco, int estoque)
        {
            DProduto Produto = new DProduto();
            Produto.Id = id;
            Produto.Nome = nome;
            Produto.Categoria = categoria;
            Produto.Marca = marca;
            Produto.Preco = preco;
            Produto.Estoque = estoque;
            return Produto.editarProduto(Produto);
        }

        public static string DeletarProduto(int id)
        {
            DProduto Produto = new DProduto();
            Produto.Id = id;
            return Produto.deletarProduto(Produto);
        }

        public static string[] CarregarDadosProduto(int id)
        {
            DProduto Produto = new DProduto();
            Produto.Id = id;
            return Produto.carregarDadosProduto(Produto);
        }

        public static DataTable Mostrar()
        {
            return new DProduto().mostrar();
        }

        public static DataTable MostrarCaixa()
        {
            return new DProduto().mostrarCaixa();
        }

        public static void FiltrarDados(TextBox txt, DataGridView datagrid, string aba)
        {
            DProduto Produto = new DProduto();
            Produto.filtrarDados(txt, datagrid, aba);
        }
    }
}
