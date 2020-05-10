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

        public static string Cn = "Data Source =Banco.db";
    }
}
