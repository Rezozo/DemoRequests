using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zayvka.model;

namespace Zayvka.provider
{
    public class StatisticProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=zayavka;User Id=postgres;Password=0987");

        public long GetTotalCount()
        {
            connection.Open();
            var command = new NpgsqlCommand("SELECT count(*) FROM application WHERE status_id = 3", connection);
            long count = (long)command.ExecuteScalar();
            connection.Close();
            return count;
        }

        public long GetMiddleTime()
        {
            connection.Open();
            var command = new NpgsqlCommand("SELECT AVG(finish_date - created_date)::bigint FROM application ", connection);
            long middle = (long)command.ExecuteScalar();
            connection.Close();
            return middle;
        }

        public List<Statistics> GetAllStatistics()
        {
            List<Statistics> statistics = new List<Statistics>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT f.title, COUNT(*) FROM application a " +
                "INNER JOIN fault f ON f.id = a.fault_id GROUP BY f.title", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                statistics.Add(new Statistics(reader.GetString(0), reader.GetInt64(1)));
            }
            reader.Close();
            connection.Close();
            return statistics;
        }
    }
}
