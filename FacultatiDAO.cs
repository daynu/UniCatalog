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

        public static List<String> getPrograme(String departament)
        {

            List<String> programe = new List<String>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT program_de_studiu.nume FROM program_de_studiu " +
              "JOIN departamente ON program_de_studiu.departament_id = departamente.id " +
                "WHERE departamente.nume = " + "'" + departament + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String program = reader["nume"].ToString();
                programe.Add(program);
            }
            connection.Close();
            return programe;
        }

        public static List<String> getGrupa(String program, String an)
        {
            List<String> grupe = new List<String>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT grupa.nume FROM grupa " +
                "JOIN program_de_studiu ON grupa.program_de_studii_id = program_de_studiu.id " +
                "WHERE program_de_studiu.nume = " + "'" + program + "'" + " AND grupa.an_de_studiu = " + "'" + an + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String grupa = reader["nume"].ToString();
                grupe.Add(grupa);
            }
            connection.Close();
            return grupe;
        }   


        public static void adaugaGrupa(String numeGrupa, String an, String Program)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO grupa (nume, an_de_studiu, program_de_studii_id) VALUES ('" + numeGrupa + "', '" + an + "', (SELECT id FROM program_de_studiu WHERE nume = '" + Program + "'))";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
   
}
