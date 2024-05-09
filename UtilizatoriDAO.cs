using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace UniCatalog
{
    internal class UtilizatoriDAO
    {
        string connectionPg ="Server=localhost;Port=5432;Database=UniCatalog;User Id=postgres;Password=blue2012;";
        public class Utilizator
        {
            public string Prenume { get; set; }
            public string Nume { get; set; }
            public string Parola { get; set; }
        }

       public List<Utilizator> GetUtilizatori()
        {
            List<Utilizator> utilizatori = new List<Utilizator>();
            using (NpgsqlConnection con = new NpgsqlConnection(connectionPg))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM utilizatori", con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Utilizator utilizator = new Utilizator();
                            utilizator.Prenume = reader["prenume"].ToString();
                            utilizator.Nume = reader["nume"].ToString();
                            utilizator.Parola = reader["parola"].ToString();
                            utilizatori.Add(utilizator);
                        }
                    }
                }
            }
            return utilizatori;
        }
    }
}
