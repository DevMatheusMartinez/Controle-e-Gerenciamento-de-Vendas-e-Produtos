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
    public class DCliente
    {
        private int _clienteid;
        private string _clientenome;
        private string _clientecpf;
        private string _clienteendereco;
        private string _clienteemail;

        public DCliente() { }
        public DCliente(int idcliente, string nomecliente, string cpfcliente, string enderecocliente, string emailcliente)
        {
            this._clienteid = idcliente;
            this._clientenome = nomecliente;
            this._clientecpf = cpfcliente;
            this._clienteendereco = enderecocliente;
            this._clienteemail = emailcliente;
        }

        public int IdCliente
        {
            get
            {
                return _clienteid;
            }

            set
            {
                _clienteid = value;
            }
        }

        public string NomeCliente
        {
            get
            {
                return _clientenome;
            }

            set
            {
                _clientenome = value;
            }
        }

        public string CpfCliente
        {
            get
            {
                return _clientecpf;
            }

            set
            {
                _clientecpf = value;
            }
        }

        public string EnderecoCliente
        {
            get
            {
                return _clienteendereco;
            }

            set
            {
                _clienteendereco = value;
            }
        }

        public string EmailCliente
        {
            get
            {
                return _clienteemail;
            }

            set
            {
                _clienteemail = value;
            }
        }

        public string inserirCliente(DCliente cliente)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO CLIENTE (NOME_CLIENTE, CPF_CLIENTE, ENDERECO_CLIENTE, EMAIL_CLIENTE) VALUES (@NOME_CLIENTE, @CPF_CLIENTE, @ENDERECO_CLIENTE, @EMAIL_CLIENTE);";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parNomeCliente = new SQLiteParameter();
                parNomeCliente.ParameterName = "@NOME_CLIENTE";
                parNomeCliente.DbType = DbType.String;
                parNomeCliente.Size = 80;
                parNomeCliente.Value = cliente.NomeCliente;
                sqlCmd.Parameters.Add(parNomeCliente);

                SQLiteParameter parCpfCliente = new SQLiteParameter();
                parCpfCliente.ParameterName = "@CPF_CLIENTE";
                parCpfCliente.DbType = DbType.String;
                parCpfCliente.Value = cliente.CpfCliente;
                sqlCmd.Parameters.Add(parCpfCliente);

                SQLiteParameter parEnderecoCliente = new SQLiteParameter();
                parEnderecoCliente.ParameterName = "@ENDERECO_CLIENTE";
                parEnderecoCliente.DbType = DbType.String;
                parEnderecoCliente.Value = cliente.EnderecoCliente;
                sqlCmd.Parameters.Add(parEnderecoCliente);

                SQLiteParameter parEmailCliente = new SQLiteParameter();
                parEmailCliente.ParameterName = "@EMAIL_CLIENTE";
                parEmailCliente.DbType = DbType.String;
                parEmailCliente.Value = cliente.EmailCliente;
                sqlCmd.Parameters.Add(parEmailCliente);

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

        public string editarCliente(DCliente cliente)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "UPDATE CLIENTE SET NOME_CLIENTE = @NOME_CLIENTE, CPF_CLIENTE = @CPF_CLIENTE, ENDERECO_CLIENTE = @ENDERECO_CLIENTE, EMAIL_CLIENTE = @EMAIL_CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE;";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parIdCliente = new SQLiteParameter();
                parIdCliente.ParameterName = "@ID_CLIENTE";
                parIdCliente.DbType = DbType.Int32;
                parIdCliente.Value = cliente.IdCliente;
                sqlCmd.Parameters.Add(parIdCliente);

                SQLiteParameter parNomeCliente = new SQLiteParameter();
                parNomeCliente.ParameterName = "@NOME_CLIENTE";
                parNomeCliente.DbType = DbType.String;
                parNomeCliente.Size = 80;
                parNomeCliente.Value = cliente.NomeCliente;
                sqlCmd.Parameters.Add(parNomeCliente);

                SQLiteParameter parCpfCliente = new SQLiteParameter();
                parCpfCliente.ParameterName = "@CPF_CLIENTE";
                parCpfCliente.DbType = DbType.String;
                parCpfCliente.Value = cliente.CpfCliente;
                sqlCmd.Parameters.Add(parCpfCliente);

                SQLiteParameter parEnderecoCliente = new SQLiteParameter();
                parEnderecoCliente.ParameterName = "@ENDERECO_CLIENTE";
                parEnderecoCliente.DbType = DbType.String;
                parEnderecoCliente.Value = cliente.EnderecoCliente;
                sqlCmd.Parameters.Add(parEnderecoCliente);

                SQLiteParameter parEmailCliente = new SQLiteParameter();
                parEmailCliente.ParameterName = "@EMAIL_CLIENTE";
                parEmailCliente.DbType = DbType.String;
                parEmailCliente.Value = cliente.EmailCliente;
                sqlCmd.Parameters.Add(parEmailCliente);

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

        public string deletarCliente(DCliente cliente)
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE;";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteParameter parIdCliente = new SQLiteParameter();
                parIdCliente.ParameterName = "@ID_CLIENTE";
                parIdCliente.DbType = DbType.Int32;
                parIdCliente.Value = cliente.IdCliente;
                sqlCmd.Parameters.Add(parIdCliente);

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

        public DataTable mostrar()
        {
            DataTable DtResultado = new DataTable("CLIENTE");
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon.ConnectionString = Conexao.Cn;
                sqlcon.Open();

                SQLiteCommand sqlcmd = new SQLiteCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "SELECT * FROM CLIENTE";
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
                sqlCmd.CommandText = "SELECT * FROM CLIENTE WHERE NOME_CLIENTE LIKE '%" + txt.Text + "%'";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteDataAdapter data = new SQLiteDataAdapter(sqlCmd);
                DataTable CLIENTE = new DataTable();
                data.Fill(CLIENTE);
                datagrid.DataSource = CLIENTE;
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
        }

        public int carregarUltimoIdCliente()
        {
            int codcliente = new int();
            SQLiteConnection sqlCon = new SQLiteConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SELECT * FROM CLIENTE WHERE ID_CLIENTE = (SELECT MAX(ID_CLIENTE) FROM CLIENTE)";
                sqlCmd.CommandType = CommandType.Text;

                SQLiteDataReader leitor = sqlCmd.ExecuteReader();
                while (leitor.Read())
                {
                    codcliente = Convert.ToInt32(leitor["ID_CLIENTE"]);
                }
                    
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) { sqlCon.Close(); }
            }
            return codcliente;
        }
    }
}
