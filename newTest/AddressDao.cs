using Npgsql;

namespace Location.dao
{
    internal interface IAddressDao
    {
        void Insert(Address employee);
        List<Address> ReadAll();
        void Update(Address employee);
        void Delete(Address employee);
    }

    public class AddressDaoPostgres : IAddressDao
    {
        private readonly string connString;
        private const string SQL_INSERT = "INSERT INTO endereco (id_func_end, cep, rua, numero, bairro, complemento, cidade, estado) VALUES (@id, @cep, @street, @number, @neighbourhood, @suplement, @city, @state)";
        private const string SQL_READALL = "SELECT * FROM funcionarios";
        private const string SQL_SELECT = "SELECT * FROM funcionarios WHERE email = @email";
        private const string SQL_UPDATE = "UPDATE funcionarios SET nome = @name, email = @email, cpf = @cpf, nascimento = @birthday, cargo = @role, status = @status, senha = @password WHERE id = @id";
        private const string SQL_DELETE = "DELETE FROM funcionarios WHERE id = @id";

        public AddressDaoPostgres()
        {
            connString = "Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=tzrh";
        }

        public void Insert(Address address)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@id", address.Id);
                    cmd.Parameters.AddWithValue("@cep", address.CEP);
                    cmd.Parameters.AddWithValue("@street", address.Street);
                    cmd.Parameters.AddWithValue("@number", address.Number);
                    cmd.Parameters.AddWithValue("@neighbourhood", address.Neighbourhood);
                    cmd.Parameters.AddWithValue("@suplement", address.Suplement);
                    cmd.Parameters.AddWithValue("@city", address.City);
                    cmd.Parameters.AddWithValue("@state", address.State);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Address> ReadAll()
        {
            List<Address> addresses = new List<Address>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_READALL, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Address address = new Address();
                            //employee.Id = (int)reader["id"];
                            //employee.Name = reader["nome"].ToString();
                            //employee.Email = reader["email"].ToString();
                            //employee.CPF = reader["cpf"].ToString();
                            //employee.Birthday = (DateTime)reader["nascimento"];
                            //employee.Role = (int)reader["cargo"];
                            //employee.Status = (bool)reader["status"];
                            //employee.Password = reader["senha"].ToString();

                            addresses.Add(address);
                        }
                    }
                }
            }
            return addresses;
        }

        public Address? SelectSpecific(string Email)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_SELECT, conn))
                {
                    cmd.Parameters.AddWithValue("@email", Email);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Address address = new Address();

                            //address.Id = reader.GetInt32(0);
                            //address.Name = reader.GetString(1).Replace("Æ", "ã");
                            //address.Email = reader.GetString(2);
                            //address.CPF = reader.GetString(3);
                            //address.Birthday = reader.GetDateTime(4);
                            //address.Role = reader.GetInt32(5);
                            //address.Status = reader.GetBoolean(6);
                            //address.Password = reader.GetString(7);

                            return address;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void Update(Address address)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_UPDATE, conn))
                {
                    //cmd.Parameters.AddWithValue("@id", employee.Id);
                    //cmd.Parameters.AddWithValue("@name", employee.Name.Replace("Æ", "ã").Replace("Ò", "ã"));
                    //cmd.Parameters.AddWithValue("@email", employee.Email);
                    //cmd.Parameters.AddWithValue("@cpf", employee.CPF);
                    //cmd.Parameters.AddWithValue("@birthday", employee.Birthday);
                    //cmd.Parameters.AddWithValue("@role", employee.Role);
                    //cmd.Parameters.AddWithValue("@status", employee.Status);
                    //cmd.Parameters.AddWithValue("@password", HashUtils.HashString(employee.Password));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Address address)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_DELETE, conn))
                {
                    //cmd.Parameters.AddWithValue("@id", address.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
