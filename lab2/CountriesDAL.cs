using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FootballerManagementSystem
{
    public struct Country
    {
        private int countryID;
        private string countryName;

        public int CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public Country(int cID, string cName)
        {
            countryID = cID;
            countryName = cName;
        }
    }

    public class CountriesDAL : DALGen
    {
        public List<Country> GetCountryList(ref string error)
        {
            string query = "SELECT * FROM Orszagok";
            SqlDataReader dataReader = ExecuteReader(query, ref error);

            List<Country> countryList = new List<Country>();

            if (error == "OK")
            {
                Country item0 = new Country();
                item0.CountryID = 0;
                item0.CountryName = "Minden orszag";
                countryList.Add(item0);

                Country item = new Country();
                while (dataReader.Read())
                {
                    try
                    {
                        item.CountryID = Convert.ToInt32(dataReader[0]);
                        item.CountryName = dataReader[1].ToString();
                        countryList.Add(item);
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }
                }
            }
            CloseDataReader(dataReader);

            return countryList;
        }
    }
}
