using CamadaDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocios
{
    public class NTelefone
    {
        public static string InserirTelefone(string telefone, int codcliente)
        {
            DTelefone Telefone = new DTelefone();
            Telefone.Telefone = telefone;
            Telefone.CodCliente = codcliente;
            return Telefone.inserirTelefone(Telefone);
        }

        public static string DeletarTelefone(int codcliente)
        {
            DTelefone Telefone = new DTelefone();
            Telefone.CodCliente = codcliente;
            return Telefone.deletarTelefone(Telefone);
        }

        public static List<string> ListarTelefone(int codcliente)
        {
            DTelefone Telefone = new DTelefone();
            Telefone.CodCliente = codcliente;
            return Telefone.listar(Telefone);
        }

        public static DataTable mostrarTelefone(int cod_cliente)
        {
            DTelefone Telefone = new DTelefone();
            Telefone.CodCliente = cod_cliente;
            return Telefone.mostrarTelefone(Telefone);
        }
    }
}
