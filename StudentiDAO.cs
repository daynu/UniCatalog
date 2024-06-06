using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UniCatalog
{
    internal class StudentiDAO
    {
        static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);

        public List<Student> GetStudenti(string grupa)
        {
            List<Student> studenti = new List<Student>();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM studenti WHERE grupa_id = (SELECT id FROM grupa WHERE nume = '" + grupa + "')";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.Prenume = reader["prenume"].ToString();
                student.Nume = reader["nume"].ToString();
                student.grupa = grupa;
                studenti.Add(student);
            }
            connection.Close();
            return studenti;
        }
        
    }
}
