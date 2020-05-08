using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class LoginDaoComandos
    {
        public bool tem = false;
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteConnection sqlcon = new SQLiteConnection(Conexao.Cn);
        SQLiteDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "SELECT * FROM ADMINISTRADOR WHERE LOGIN_ADMINISTRADOR = @LOGIN AND SENHA_ADMINISTRADOR = @SENHA";
            cmd.Parameters.AddWithValue("@LOGIN", login);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            sqlcon.Open();

            try
            {
                cmd.Connection = sqlcon;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                
            }
            catch (SQLiteException)
            {
                
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            return tem;
        }

        
    }
}
