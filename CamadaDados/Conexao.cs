using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class Conexao
    {
        public static void criarBanco()
        { 
            string nomebanco = "Banco.db";
            if (!File.Exists(nomebanco))
            {
                SQLiteConnection.CreateFile(nomebanco);
            }
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = Conexao.Cn;
            conn.Open();

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS ADMINISTRADOR ([ID_ADMINISTRADOR] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[NOME_ADMINISTRADOR] VARCHAR(45) NOT NULL,");
            sql.AppendLine("[LOGIN_ADMINISTRADOR] VARCHAR(45) NOT NULL,");
            sql.AppendLine("[SENHA_ADMINISTRADOR] VARCHAR(45) NOT NULL);");

            sql.AppendLine("CREATE TABLE IF NOT EXISTS PRODUTO ([ID_PRODUTO] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[NOME_PRODUTO] VARCHAR(70) NOT NULL,");
            sql.AppendLine("[CATEGORIA_PRODUTO] VARCHAR(70) NOT NULL,");
            sql.AppendLine("[MARCA_PRODUTO] VARCHAR(70) NOT NULL,");
            sql.AppendLine("[PRECO_PRODUTO] REAL NOT NULL,");
            sql.AppendLine("[ESTOQUE_PRODUTO] INT);");

            sql.AppendLine("CREATE TABLE IF NOT EXISTS CATEGORIA ([ID_CATEGORIA] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[NOME_CATEGORIA] VARCHAR(45) NOT NULL);");

            sql.AppendLine("CREATE TABLE IF NOT EXISTS MARCA ([ID_MARCA] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[NOME_MARCA] VARCHAR(45) NOT NULL);");

            sql.AppendLine("CREATE TABLE IF NOT EXISTS CLIENTE ([ID_CLIENTE] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[NOME_CLIENTE] VARCHAR(80) NOT NULL,");
            sql.AppendLine("[CPF_CLIENTE] VARCHAR(25) NOT NULL,");
            sql.AppendLine("[ENDERECO_CLIENTE] VARCHAR(70),");
            sql.AppendLine("[EMAIL_CLIENTE] VARCHAR(70));");

            sql.AppendLine("CREATE TABLE IF NOT EXISTS TELEFONE ([ID_TELEFONE] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[TELEFONE] VARCHAR(80),");
            sql.AppendLine("[COD_CLIENTE_TELEFONE] INT NOT NULL,");
            sql.AppendLine("FOREIGN KEY(COD_CLIENTE_TELEFONE) REFERENCES CLIENTE(ID_CLIENTE));");

            sql.AppendLine("CREATE TABLE IF NOT EXISTS FICHA ([ID_FICHA] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[IDENTIFICACAO_FICHA] VARCHAR(80) NOT NULL,");
            sql.AppendLine("[PRECO_FICHA] REAL NOT NULL,");
            sql.AppendLine("[DATA_COMPRA_FICHA] TEXT NOT NULL,");
            sql.AppendLine("[DATA_PAGAMENTO_FICHA] TEXT NOT NULL,");
            sql.AppendLine("[DATA_VENCIMENTO_FICHA] TEXT NOT NULL,");
            sql.AppendLine("[COD_CLIENTE_FICHA] INTEGER NOT NULL,");
            sql.AppendLine("[SITUACAO_FICHA] VARCHAR(12) NOT NULL,");
            sql.AppendLine("FOREIGN KEY(COD_CLIENTE_FICHA) REFERENCES CLIENTE(ID_CLIENTE));");

            sql.AppendLine("CREATE TABLE IF NOT EXISTS PRODUTOS_COMPRADOS ([ID_PRODUTO_COMPRADO] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,");
            sql.AppendLine("[QUANTIDADE_PRODUTO_COMPRADO] INTEGER NOT NULL,");
            sql.AppendLine("[COD_FICHA_PRODUTO_COMPRADO] INTEGER NOT NULL,");
            sql.AppendLine("[COD_PRODUTO_COMPRADO] INTEGER NOT NULL,");
            sql.AppendLine("FOREIGN KEY(COD_PRODUTO_COMPRADO) REFERENCES CLIENTE(ID_PRODUTO),");
            sql.AppendLine("FOREIGN KEY(COD_FICHA_PRODUTO_COMPRADO) REFERENCES CLIENTE(ID_FICHA));");

            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                string e = ex.Message;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }

        public static void inserirDadosPadraoMarca()
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO MARCA (NOME_MARCA) SELECT 'Sem Marca' WHERE NOT EXISTS (SELECT 1 FROM MARCA WHERE NOME_MARCA = 'Sem Marca');";
                sqlCmd.CommandType = CommandType.Text;

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
        }

        public static void inserirDadosPadraoCategoria()
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO CATEGORIA(NOME_CATEGORIA) SELECT 'Sem Categoria' WHERE NOT EXISTS (SELECT 1 FROM CATEGORIA WHERE NOME_CATEGORIA = 'Sem Categoria');";
                sqlCmd.CommandType = CommandType.Text;

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
        }

        public static void inserirDadosPadraoCliente()
        {
            string resp = "";
            SQLiteConnection sqlCon = new SQLiteConnection();

            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "INSERT INTO CLIENTE(NOME_CLIENTE) SELECT 'Selecionar Cliente' WHERE NOT EXISTS (SELECT 1 FROM CLIENTE WHERE NOME_CLIENTE = 'Selecionar Cliente');";
                sqlCmd.CommandType = CommandType.Text;

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
        }

        public static string Cn = "Data Source =Banco.db";
    }
}
