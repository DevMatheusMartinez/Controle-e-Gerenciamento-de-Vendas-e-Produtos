using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CamadaApresentacao
{
    public class ValidarDados
    {
        public static string ValidarNome(string nome)
        {
            nome = Regex.Replace(nome, "[ ]{2,}", " ", RegexOptions.Compiled);
            nome = nome.ToUpper();
            return nome;
        }

        public static bool conferirSenhas(string senha1, string senha2)
        {
            if(senha1 == senha2)
            {
                return true;
            }
            return false;
        }
    }
}
