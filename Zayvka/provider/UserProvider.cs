using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zayvka.model;

namespace Zayvka.provider
{
    public class UserProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=zayavka;User Id=postgres;Password=0987");

        public void CreateUser(string login, string password, string phoneNumber, string fullName)
        {
            connection.Open();
            var existsCommand = new NpgsqlCommand($"SELECT EXISTS(SELECT * FROM users WHERE login = '{login}')", connection);
            var exists = (bool) existsCommand.ExecuteScalar();
            if (exists)
            {
                connection.Close();
                throw new Exception();
            }

            var command = new NpgsqlCommand($"INSERT INTO users VALUES (default, 1, '{fullName}', '{login}', '{password}', '{phoneNumber}')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public User Authorization(string login, string password)
        {
            connection.Open();
            var existsCommand = new NpgsqlCommand($"SELECT EXISTS(SELECT * FROM users WHERE login = '{login}' AND password = '{password}')", connection);
            var exists = (bool)existsCommand.ExecuteScalar();
            if (!exists)
            {
                connection.Close();
                throw new Exception();
            }

            User user = new User();
            var command = new NpgsqlCommand($"SELECT u.id, r.title, u.full_name, u.login FROM users u " +
                $"INNER JOIN role r ON r.id = u.role_id WHERE login = '{login}'", connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                user.Id = reader.GetInt32(0);
                user.Role = reader.GetString(1);
                user.FullName = reader.GetString(2);
                user.Login = reader.GetString(3); 
            }
            reader.Close();
            connection.Close();
            return user;
        }
    }
}
