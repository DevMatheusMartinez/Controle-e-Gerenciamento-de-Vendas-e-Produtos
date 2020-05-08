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
    public class DMarca
    {
        private int _idMarca;
        private string _nome;

        public DMarca() { }

        public DMarca(int idMarca, string nome)
        {
            this._idMarca = idMarca;
            this._nome = nome;
        }

        public int Id
        {
            get
            {
                return _idMarca;
            }

            set
            {
                _idMarca = value;
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
        public string inserirMarca(DMarca marca)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO MARCA (NOME_MARCA) values (@NOME_MARCA);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parNome = new SQLiteParameter();
                parNome.ParameterName = "@NOME_MARCA";
                parNome.DbType = DbType.String;
                parNome.Size = 45;
                parNome.Value = marca.Nome;
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

        public void preencherCBMarca(ComboBox combo)
        {
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon.ConnectionString = Conexao.Cn;
                sqlcon.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "SELECT NOME_MARCA FROM MARCA ORDER BY ID_MARCA";
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                DataRow row = table.NewRow();
                row["NOME_MARCA"] = "";
                table.Rows.InsertAt(row, 0);

                combo.DataSource = table;
                combo.ValueMember = "NOME_MARCA";

                reader.Close();
                reader.Dispose();
            }
            catch(Exception e)
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