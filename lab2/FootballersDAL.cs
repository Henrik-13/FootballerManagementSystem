using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FootballerManagementSystem
{
    public struct Footballer
    {
        private int footballerID;
        private string footballerName;
        Country country;
        private int goals;
        private int assists;
        private int age;
        private int currentValue;

        public int FootballerID
        {
            get { return footballerID; }
            set { footballerID = value; }
        }

        public string FootballerName
        {
            get { return footballerName; }
            set { footballerName = value; }
        }

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }

        public int Goals
        {
            get { return goals; }
            set { goals = value; }
        }

        public int Assists
        {
            get { return assists; }
            set { assists = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int CurrentValue
        {
            get { return currentValue; } 
            set {  currentValue = value; }
        }
    }

    public class FootballersDAL : DALGen
    {
        public FootballersDAL(int login, ref string error, string username = "", string password = "")
        {
            if (login == 0)
            {
                strSqlConn = "Data Source=LEGION;Initial Catalog=bhim2208_AB;uid=Adminisztrator;pwd=admin";
            }
            else if (login == 1)
            {
                strSqlConn = "Data Source=LEGION;Initial Catalog=bhim2208_AB;uid=" + username + ";pwd=" + password;
            }
            else if (login == 2)
            {
                strSqlConn = "Data Source=LEGION;Initial Catalog=bhim2208_AB;uid=Vendeg;pwd=vendeg";
            }
            else
            {
                strSqlConn = "Data Source=LEGION;Initial Catalog=bhim2208_AB;Integrated Security=SSPI";
            }
            base.CreateConnection(ref error);
        }


        public List<Footballer> GetFootballerListDataSet(int countryID, string name, ref string error)
        {
            string query = "SELECT FID, FNev, Orszagok.OID, Orszagok.OrszagNev, Osszgolok, Osszgolpasszok, Eletkor, AktualisErtek "
                           + "FROM Focistak, Orszagok "
                           + "WHERE Focistak.OID = Orszagok.OID ";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (countryID > 0)
            {
                query += "and Orszagok.OID = @OID ";
                parameters.Add(new SqlParameter("@OID", countryID));
            }

            if (name != null)
            {
                query += "and FNev LIKE @name";
                parameters.Add(new SqlParameter("@name", name + "%"));
            }

            DataSet ds_tabla = new DataSet();
            ds_tabla = ExecuteDS(query, parameters, ref error);

            List<Footballer> footballerList = new List<Footballer>();

            if (error == "OK")
            {
                Footballer item = new Footballer();
                foreach (DataRow r in ds_tabla.Tables[0].Rows)
                {
                    try
                    {
                        item.FootballerID = Convert.ToInt32(r["FID"]);
                        item.FootballerName = r["FNev"].ToString();
                        item.Country = new Country(Convert.ToInt32(r["OID"]), r["OrszagNev"].ToString());
                        item.Goals = Convert.ToInt32(r["Osszgolok"]);
                        item.Assists = Convert.ToInt32(r["Osszgolpasszok"]);
                        item.Age = Convert.ToInt32(r["Eletkor"]);
                        item.CurrentValue = Convert.ToInt32(r["AktualisErtek"]);
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }

                    footballerList.Add(item);
                }
            }
            return footballerList;
        }

        public void DeleteFootballer(int FID, ref string error)
        {
            string query = "DELETE FROM Focistak WHERE FID = @FID";
            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text
            };

            command.Parameters.AddWithValue("@FID", FID);
            ExecuteNonQuery(command, ref error);
        }

        public int GetGoals(int FID, ref string error)
        {
            string query = "SELECT Osszgolok FROM Focistak WHERE FID = @FID";

            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text
            };

            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@FID",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = FID
            };

            command.Parameters.Add(parameter);

            int goals = Convert.ToInt32(ExecuteScalar(command, ref error));
            return goals;
        }

        public void UpdateFootballerGoals(int FID, int goals, ref string error)
        {
            string query = "UPDATE Focistak SET OsszGolok = @goals WHERE FID = @FID";
            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text
            };
            command.Parameters.AddWithValue("@goals", goals);
            command.Parameters.AddWithValue("@FID", FID);
            ExecuteNonQuery(command, ref error);
        }

        public void CreateUser(string username, string password, ref string error)
        {
            SqlCommand command = new SqlCommand
            {
                CommandText = "sp_Regisztracio",
                CommandType = CommandType.StoredProcedure
            };

            SqlParameter pUsername = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = username
            };
            command.Parameters.Add(pUsername);

            SqlParameter pPassword = new SqlParameter
            {
                ParameterName = "@password",
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = password
            };
            command.Parameters.Add(pPassword);

            ExecuteNonQuery(command, ref error);
        }

        public bool existsUser(string username, ref string error)
        {
            //SqlParameter parameter = new SqlParameter
            //{
            //    ParameterName = "@FID",
            //    SqlDbType = SqlDbType.Int,
            //    Direction = ParameterDirection.Input,
            //    Value = username
            //};
            //SqlCommand
            //ExecuteScalar()

            string query = "SELECT name FROM sys.database_principals WHERE name = @username";


            SqlCommand command = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text
            };

            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@username",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = username
            };

            command.Parameters.Add(parameter);

            if (ExecuteScalar(command, ref error) != null)
            {
                return true;
            }
            return false;
        }
        
    }
}
