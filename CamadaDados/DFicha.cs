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
    public class DFicha
    {
        private int _idficha;
        private string _identificacaoficha;
        private decimal _precoficha;
        private string _datacompraficha;
        private string _datapagoficha;
        private string _datavencimentoficha;
        private string _situacao;
        private string _forma_pagamento;
        private int _codclienteficha;

        public DFicha() { }

        public DFicha(int idficha, string identificacaoficha, decimal precoficha, string datacompraficha, string datapagoficha, string datavencimentoficha, string situacao, string formapagamento, int codclienteficha)
        {
            this._idficha = idficha;
            this._identificacaoficha = identificacaoficha;
            this._precoficha = precoficha;
            this._datacompraficha = datacompraficha;
            this._datapagoficha = datapagoficha;
            this._datavencimentoficha = datavencimentoficha;
            this._forma_pagamento = formapagamento;
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

        public string FormaPagamento
        {
            get
            {
                return _forma_pagamento;
            }

            set
            {
                _forma_pagamento = value;
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
                sqlCmd.CommandText = "INSERT INTO FICHA (IDENTIFICACAO_FICHA, PRECO_FICHA, DATA_COMPRA_FICHA, DATA_PAGAMENTO_FICHA, DATA_VENCIMENTO_FICHA, SITUACAO_FICHA, FORMA_PAGAMENTO_FICHA, COD_CLIENTE_FICHA) VALUES (@IDENTIFICACAO_FICHA, @PRECO_FICHA, @DATA_COMPRA_FICHA, @DATA_PAGAMENTO_FICHA, @DATA_VENCIMENTO_FICHA, @SITUACAO_FICHA, @FORMA_PAGAMENTO_FICHA, @COD_CLIENTE_FICHA);";
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

                SQLiteParameter parFormaPagamento = new SQLiteParameter();
                parFormaPagamento.ParameterName = "@FORMA_PAGAMENTO_FICHA";
                parFormaPagamento.DbType = DbType.String;
                parFormaPagamento.Value = ficha.FormaPagamento;
                sqlCmd.Parameters.Add(parFormaPagamento);

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

        public string editarFichaPagamentoPosSalvamento(DFicha ficha)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "UPDATE FICHA SET DATA_PAGAMENTO_FICHA = @DATA_PAGAMENTO_FICHA, SITUACAO_FICHA = @SITUACAO_FICHA, FORMA_PAGAMENTO_FICHA = @FORMA_PAGAMENTO_FICHA WHERE ID_FICHA = @ID_FICHA;";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parId = new SQLiteParameter();
                parId.ParameterName = "@ID_FICHA";
                parId.DbType = DbType.Int32;
                parId.Value = ficha.IdFicha;
                sqlCmd.Parameters.Add(parId);

                SQLiteParameter parPagamentoData = new SQLiteParameter();
                parPagamentoData.ParameterName = "@DATA_PAGAMENTO_FICHA";
                parPagamentoData.DbType = DbType.String;
                parPagamentoData.Size = 70;
                parPagamentoData.Value = ficha.DataPagoFicha;
                sqlCmd.Parameters.Add(parPagamentoData);

                SQLiteParameter parSituacao = new SQLiteParameter();
                parSituacao.ParameterName = "@SITUACAO_FICHA";
                parSituacao.DbType = DbType.String;
                parSituacao.Value = ficha.Situacao;
                sqlCmd.Parameters.Add(parSituacao);

                SQLiteParameter parFormaPagamento = new SQLiteParameter();
                parFormaPagamento.ParameterName = "@FORMA_PAGAMENTO_FICHA";
                parFormaPagamento.DbType = DbType.String;
                parFormaPagamento.Value = ficha.FormaPagamento;
                sqlCmd.Parameters.Add(parFormaPagamento);

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

        public DataTable mostrarFicha()
        {
            DataTable DtResultado = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon.ConnectionString = Conexao.Cn;
                sqlcon.Open();

                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "SELECT F.IDENTIFICACAO_FICHA, C.NOME_CLIENTE, F.DATA_COMPRA_FICHA, F.DATA_PAGAMENTO_FICHA, F.DATA_VENCIMENTO_FICHA, F.PRECO_FICHA, F.SITUACAO_FICHA FROM CLIENTE AS C JOIN FICHA AS F ON COD_CLIENTE_FICHA = ID_CLIENTE";
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

        public void filtrarDados(TextBox txt, DataGridView datagrid)
        {
            SQLiteConnection sqlCon = new SQLiteConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT F.IDENTIFICACAO_FICHA, C.NOME_CLIENTE, F.DATA_COMPRA_FICHA, F.DATA_PAGAMENTO_FICHA, F.DATA_VENCIMENTO_FICHA, F.PRECO_FICHA, F.SITUACAO_FICHA FROM CLIENTE AS C JOIN FICHA AS F ON COD_CLIENTE_FICHA = ID_CLIENTE WHERE C.NOME_CLIENTE LIKE '%" + txt.Text + "%'";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteDataAdapter data = new SQLiteDataAdapter(sqlCmd);
                DataTable FICHA = new DataTable();
                data.Fill(FICHA);
                datagrid.DataSource = FICHA;
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
        }

        public string[] carregarDadosFicha(DFicha ficha)
        {
            string[] dados = new string[13];
            SQLiteConnection sqlCon = new SQLiteConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT F.ID_FICHA, F.IDENTIFICACAO_FICHA, F.PRECO_FICHA, F.DATA_COMPRA_FICHA, F.DATA_PAGAMENTO_FICHA, F.DATA_VENCIMENTO_FICHA, F.FORMA_PAGAMENTO_FICHA, F.COD_CLIENTE_FICHA, F.SITUACAO_FICHA, C.NOME_CLIENTE, C.CPF_CLIENTE, C.ENDERECO_CLIENTE, C.EMAIL_CLIENTE FROM CLIENTE AS C JOIN FICHA AS F ON COD_CLIENTE_FICHA = ID_CLIENTE WHERE F.IDENTIFICACAO_FICHA = @IDENTIFICACAO_FICHA";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parIdentificacao = new SQLiteParameter();
                parIdentificacao.ParameterName = "@IDENTIFICACAO_FICHA";
                parIdentificacao.DbType = DbType.String;
                parIdentificacao.Value = ficha.IdentificacaoFicha;
                sqlCmd.Parameters.Add(parIdentificacao);

                SQLiteDataReader leitor = sqlCmd.ExecuteReader();

                while (leitor.Read())
                {
                    dados[0] = (leitor["ID_FICHA"].ToString());
                    dados[1] = (leitor["IDENTIFICACAO_FICHA"].ToString());
                    dados[2] = (leitor["PRECO_FICHA"].ToString());
                    dados[3] = (leitor["DATA_COMPRA_FICHA"].ToString());
                    dados[4] = (leitor["DATA_PAGAMENTO_FICHA"].ToString());
                    dados[5] = (leitor["DATA_VENCIMENTO_FICHA"].ToString());
                    dados[6] = (leitor["COD_CLIENTE_FICHA"].ToString());
                    dados[7] = (leitor["FORMA_PAGAMENTO_FICHA"].ToString());
                    dados[8] = (leitor["SITUACAO_FICHA"].ToString());
                    dados[9] = (leitor["NOME_CLIENTE"].ToString());
                    dados[10] = (leitor["CPF_CLIENTE"].ToString());
                    dados[11] = (leitor["ENDERECO_CLIENTE"].ToString());
                    dados[12] = (leitor["EMAIL_CLIENTE"].ToString());
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
    }
}
