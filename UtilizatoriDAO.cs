using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UniCatalog
{
    internal class UtilizatoriDAO
    {
       static string connectionSQL = "Server = sql11.freesqldatabase.com; Port = 3306; Database = sql11705978; Uid = sql11705978; Pwd = ZVsuYEK9M8;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);
        public class Utilizator
        {
            public string Prenume { get; set; }
            public string Nume { get; set; }
            public string Parola { get; set; }
            public string Rol { get; set; } 
        }

       public List<Utilizator> GetUtilizatori()
        {
            List<Utilizator> utilizatori = new List<Utilizator>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM utilizatori";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Utilizator utilizator = new Utilizator();
                utilizator.Prenume = reader["prenume"].ToString();
                utilizator.Nume = reader["nume"].ToString();
                utilizator.Parola = reader["parola"].ToString();
                utilizator.Rol = reader["rol"].ToString();
                utilizatori.Add(utilizator);
            }
            connection.Close();
            return utilizatori;
        }
    }
}
