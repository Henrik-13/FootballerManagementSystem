using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballerManagementSystem
{
    public abstract class DALGen
    {
        protected static bool isConnected;
        protected static SqlConnection sqlConnection;
        protected string strSqlConn;
        //= "Data Source=LEGION;Initial Catalog=bhim2208_AB;Integrated Security=SSPI";

        protected void CreateConnection(ref string errMess)
        {
            if (isConnected != true)
            {
                try
                {
                    sqlConnection = new SqlConnection(strSqlConn);
                    sqlConnection.Open();
                    errMess = "OK";
                }
                catch (SqlException ex)
                {
                    errMess = ex.Message;
                }
                finally
                {
                    if (sqlConnection != null)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void OpenConnection(ref string errMess)
        {
            if (!isConnected)
            {
                try
                {
                    sqlConnection.Open();
                    isConnected = true;
                    errMess = "OK";
                }
                catch (SqlException ex)
                {
                    errMess = ex.Message;
                }
            }
        }

        private void CloseConnection()
        {
            if (isConnected)
            {
                sqlConnection.Close();
                isConnected = false;
            }
        }

        protected SqlDataReader ExecuteReader(string sQuery, ref string errMess)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                OpenConnection(ref errMess);
                SqlCommand sqlCommand = new SqlCommand(sQuery, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                errMess = "OK";
            }
            catch (Exception e)
            {
                errMess = e.Message;
                CloseDataReader(sqlDataReader);
            }

            return sqlDataReader;
        }

        protected void CloseDataReader(SqlDataReader rdr)
        {
            if (rdr != null)
            {
                rdr.Close();
            }
            CloseConnection();
        }

        protected DataSet ExecuteDS(string query, List<SqlParameter> parameters, ref string errMess)
        {
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection(ref errMess);

                SqlCommand command = new SqlCommand(query, sqlConnection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters.ToArray());
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataSet);
                errMess = "OK";
            }
            catch (SqlException e)
            {
                errMess = e.Message;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    CloseConnection();
                }
            }
            return dataSet;
        }

        protected void ExecuteNonQuery(SqlCommand command, ref string errMess)
        {
            try
            {
                OpenConnection(ref errMess);
                command.Connection = sqlConnection;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                errMess = ex.Message;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected object ExecuteScalar(SqlCommand command, ref string errMess)
        {
            object value;
            try
            {
                OpenConnection(ref errMess);
                command.Connection = sqlConnection;
                value = command.ExecuteScalar();
                errMess = "OK";
            }
            catch (SqlException ex)
            {
                value = null;
                errMess = ex.Message;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }
    }
}
