using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UniCatalog
{
    internal class FacultatiDAO
    {
        static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);
        public static List<String> GetFacultati()
        {
            List<String> facultati = new List<String>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM facultate";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String facultate = reader["nume"].ToString();
                facultati.Add(facultate);
            }
            connection.Close();
            return facultati;
        }

        public static List<String> getDepartamente(String facultate)
        {
            List<String> departamente = new List<String>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT departamente.nume FROM departamente " +
                "JOIN facultate_departamente ON " +
                "departamente.id = facultate_departamente.departament_id " +
                "JOIN facultate ON facultate.id = facultate_departamente.facultate_id " +
                "WHERE facultate.nume = " + "'" + facultate + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String departament = reader["nume"].ToString();
                departamente.Add(departament);
            }
            connection.Close();
            return departamente;
        }

    }
}
