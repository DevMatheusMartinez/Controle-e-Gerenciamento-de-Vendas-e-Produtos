using CamadaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaNegocios
{
    public class NMarca
    {
        public static string InserirMarca(string nome)
        {
            DMarca marca = new DMarca();
            marca.Nome = nome;
            return marca.inserirMarca(marca);
        }

        public static void preencherCBMarca(ComboBox combo)
        {
            DMarca marca = new DMarca();
            marca.preencherCBMarca(combo);
        }
    }
}
