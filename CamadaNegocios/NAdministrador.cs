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

        public static string carregarSenhaAdministrador(int id)
        {
            DAdministrador Administrador = new DAdministrador();
            Administrador.Id = id;
            return Administrador.carregarSenhaAdministrador(Administrador);
        }

        public static string carregarIdAdministrador(string login)
        {
            DAdministrador Administrador = new DAdministrador();
            Administrador.Login = login;
            return Administrador.carregarIdAdministrador(Administrador);
        }

    }
}
