using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDados
{
    public class DCategoria
    {
        private int _idCategoria;
        private string _nome;

        public DCategoria() { }

        public DCategoria(int idCategoria, string nome)
        {
            this._idCategoria = idCategoria;
            this._nome = nome;
        }

        public int Id
        {
            get
            {
                return _idCategoria;
            }

            set
            {
                _idCategoria = value;
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
        public string inserirCategoria(DCategoria categoria)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO CATEGORIA (NOME_CATEGORIA) values (@NOME_CATEGORIA);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parNome = new SQLiteParameter();
                parNome.ParameterName = "@NOME_CATEGORIA";
                parNome.DbType = DbType.String;
                parNome.Size = 45;
                parNome.Value = categoria.Nome;
                sqlCmd.Parameters.Add(parNome);

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

        public void preencherCBCategoria(ComboBox combo)
        {
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon.ConnectionString = Conexao.Cn;
                sqlcon.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "SELECT NOME_CATEGORIA FROM CATEGORIA ORDER BY ID_CATEGORIA";
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                DataRow row = table.NewRow();
                row["NOME_CATEGORIA"] = "";
                table.Rows.InsertAt(row, 0);

                combo.DataSource = table;
                combo.ValueMember = "NOME_CATEGORIA";

                reader.Close();
                reader.Dispose();
            }
            catch (Exception e)
            {
                string resp = e.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
        }


    }
}
