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
                "WHERE disciplina.program_de_studiu_id = (SELECT id FROM program_de_studiu " +
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

        public static List<Catalog> getNote(String disciplina, String grupa)
        {
            List<Catalog> list = new List<Catalog>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT studenti.nume, studenti.prenume, catalog.nota, catalog.data " +
                              "FROM studenti " +
                              "JOIN catalog ON studenti.id = catalog.student_id " +
                              "WHERE catalog.disciplina_id = " +
                              "(SELECT id FROM disciplina WHERE nume = '" + disciplina + "') " +
                              "AND studenti.grupa_id = (SELECT id FROM grupa WHERE nume = '" + grupa + "')";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Catalog catalog = new Catalog();
                catalog.Nume = reader["nume"].ToString();
                catalog.Prenume = reader["prenume"].ToString();
                catalog.Nota = reader["nota"].ToString();
                catalog.Data = reader["data"].ToString();
                list.Add(catalog);
            }
            connection.Close();
            return list;

        }   


    }
}
