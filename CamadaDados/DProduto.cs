using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDados
{
    public class DProduto
    {
        private int _idproduto;
        private string _nome;
        private string _categoria;
        private string _marca;
        private decimal _preco;
        private int _estoque;

        public DProduto() { }

        public DProduto(int idproduto, string nome, string categoria, string marca, decimal preco, int estoque)
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

        public decimal Preco
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
                sqlCmd.CommandText = "INSERT INTO PRODUTO (NOME_PRODUTO, CATEGORIA_PRODUTO, MARCA_PRODUTO, PRECO_PRODUTO, ESTOQUE_PRODUTO) VALUES (@NOME_PRODUTO, @CATEGORIA_PRODUTO, @MARCA_PRODUTO, @PRECO_PRODUTO, @ESTOQUE_PRODUTO);";
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
                parPreco.DbType = DbType.Decimal;
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

        public string editarProduto(DProduto produto)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "UPDATE PRODUTO SET NOME_PRODUTO = @NOME_PRODUTO, CATEGORIA_PRODUTO = @CATEGORIA_PRODUTO, MARCA_PRODUTO = @MARCA_PRODUTO, PRECO_PRODUTO = @PRECO_PRODUTO, ESTOQUE_PRODUTO = @ESTOQUE_PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO;";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parId = new SQLiteParameter();
                parId.ParameterName = "@ID_PRODUTO";
                parId.DbType = DbType.Int32;
                parId.Value = produto.Id;
                sqlCmd.Parameters.Add(parId);

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
                parPreco.DbType = DbType.Decimal;
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

        public string deletarProduto(DProduto produto)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "DELETE FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO;";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parId = new SQLiteParameter();
                parId.ParameterName = "@ID_PRODUTO";
                parId.DbType = DbType.Int32;
                parId.Value = produto.Id;
                sqlCmd.Parameters.Add(parId);

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

        public string [] carregarDadosProduto(DProduto produto)
        {
            string[] dados = new string[6];
            SQLiteConnection sqlCon = new SQLiteConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parId = new SQLiteParameter();
                parId.ParameterName = "@ID_PRODUTO";
                parId.DbType = DbType.Int32;
                parId.Value = produto.Id;
                sqlCmd.Parameters.Add(parId);


                SQLiteDataReader leitor = sqlCmd.ExecuteReader();

                while (leitor.Read())
                {
                    dados[0] = (leitor["ID_PRODUTO"].ToString());
                    dados[1] = (leitor["NOME_PRODUTO"].ToString());
                    dados[2] = (leitor["CATEGORIA_PRODUTO"].ToString());
                    dados[3] = (leitor["MARCA_PRODUTO"].ToString());
                    dados[4] = (leitor["PRECO_PRODUTO"].ToString());
                    dados[5] = (leitor["ESTOQUE_PRODUTO"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return dados;
        }

        public DataTable mostrar()
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

        public DataTable mostrarCaixa()
        {
            DataTable DtResultado = new DataTable("PRODUTO");
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon.ConnectionString = Conexao.Cn;
                sqlcon.Open();

                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "SELECT ID_PRODUTO, NOME_PRODUTO, CATEGORIA_PRODUTO, MARCA_PRODUTO, PRECO_PRODUTO FROM PRODUTO";
                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataAdapter sqldata = new SQLiteDataAdapter(sqlcmd);
                sqldata.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public void filtrarDados(TextBox txt, DataGridView datagrid, string aba)
        {
            SQLiteConnection  sqlCon = new SQLiteConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                if(aba == "P")
                {
                    sqlCmd.CommandText = "SELECT * FROM PRODUTO WHERE NOME_PRODUTO LIKE '%" + txt.Text + "%'";
                }
                else
                {
                    sqlCmd.CommandText = "SELECT ID_PRODUTO, NOME_PRODUTO, CATEGORIA_PRODUTO, MARCA_PRODUTO, PRECO_PRODUTO FROM PRODUTO WHERE NOME_PRODUTO LIKE '%" +txt.Text+ "%'";
                }
                
                sqlCmd.CommandType = CommandType.Text;

                SQLiteDataAdapter data = new SQLiteDataAdapter(sqlCmd);
                DataTable PRODUTO = new DataTable();
                data.Fill(PRODUTO);
                datagrid.DataSource = PRODUTO;
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
        }
    }
}
