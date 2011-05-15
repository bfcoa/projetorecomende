using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Projeto_Recomende.Util
{
    public class AdoUtils
    {
        private string strConnection;
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adp;
        private DataTable dt;

        private bool closeconnections;

        public AdoUtils()
        {
            strConnection = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            conn = new SqlConnection(strConnection);
            closeconnections = true;
        }

        public AdoUtils(bool closeConnections)
        {
            strConnection = ConfigurationManager.ConnectionStrings["user"].ConnectionString;
            conn = new SqlConnection(strConnection);
            this.closeconnections = closeConnections;
        }




        /// <summary>
        /// Executa um comando que retorna uma tabela do banco de dados
        /// </summary>
        /// <param name="procedure">Nome do comando/procedure a ser executado</param>
        /// <param name="parameters">Chave-Valor com o nome do parâmetro (chave) e o valor do parâmetro(valor)</param>
        /// <returns></returns>
        public DataTable GetDataTable(string query, params KeyValuePair<string, object>[] parameters)
        {
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand(query, conn);
                foreach (KeyValuePair<string, object> item in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                adp = new SqlDataAdapter(cmd);
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                adp.Fill(dt);
                return dt;
            }
            finally
            {
                if (closeconnections)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Executa um comando que retorna uma tabela do banco de dados
        /// </summary>
        /// <param name="string_sql">Nome do comando/procedure a ser executado</param>
        /// <returns></returns>
        public DataTable GetDataTable(string string_sql)
        {
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand(string_sql, conn);
                adp = new SqlDataAdapter(cmd);
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                adp.Fill(dt);
                return dt;
            }
            finally
            {
                if (closeconnections)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public bool ExecuteCommand(string string_sql)
        {
            try
            {
                cmd = new SqlCommand(string_sql, conn);
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                if (closeconnections)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public bool ExecuteCommand(string query, params KeyValuePair<string, object>[] parameters)
        {
            try
            {
                cmd = new SqlCommand(query, conn);
                foreach (KeyValuePair<string, object> item in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            finally
            {
                if (closeconnections)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public object GetObject(string string_sql)
        {
            try
            {

                cmd = new SqlCommand(string_sql, conn);

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                return cmd.ExecuteScalar();
            }

            finally
            {
                if (closeconnections)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public object GetObject(string string_sql, params KeyValuePair<string, object>[] parameters)
        {
            try
            {
                cmd = new SqlCommand(string_sql, conn);
                foreach (KeyValuePair<string, object> item in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                return cmd.ExecuteScalar();
            }

            finally
            {
                if (closeconnections)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public static List<Hashtable> DataTableToListOfHashTable(DataTable DtTable)
        {
            List<Hashtable> result = new List<Hashtable>();

            foreach (DataRow Linha in DtTable.Rows)
            {
                Hashtable hash = new Hashtable();
                for (int ColumnIndex = 0; ColumnIndex <= DtTable.Columns.Count - 1; ColumnIndex++)
                {
                    hash.Add(DtTable.Columns[ColumnIndex].ColumnName.ToString(), Linha[ColumnIndex]);
                }
                result.Add(hash);
            }
            return result;
        }



        public static Hashtable DataTableToHashTable(ref DataTable DtTable)
        {
            Hashtable result = null;
            if (DtTable != null)
            {
                if (DtTable.Rows.Count == 1)
                {
                    result = new Hashtable();
                    for (int ColumnIndex = 0; ColumnIndex <= DtTable.Columns.Count - 1; ColumnIndex++)
                    {
                        result.Add(DtTable.Columns[ColumnIndex].ColumnName.ToString(), DtTable.Rows[0][ColumnIndex]);
                    }
                }
            }
            return result;
        }

        public bool CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
                return true;
            }
            if (conn.State != ConnectionState.Closed)
                return false;
            return true;
        }
    }
}