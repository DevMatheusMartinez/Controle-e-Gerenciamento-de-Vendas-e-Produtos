﻿using CamadaDados;
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

        public static int CarregarUltimoIdCliente()
        {
            DCliente Cliente = new DCliente();
            return Cliente.carregarUltimoIdCliente();
        }

        public static DataTable Mostrar()
        {
            return new DCliente().mostrar();
        }

        public static void preencherCBCliente(ComboBox combo)
        {
            DCliente cliente = new DCliente();
            cliente.preencherCBCliente(combo);
        }

        public static string[] CarregarDadosCliente(string nome)
        {
            DCliente Cliente = new DCliente();
            Cliente.NomeCliente = nome;
            return Cliente.carregarDadosCliente(Cliente);
        }
    }
}