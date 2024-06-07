using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UniCatalog
{
    internal class CatalogDAO
    {
        static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);
        public static List<String> getDisciplina(String program, String an)
        {
            List<String> discipline = new List<String>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT disciplina.nume FROM disciplina " +
                "WHERE disciplina.program_id = (SELECT id FROM program_de_studiu " +
                "WHERE nume = '" + program + "' ) AND disciplina.an = '" + an + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String disciplina = reader["nume"].ToString();
                discipline.Add(disciplina);
            }
            connection.Close();
            return discipline;
        }



    }
}
