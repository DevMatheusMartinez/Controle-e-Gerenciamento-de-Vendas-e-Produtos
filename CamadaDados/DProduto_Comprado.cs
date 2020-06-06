using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class DProduto_Comprado
    {
        private int _idprodutocomprado;
        private string _nomeprodutocomprado;
        private int _quantidadeprodutocomprado;
        private int _codfichaprodutocomprado;

        public DProduto_Comprado() { }

        public DProduto_Comprado(int idprodutocomprado, string nomeprodutocomprado, int quantidadeprodutocomprado, int codfichaprodutocomprado)
        {
            this._idprodutocomprado = idprodutocomprado;
            this._nomeprodutocomprado = nomeprodutocomprado;
            this._quantidadeprodutocomprado = quantidadeprodutocomprado;
            this._codfichaprodutocomprado = codfichaprodutocomprado;
        }

        public int IdProdutoComprado
        {
            get
            {
                return _idprodutocomprado;
            }

            set
            {
                _idprodutocomprado = value;
            }
        }

        public string NomeProdutoComprado
        {
            get
            {
                return _nomeprodutocomprado;
            }

            set
            {
                _nomeprodutocomprado = value;
            }
        }

        public int QuantidadeProdutoComprado
        {
            get
            {
                return _idprodutocomprado;
            }

            set
            {
                _idprodutocomprado = value;
            }
        }

        public int CodFicha
        {
            get
            {
                return _codfichaprodutocomprado;
            }

            set
            {
                _codfichaprodutocomprado = value;
            }
        }

        public string inserirProdutoComprado(DProduto_Comprado produtocomprado)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO PRODUTOS_COMPRADOS (NOME_PRODUTO_COMPRADO, QUANTIDADE_PRODUTO_COMPRADO, COD_FICHA) VALUES (@NOME_PRODUTO_COMPRADO, @QUANTIDADE_PRODUTO_COMPRADO, @COD_FICHA);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parNomeProdutoComprado = new SQLiteParameter();
                parNomeProdutoComprado.ParameterName = "@NOME_PRODUTO_COMPRADO";
                parNomeProdutoComprado.DbType = DbType.String;
                parNomeProdutoComprado.Size = 70;
                parNomeProdutoComprado.Value = produtocomprado.NomeProdutoComprado;
                sqlCmd.Parameters.Add(parNomeProdutoComprado);

                SQLiteParameter parQuantidadeProdutoComprado = new SQLiteParameter();
                parQuantidadeProdutoComprado.ParameterName = "@QUANTIDADE_PRODUTO_COMPRADO";
                parQuantidadeProdutoComprado.DbType = DbType.Int32;
                parQuantidadeProdutoComprado.Value = produtocomprado.QuantidadeProdutoComprado;
                sqlCmd.Parameters.Add(parQuantidadeProdutoComprado);

                SQLiteParameter parCodFicha = new SQLiteParameter();
                parCodFicha.ParameterName = "@COD_FICHA";
                parCodFicha.DbType = DbType.Int32;
                parCodFicha.Value = produtocomprado.CodFicha;
                sqlCmd.Parameters.Add(parCodFicha);

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
