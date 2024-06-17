using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zayvka.model;

namespace Zayvka.provider
{
    public class ApplicationProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=zayavka;User Id=postgres;Password=0987");

        public void CreateApplication(int clientId, string fault, string equipment, string problem, DateTime finishDate)
        {
            connection.Open();
            var command = new NpgsqlCommand($"INSERT INTO application VALUES (default, " +
                $"{clientId}, null, 1, null," +
                $" (SELECT id FROM fault WHERE title = '{fault}')," +
                $" '{DateTime.Now}', '{equipment}', '{problem}', null, '{finishDate}', false)", connection);
            command.ExecuteNonQuery();  
            connection.Close();
        }

        public void UpdateIsNewStatus(int id)
        {
            connection.Open();
            var command = new NpgsqlCommand($"Update application SET is_new_status = false WHERE id = {id}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateComment(int id, string comment)
        {
            connection.Open();
            var command = new NpgsqlCommand($"Update application SET comment = '{comment}' WHERE id = {id}", connection);
            command.ExecuteNonQueryAsync();
            connection.Close();
        }

        public List<string> GetAllFault()
        {
            connection.Open();
            List<string> fault = new List<string>();
            var command = new NpgsqlCommand("SELECT title FROM fault", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                fault.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return fault;
        }

        public List<Applications> GetApplications(User user)
        {
            List<Applications> applications = new List<Applications>();
            connection.Open();
            string sqlStr = "SELECT a.id, u.full_name, u.phone_number, us.full_name, us.phone_number, s.title, p.title, " +
                "f.title, a.created_date, a.equipment, a.problem, a.comment, a.finish_date, a.is_new_status FROM application a " +
                "INNER JOIN users u ON a.client_id = u.id " +
                "LEFT JOIN users us ON a.staff_id = u.id " +
                "INNER JOIN status s ON a.status_id = s.id " +
                "LEFT JOIN priority p ON a.priority_id = p.id " +
                "INNER JOIN fault f ON a.fault_id = f.id ";
            var command = new NpgsqlCommand(sqlStr, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Applications application = new Applications();
                application.Id = reader.GetInt32(0);
                application.Client = reader.GetString(1);
                application.ClientNumber = reader.GetString(2);
                if (!reader.IsDBNull(3))
                {
                    application.Staff = reader.GetString(3);
                    application.StaffNumber = reader.GetString(4);
                }
                application.Status = reader.GetString(5);
                if (!reader.IsDBNull(6))
                {
                    application.Priority = reader.GetString(6);
                }
                application.Fault = reader.GetString(7);
                application.CreatedDate = reader.GetDateTime(8);
                application.Equipment = reader.GetString(9);
                application.Problem = reader.GetString(10);
                if (!reader.IsDBNull(11))
                {
                    application.Comment = reader.GetString(11);
                }
                application.FinishDate = reader.GetDateTime(12);
                application.isNewStatus = reader.GetBoolean(13);
                applications.Add(application); 
            }
            reader.Close();
            connection.Close();
            return applications;
        }
    }
}
