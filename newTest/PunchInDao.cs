using Npgsql;
using System.Data;
using Workers;

namespace PunchIn.dao
{
    internal interface IPunchInDao
    {
        void Insert(ClockIn clockIn);
        List<ClockIn> ReadAll();
        void Update(ClockIn clockIn);
        void Delete(ClockIn clockIn);
    }

    public class PunchInDaoPostgres //: IPunchInDao
    {
        private readonly string connString;
        private const string SQL_INSERT = "INSERT INTO pontos (id_funcionario, data, entrada, saida_al, entrada_al, saida) values (@idEmployee, @date, @entry, @lunchExit, @lunchEntry, @exit)";
        private const string SQL_READALL = "SELECT * FROM pontos WHERE id_funcionario = @idEmployee ORDER BY data DESC LIMIT 3";
        private const string SQL_SELECT = "SELECT * FROM pontos WHERE data = @date AND id_funcionario = @idEmployee"; 
        private const string SQL_UPDATE = "UPDATE pontos SET id_funcionario = @idEmployee, data = @date, entrada = @entry, saida_al = @lunchExit, entrada_al= @lunchEntry, saida = @exit WHERE id_ponto = @id";
        private const string SQL_DELETE = "DELETE FROM pontos WHERE id_ponto = @id";

        public PunchInDaoPostgres()
        {
            connString = "Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=tzrh";
        }

        public void Insert(ClockIn clockIn)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@idEmployee", clockIn.IdEmployee);
                    cmd.Parameters.AddWithValue("@date", clockIn.Date);

                    if (clockIn.MainClockIn == null)
                    {
                        cmd.Parameters.AddWithValue("@entry", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@entry", clockIn.MainClockIn);
                    }

                    if (clockIn.LunchClockOut == null)
                    {
                        cmd.Parameters.AddWithValue("@lunchExit", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@lunchExit", clockIn.LunchClockOut);
                    }

                    if (clockIn.LunchClockIn == null)
                    {
                        cmd.Parameters.AddWithValue("@lunchEntry", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@lunchEntry", clockIn.LunchClockIn);
                    }

                    if (clockIn.MainClockOut == null)
                    {
                        cmd.Parameters.AddWithValue("@exit", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@exit", clockIn.MainClockOut);
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ClockIn> ReadAll(int Id)
        {
            List<ClockIn> clockIn = new List<ClockIn>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_READALL, conn))
                {
                    cmd.Parameters.AddWithValue("@idEmployee", Id); 

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClockIn newClockIn = new ClockIn();

                            newClockIn.Id = reader.GetInt32(0);
                            newClockIn.IdEmployee = reader.GetInt32(1);
                            newClockIn.Date = reader.GetDateTime(2);
                            newClockIn.MainClockIn = reader.IsDBNull(3) ? null : reader.GetTimeSpan(3);
                            newClockIn.LunchClockOut = reader.IsDBNull(4) ? null : reader.GetTimeSpan(4);
                            newClockIn.LunchClockIn = reader.IsDBNull(5) ? null : reader.GetTimeSpan(5);
                            newClockIn.MainClockOut = reader.IsDBNull(6) ? null : reader.GetTimeSpan(6);

                            clockIn.Add(newClockIn);
                        }
                    }
                }
            }
            return clockIn;
        }

        public ClockIn? SelectSpecific(int idEmployee)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_SELECT, conn))
                {
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date); //.ToString("yyyy-MM-dd")
                    cmd.Parameters.AddWithValue("@idEmployee", idEmployee);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ClockIn clockIn = new ClockIn();

                            clockIn.Id = reader.GetInt32(0);
                            clockIn.IdEmployee = reader.GetInt32(1);
                            clockIn.Date = reader.GetDateTime(2);
                            clockIn.MainClockIn = reader.IsDBNull(3) ? null : reader.GetTimeSpan(3);
                            clockIn.LunchClockOut = reader.IsDBNull(4) ? null : reader.GetTimeSpan(4);
                            clockIn.LunchClockIn = reader.IsDBNull(5) ? null : reader.GetTimeSpan(5);
                            clockIn.MainClockOut = reader.IsDBNull(6) ? null : reader.GetTimeSpan(6);

                            return clockIn;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void Update(ClockIn clockIn)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("@id", clockIn.Id);
                    cmd.Parameters.AddWithValue("@idEmployee", clockIn.IdEmployee);
                    cmd.Parameters.AddWithValue("@date", clockIn.Date);

                    if (clockIn.MainClockIn == null)
                    {
                        cmd.Parameters.AddWithValue("@entry", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@entry", clockIn.MainClockIn);
                    }

                    if (clockIn.LunchClockOut == null)
                    {
                        cmd.Parameters.AddWithValue("@lunchExit", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@lunchExit", clockIn.LunchClockOut);
                    }

                    if (clockIn.LunchClockIn == null)
                    {
                        cmd.Parameters.AddWithValue("@lunchEntry", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@lunchEntry", clockIn.LunchClockIn);
                    }

                    if (clockIn.MainClockOut == null)
                    {
                        cmd.Parameters.AddWithValue("@exit", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@exit", clockIn.MainClockOut);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(ClockIn clockIn)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_DELETE, conn))
                {
                    cmd.Parameters.AddWithValue("@id", clockIn.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
