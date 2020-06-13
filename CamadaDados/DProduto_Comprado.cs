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
        private int _quantidadeprodutocomprado;
        private int _codfichaprodutocomprado;
        private int _codprodutocomprado;

        public DProduto_Comprado() { }

        public DProduto_Comprado(int idprodutocomprado, int quantidadeprodutocomprado, int codfichaprodutocomprado, int codprodutocomprado)
        {
            this._idprodutocomprado = idprodutocomprado;
            this._quantidadeprodutocomprado = quantidadeprodutocomprado;
            this._codfichaprodutocomprado = codfichaprodutocomprado;
            this._codprodutocomprado = codprodutocomprado;
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

        public int CodProduto
        {
            get
            {
                return _codprodutocomprado;
            }

            set
            {
                _codprodutocomprado = value;
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
                sqlCmd.CommandText = "INSERT INTO PRODUTOS_COMPRADOS (QUANTIDADE_PRODUTO_COMPRADO, COD_FICHA_PRODUTO_COMPRADO, COD_PRODUTO_COMPRADO) VALUES (@QUANTIDADE_PRODUTO_COMPRADO, @COD_FICHA_PRODUTO_COMPRADO, @COD_PRODUTO_COMPRADO);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parQuantidadeProdutoComprado = new SQLiteParameter();
                parQuantidadeProdutoComprado.ParameterName = "@QUANTIDADE_PRODUTO_COMPRADO";
                parQuantidadeProdutoComprado.DbType = DbType.Int32;
                parQuantidadeProdutoComprado.Value = produtocomprado.QuantidadeProdutoComprado;
                sqlCmd.Parameters.Add(parQuantidadeProdutoComprado);

                SQLiteParameter parCodFicha = new SQLiteParameter();
                parCodFicha.ParameterName = "@COD_FICHA_PRODUTO_COMPRADO";
                parCodFicha.DbType = DbType.Int32;
                parCodFicha.Value = produtocomprado.CodFicha;
                sqlCmd.Parameters.Add(parCodFicha);

                SQLiteParameter parCodProduto = new SQLiteParameter();
                parCodProduto.ParameterName = "@COD_PRODUTO_COMPRADO";
                parCodProduto.DbType = DbType.Int32;
                parCodProduto.Value = produtocomprado.CodProduto;
                sqlCmd.Parameters.Add(parCodProduto);

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
