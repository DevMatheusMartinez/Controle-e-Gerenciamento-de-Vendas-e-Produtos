using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocios
{
    public class ProdutoCaixa
    {
        public string Preco { get; set; }

        public ProdutoCaixa(string preco)
        {
            this.Preco = preco;
        }

        public ProdutoCaixa() { }
    }
}
