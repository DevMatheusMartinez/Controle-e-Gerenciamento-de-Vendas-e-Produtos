using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class DTelefone
    {
        private int _idtelefone;
        private string _telefone;
        private int _codcliente;

        public DTelefone() { }
        public DTelefone(int idtelefone, string telefone, int codcliente)
        {
            this._idtelefone = idtelefone;
            this._telefone = telefone;
            this._codcliente = codcliente;
        }

        public int IdTelefone
        {
            get
            {
                return _idtelefone;
            }

            set
            {
                _idtelefone = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _telefone;
            }

            set
            {
                _telefone = value;
            }
        }
        public int CodCliente
        {
            get
            {
                return _codcliente;
            }

            set
            {
                _codcliente = value;
            }
        }

        public string inserirTelefone(DTelefone telefone)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO TELEFONE (TELEFONE, COD_CLIENTE_TELEFONE) VALUES (@TELEFONE, @COD_CLIENTE_TELEFONE);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parTelefone = new SQLiteParameter();
                parTelefone.ParameterName = "@TELEFONE";
                parTelefone.DbType = DbType.String;
                parTelefone.Size = 80;
                parTelefone.Value = telefone.Telefone;
                sqlCmd.Parameters.Add(parTelefone);

                SQLiteParameter parCodCliente = new SQLiteParameter();
                parCodCliente.ParameterName = "@COD_CLIENTE_TELEFONE";
                parCodCliente.DbType = DbType.Int32;
                parCodCliente.Value = telefone.CodCliente;
                sqlCmd.Parameters.Add(parCodCliente);

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

        public DataTable mostrarTelefone(DTelefone telefone)
        {
            DataTable DtResultado = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon.ConnectionString = Conexao.Cn;
                sqlcon.Open();

                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "SELECT T.TELEFONE FROM TELEFONE T INNER JOIN CLIENTE C ON T.COD_CLIENTE_TELEFONE = C.ID_CLIENTE WHERE T.COD_CLIENTE_TELEFONE = @COD_CLIENTE";
                sqlcmd.CommandType = CommandType.Text;

                SQLiteParameter parCodCliente = new SQLiteParameter();
                parCodCliente.ParameterName = "@COD_CLIENTE";
                parCodCliente.DbType = DbType.Int32;
                parCodCliente.Value = telefone.CodCliente;
                sqlcmd.Parameters.Add(parCodCliente);

                SQLiteDataAdapter sqldata = new SQLiteDataAdapter(sqlcmd);
                sqldata.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }
    }
}
