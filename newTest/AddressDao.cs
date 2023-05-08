using newTest;
using Npgsql;

namespace Location.dao
{
    internal interface IAddressDao
    {
        void Insert(Address employee);
        //List<Address> ReadAll();
        void Update(Address employee);
        void Delete(Address employee);
    }

    public class AddressDaoPostgres : IAddressDao
    {
        private readonly string connString;
        private const string SQL_INSERT = "INSERT INTO endereco (id_func_end, cep, rua, numero, bairro, complemento, cidade, estado) VALUES (@id, @cep, @street, @number, @neighbourhood, @suplement, @city, @state)";
        //private const string SQL_READALL = "SELECT * FROM funcionarios";
        private const string SQL_SELECT = "SELECT * FROM endereco WHERE id_func_end = @id";
        private const string SQL_UPDATE = "UPDATE endereco SET cep = @cep, rua = @street, numero = @number, bairro = @neighbourhood, complemento = @suplement, cidade = @city, estado = @state WHERE id_func_end = @id";
        private const string SQL_DELETE = "DELETE FROM funcionarios WHERE id = @id";

        public AddressDaoPostgres()
        {
            connString = DbConnection.connString;
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

        //public List<Address> ReadAll()
        //{
        //    List<Address> addresses = new List<Address>();
        //    using (NpgsqlConnection conn = new NpgsqlConnection(connString))
        //    {
        //        conn.Open();
        //        using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_READALL, conn))
        //        {
        //            using (NpgsqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Address address = new Address();
        //                    //employee.Id = (int)reader["id"];
        //                    //employee.Name = reader["nome"].ToString();
        //                    //employee.Email = reader["email"].ToString();
        //                    //employee.CPF = reader["cpf"].ToString();
        //                    //employee.Birthday = (DateTime)reader["nascimento"];
        //                    //employee.Role = (int)reader["cargo"];
        //                    //employee.Status = (bool)reader["status"];
        //                    //employee.Password = reader["senha"].ToString();

        //                    addresses.Add(address);
        //                }
        //            }
        //        }
        //    }
        //    return addresses;
        //}

        public Address? SelectSpecific(int Id)
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
                            Address address = new Address();

                            address.Id = reader.GetInt32(0);
                            address.CEP = reader.GetString(1);
                            address.Street = reader.GetString(2);
                            address.Neighbourhood = reader.GetString(3);
                            address.Suplement = reader.GetString(4);
                            address.City = reader.GetString(5);
                            address.State = reader.GetString(6);
                            address.Number = reader.GetInt32(7);

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
