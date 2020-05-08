using CamadaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaNegocios
{
    public class NCategoria
    {
        public static string InserirCategoria(string nome)
        {
            DCategoria Categoria = new DCategoria();
            Categoria.Nome = nome;
            return Categoria.inserirCategoria(Categoria);
        }

        public static void preencherCBCategoria(ComboBox combo)
        {
            DCategoria categoria = new DCategoria();
            categoria.preencherCBCategoria(combo);
        }
    }
}
