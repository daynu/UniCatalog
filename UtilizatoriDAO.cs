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
       static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);

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

        public Utilizator GetUtilizator(string prenume, string nume)
        {
            Utilizator utilizator = new Utilizator();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM utilizatori WHERE prenume = '" + prenume + "' AND nume = '" + nume + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                utilizator.Prenume = reader["prenume"].ToString();
                utilizator.Nume = reader["nume"].ToString();
                utilizator.Parola = reader["parola"].ToString();
                utilizator.Rol = reader["rol"].ToString();
            }
            connection.Close();
            return utilizator;
        }

        public void AddUtilizator(string nume, string prenume, string parola, string rol)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO utilizatori (nume, prenume, parola, rol) VALUES ('" + nume + "', '" + prenume + "', '" + parola + "', '" + rol + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
