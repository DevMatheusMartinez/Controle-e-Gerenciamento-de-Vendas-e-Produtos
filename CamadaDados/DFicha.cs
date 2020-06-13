using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class DFicha
    {
        private int _idficha;
        private string _identificacaoficha;
        private decimal _precoficha;
        private string _datacompraficha;
        private string _datapagoficha;
        private string _datavencimentoficha;
        private string _situacao;
        private int _codclienteficha;

        public DFicha() { }

        public DFicha(int idficha, string identificacaoficha, decimal precoficha, string datacompraficha, string datapagoficha, string datavencimentoficha, string situacao, int codclienteficha)
        {
            this._idficha = idficha;
            this._identificacaoficha = identificacaoficha;
            this._precoficha = precoficha;
            this._datacompraficha = datacompraficha;
            this._datapagoficha = datapagoficha;
            this._datavencimentoficha = datavencimentoficha;
            this._situacao = situacao;
            this._codclienteficha = codclienteficha;
        }

        public int IdFicha
        {
            get
            {
                return _idficha;
            }

            set
            {
                _idficha= value;
            }
        }

        public string IdentificacaoFicha
        {
            get
            {
                return _identificacaoficha;
            }

            set
            {
                _identificacaoficha = value;
            }
        }

        public decimal PrecoFicha
        {
            get
            {
                return _precoficha;
            }

            set
            {
                _precoficha = value;
            }
        }

        public string DataCompraFicha
        {
            get
            {
                return _datacompraficha;
            }

            set
            {
                _datacompraficha = value;
            }
        }

        public string DataPagoFicha
        {
            get
            {
                return _datapagoficha;
            }

            set
            {
                _datapagoficha = value;
            }
        }

        public string DataVencimentoFicha
        {
            get
            {
                return _datavencimentoficha;
            }

            set
            {
                _datavencimentoficha = value;
            }
        }

        public string Situacao
        {
            get
            {
                return _situacao;
            }

            set
            {
                _situacao = value;
            }
        }

        public int CodClienteFicha
        {
            get
            {
                return _codclienteficha;
            }

            set
            {
                _codclienteficha = value;
            }
        }

        public string inserirFicha(DFicha ficha)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO FICHA (IDENTIFICACAO_FICHA, PRECO_FICHA, DATA_COMPRA_FICHA, DATA_PAGAMENTO_FICHA, DATA_VENCIMENTO_FICHA, SITUACAO_FICHA, COD_CLIENTE_FICHA) VALUES (@IDENTIFICACAO_FICHA, @PRECO_FICHA, @DATA_COMPRA_FICHA, @DATA_PAGAMENTO_FICHA, @DATA_VENCIMENTO_FICHA, @SITUACAO_FICHA, @COD_CLIENTE_FICHA);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parIdentificacao = new SQLiteParameter();
                parIdentificacao.ParameterName = "@IDENTIFICACAO_FICHA";
                parIdentificacao.DbType = DbType.String;
                parIdentificacao.Size = 80;
                parIdentificacao.Value = ficha.IdentificacaoFicha;
                sqlCmd.Parameters.Add(parIdentificacao);

                SQLiteParameter parPreco = new SQLiteParameter();
                parPreco.ParameterName = "@PRECO_FICHA";
                parPreco.DbType = DbType.Decimal;
                parPreco.Size = 70;
                parPreco.Value = ficha.PrecoFicha;
                sqlCmd.Parameters.Add(parPreco);

                SQLiteParameter parCompraData= new SQLiteParameter();
                parCompraData.ParameterName = "@DATA_COMPRA_FICHA";
                parCompraData.DbType = DbType.String;
                parCompraData.Size = 70;
                parCompraData.Value = ficha.DataCompraFicha;
                sqlCmd.Parameters.Add(parCompraData);

                SQLiteParameter parPagamentoData = new SQLiteParameter();
                parPagamentoData.ParameterName = "@DATA_PAGAMENTO_FICHA";
                parPagamentoData.DbType = DbType.String;
                parPagamentoData.Size = 70;
                parPagamentoData.Value = ficha.DataPagoFicha;
                sqlCmd.Parameters.Add(parPagamentoData);

                SQLiteParameter parVencimentoData = new SQLiteParameter();
                parVencimentoData.ParameterName = "@DATA_VENCIMENTO_FICHA";
                parVencimentoData.DbType = DbType.String;
                parVencimentoData.Value = ficha.DataVencimentoFicha;
                sqlCmd.Parameters.Add(parVencimentoData);

                SQLiteParameter parSituacao = new SQLiteParameter();
                parSituacao.ParameterName = "@SITUACAO_FICHA";
                parSituacao.DbType = DbType.String;
                parSituacao.Value = ficha.Situacao;
                sqlCmd.Parameters.Add(parSituacao);

                SQLiteParameter parCodCliente = new SQLiteParameter();
                parCodCliente.ParameterName = "@COD_CLIENTE_FICHA";
                parCodCliente.DbType = DbType.Int32;
                parCodCliente.Value = ficha.CodClienteFicha;
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

        public bool verificarFicha()
        {
            bool resp = false;
            SQLiteConnection sqlCon = new SQLiteConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT COUNT(*) FROM FICHA";
                sqlCmd.CommandType = CommandType.Text;

                if(Convert.ToInt32(sqlCmd.ExecuteScalar()) > 0)
                {
                    resp = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return resp;
        }

        public int carregarUltimoIdFicha()
        {
            int codficha = new int();
            SQLiteConnection sqlCon = new SQLiteConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM FICHA WHERE ID_FICHA = (SELECT MAX(ID_FICHA) FROM FICHA)";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteDataReader leitor = sqlCmd.ExecuteReader();
                while (leitor.Read())
                {
                    codficha = Convert.ToInt32(leitor["ID_FICHA"]);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return codficha;
        }
    }
}
