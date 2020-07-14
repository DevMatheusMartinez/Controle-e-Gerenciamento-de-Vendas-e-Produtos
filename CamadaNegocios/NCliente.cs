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
    public class NCliente
    {
        public static string InserirCliente(string nome, string cpf, string endereco, string email)
        {
            DCliente Cliente = new DCliente();
            Cliente.NomeCliente = nome;
            Cliente.CpfCliente = cpf;
            Cliente.EnderecoCliente = endereco;
            Cliente.EmailCliente = email;
            return Cliente.inserirCliente(Cliente);
        }

        public static string EditarCliente(int idcliente, string nome, string cpf, string endereco, string email)
        {
            DCliente Cliente = new DCliente();
            Cliente.IdCliente = idcliente;
            Cliente.NomeCliente = nome;
            Cliente.CpfCliente = cpf;
            Cliente.EnderecoCliente = endereco;
            Cliente.EmailCliente = email;
            return Cliente.editarCliente(Cliente);
        }

        public static string DeletarCliente(int id)
        {
            DCliente Cliente = new DCliente();
            Cliente.IdCliente = id;
            return Cliente.deletarCliente(Cliente);
        }

        public static int CarregarUltimoIdCliente()
        {
            DCliente Cliente = new DCliente();
            return Cliente.carregarUltimoIdCliente();
        }

        public static DataTable Mostrar()
        {
            return new DCliente().mostrar();
        }

        public static void FiltrarDados(TextBox txt, DataGridView datagrid)
        {
            DCliente Cliente = new DCliente();
            Cliente.filtrarDados(txt, datagrid);
        }

        public static void preencherCBCliente(ComboBox combo)
        {
            DCliente cliente = new DCliente();
            cliente.preencherCBCliente(combo);
        }

        public static string[] CarregarDadosCliente(string id_nome, string operacao)
        {
            DCliente Cliente = new DCliente();
            if(operacao == "NOME_CLIENTE")
            {
                Cliente.NomeCliente = id_nome;
            }
            else
            {
                Cliente.IdCliente = Convert.ToInt32(id_nome);
            }
            
            return Cliente.carregarDadosCliente(Cliente, operacao);
        }

        public static bool VerificarExistencia(string nome)
        {
            DCliente Cliente = new DCliente();
            Cliente.NomeCliente = nome;
            if(Convert.ToInt32(Cliente.verificarExistencia(Cliente)) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
