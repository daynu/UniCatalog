using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable GetPivotedGrades(string disciplina, string grupa)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                string dateQuery = @"
                    SELECT DISTINCT data
                    FROM catalog
                    JOIN studenti ON catalog.student_id = studenti.id
                    JOIN disciplina ON catalog.disciplina_id = disciplina.id
                    JOIN grupa ON studenti.grupa_id = grupa.id
                    WHERE disciplina.nume = @disciplina AND grupa.nume = @grupa
                    ORDER BY data";

                MySqlCommand dateCmd = new MySqlCommand(dateQuery, connection);
                dateCmd.Parameters.AddWithValue("@disciplina", disciplina);
                dateCmd.Parameters.AddWithValue("@grupa", grupa);

                MySqlDataReader dateReader = dateCmd.ExecuteReader();
                List<DateTime> dates = new List<DateTime>();

                while (dateReader.Read())
                {
                    dates.Add(dateReader.GetDateTime("data"));
                }
                dateReader.Close();

                if (dates.Count == 0)
                {
                    return dataTable; 
                }

                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append(@"
                    SELECT 
                        studenti.id AS StudentID, 
                        studenti.nume AS Nume, 
                        studenti.prenume AS Prenume");

                foreach (var date in dates)
                {
                    queryBuilder.AppendFormat(", MAX(CASE WHEN data = '{0}' THEN nota ELSE NULL END) AS '{0}'", date.ToString("yyyy-MM-dd"));
                }

                queryBuilder.Append(@"
                    FROM 
                        catalog
                    JOIN 
                        studenti ON catalog.student_id = studenti.id
                    JOIN 
                        disciplina ON catalog.disciplina_id = disciplina.id
                    JOIN 
                        grupa ON studenti.grupa_id = grupa.id
                    WHERE 
                        disciplina.nume = @disciplina AND grupa.nume = @grupa
                    GROUP BY 
                        studenti.id, studenti.nume, studenti.prenume
                    ORDER BY 
                        studenti.id");

                string query = queryBuilder.ToString();

               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@disciplina", disciplina);
                cmd.Parameters.AddWithValue("@grupa", grupa);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }


    }
}
