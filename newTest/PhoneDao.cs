using newTest;
using Npgsql;

namespace Phone.dao
{
    internal interface IPhoneDao
    {
        void Insert(int Id, string Phone);
        //List<Employee> ReadAll();
        public Phones? SelectSpecific(int Id);
        void Update(Phones phone);
        //void Delete(Employee employee);
        //int SelectNextId();
    }
    public class PhoneDaoPostgres : IPhoneDao
    {
        private readonly string connString;
        private const string SQL_INSERT = "INSERT INTO telefone (id_func_tel, tel) VALUES (@id, @phone)";
        private const string SQL_SELECT = "SELECT * FROM telefone WHERE id_func_tel = @id";
        private const string SQL_UPDATE = "UPDATE telefone SET tel = @phone WHERE id_func_tel = @id";

        public PhoneDaoPostgres()
        {
            connString = DbConnection.connString;
        }

        public void Insert(int Id, string Phone)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Phones? SelectSpecific(int Id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_SELECT, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Phones phone = new Phones();
                            phone.Id = reader.GetInt32(0);
                            phone.Number = reader.GetString(1);
                            return phone;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public void Update(Phones phone)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("@id", phone.Id);
                    cmd.Parameters.AddWithValue("@phone", phone.Number);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
