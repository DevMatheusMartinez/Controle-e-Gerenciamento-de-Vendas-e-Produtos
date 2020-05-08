using CamadaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocios
{
    public class NAdministrador
    {
        public static string InserirAdministrador(string nome, string login, string senha)
        {
            DAdministrador Administrador = new DAdministrador();
            Administrador.Nome = nome;
            Administrador.Login = login;
            Administrador.Senha = senha;
            return Administrador.inserirAdministrador(Administrador);
        }

        public static string editarSenhaAdministrador(int id, string senha)
        {
            DAdministrador Administrador = new DAdministrador();
            Administrador.Id = id;
            Administrador.Senha = senha;
            return Administrador.editarSenhaAdministrador(Administrador);

        }

    }
}
