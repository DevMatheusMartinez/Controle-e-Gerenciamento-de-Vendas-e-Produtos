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
    public class DProduto
    {
        private int _idproduto;
        private string _nome;
        private string _categoria;
        private string _marca;
        private float _preco;
        private int _estoque;

        public DProduto() { }

        public DProduto(int idproduto, string nome, string categoria, string marca, float preco, int estoque)
        {
            this._idproduto = idproduto;
            this._nome = nome;
            this._categoria = categoria;
            this._marca = marca;
            this._preco = preco;
            this._estoque = estoque;
        }

        public int Id
        {
            get
            {
                return _idproduto;
            }

            set
            {
                _idproduto = value;
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

        public string Categoria
        {
            get
            {
                return _categoria;
            }

            set
            {
                _categoria = value;
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public float Preco
        {
            get
            {
                return _preco;
            }

            set
            {
                _preco = value;
            }
        }

        public int Estoque
        {
            get
            {
                return _estoque;
            }

            set
            {
                _estoque = value;
            }
        }

        public string inserirProduto(DProduto produto)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO PRODUTO (NOME_PRODUTO, CATEGORIA_PRODUTO, PRECO_PRODUTO, ESTOQUE_PRODUTO) VALUES (@NOME_PRODUTO, @CATEGORIA_PRODUTO, @PRECO_PRODUTO, @ESTOQUE_PRODUTO);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parNome = new SQLiteParameter();
                parNome.ParameterName = "@NOME_PRODUTO";
                parNome.DbType = DbType.String;
                parNome.Size = 70;
                parNome.Value = produto.Nome;
                sqlCmd.Parameters.Add(parNome);

                SQLiteParameter parCategoria = new SQLiteParameter();
                parCategoria.ParameterName = "@CATEGORIA_PRODUTO";
                parCategoria.DbType = DbType.String;
                parCategoria.Size = 70;
                parCategoria.Value = produto.Categoria;
                sqlCmd.Parameters.Add(parCategoria);

                SQLiteParameter parMarca = new SQLiteParameter();
                parMarca.ParameterName = "@MARCA_PRODUTO";
                parMarca.DbType = DbType.String;
                parMarca.Size = 70;
                parMarca.Value = produto.Marca;
                sqlCmd.Parameters.Add(parMarca);

                SQLiteParameter parPreco = new SQLiteParameter();
                parPreco.ParameterName = "@PRECO_PRODUTO";
                parPreco.DbType = DbType.Double;
                parPreco.Value = produto.Preco;
                sqlCmd.Parameters.Add(parPreco);

                SQLiteParameter parEstoque = new SQLiteParameter();
                parEstoque.ParameterName = "@ESTOQUE_PRODUTO";
                parEstoque.DbType = DbType.Int32;
                parEstoque.Value = produto.Estoque;
                sqlCmd.Parameters.Add(parEstoque);

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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("PRODUTO");
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon.ConnectionString = Conexao.Cn;
                sqlcon.Open();

                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "SELECT * FROM PRODUTO";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataAdapter sqldata = new SQLiteDataAdapter(sqlcmd);
                sqldata.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }
    }
}
