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
    public class DAdministrador
    {
        private int _idAdministrador;
        private string _nome;
        private string _login;
        private string _senha;

        public DAdministrador() { }

        public DAdministrador(int idAdministrador, string nome, string login, string senha)
        {
            this._idAdministrador = idAdministrador;
            this._nome = nome;
            this._login = login;
            this._senha = senha;
        }

        public int Id
        {
            get
            {
                return _idAdministrador;
            }

            set
            {
                _idAdministrador = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }

            set
            {
                _senha = value;
            }
        }

        public string inserirAdministrador(DAdministrador administrador)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO ADMINISTRADOR (NOME_ADMINISTRADOR, LOGIN_ADMINISTRADOR, SENHA_ADMINISTRADOR) VALUES (@NOME_ADMINISTRADOR, @LOGIN_ADMINISTRADOR, @SENHA_ADMINISTRADOR);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parNome = new SQLiteParameter();
                parNome.ParameterName = "@NOME_ADMINISTRADOR";
                parNome.DbType = DbType.String;
                parNome.Size = 45;
                parNome.Value = administrador.Nome;
                sqlCmd.Parameters.Add(parNome);

                SQLiteParameter parLogin = new SQLiteParameter();
                parLogin.ParameterName = "@LOGIN_ADMINISTRADOR";
                parLogin.DbType = DbType.String;
                parLogin.Size = 45;
                parLogin.Value = administrador.Login;
                sqlCmd.Parameters.Add(parLogin);

                SQLiteParameter parSenha = new SQLiteParameter();
                parSenha.ParameterName = "@SENHA_ADMINISTRADOR";
                parSenha.DbType = DbType.String;
                parSenha.Size = 45;
                parSenha.Value = administrador.Senha;
                sqlCmd.Parameters.Add(parSenha);

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi inserido";
            }
            catch(Exception e)
            {
                resp = e.Message;
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return resp;
        }

        public string editarSenhaAdministrador(DAdministrador administrador)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "speditar_senha_administrador";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdAdministrador = new SqlParameter();
                parIdAdministrador.ParameterName = "@id";
                parIdAdministrador.SqlDbType = SqlDbType.Int;
                parIdAdministrador.Value = administrador.Id;
                sqlCmd.Parameters.Add(parIdAdministrador);

                SqlParameter parSenha = new SqlParameter();
                parSenha.ParameterName = "@senha";
                parSenha.SqlDbType = SqlDbType.VarChar;
                parSenha.Size = 45;
                parSenha.Value = administrador.Senha;
                sqlCmd.Parameters.Add(parSenha);

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi inserido";
            }
            catch (Exception e)
            {
                resp = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return resp;
        }
    }
}
