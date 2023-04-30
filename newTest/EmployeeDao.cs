using newTest;
using Npgsql;

namespace Workers.dao
{
    internal interface IEmployeeDao
    {
        void Insert (Employee employee);
        List<Employee> ReadAll();
        void Update (Employee employee);
        void Delete (Employee employee);
        int SelectNextId();
    }

    public class EmployeeDaoPostgres : IEmployeeDao
    {
        private readonly string connString;
        private const string SQL_INSERT = "INSERT INTO funcionarios (nome, email, cpf, nascimento, cargo, status) VALUES (@name, @email, @cpf, @birthday, @role, @status)";
        private const string SQL_READALL = "SELECT * FROM funcionarios";
        private const string SQL_SELECT = "SELECT * FROM funcionarios WHERE email = @email";
        private const string SQL_UPDATE = "UPDATE funcionarios SET nome = @name, email = @email, cpf = @cpf, nascimento = @birthday, cargo = @role, status = @status, senha = @password WHERE id = @id";
        private const string SQL_HRROLE = "SELECT * FROM cargo WHERE id_cargo = @id AND dp = true";
        private const string SQL_SELECTROLE = "SELECT nome_cargo FROM cargo JOIN funcionarios ON funcionarios.cargo = cargo.id_cargo WHERE id = @id";
        private const string SQL_DELETE = "DELETE FROM funcionarios WHERE id = @id";
        private const string SQL_NEXTVAL = "SELECT id FROM funcionarios ORDER BY id DESC LIMIT 1;";


        public EmployeeDaoPostgres()
        {
            connString = "Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=tzrh";
        }

        public void Insert(Employee employee)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@name", employee.Name.Replace("Æ", "ã"));
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@cpf", employee.CPF);
                    cmd.Parameters.AddWithValue("@birthday", employee.Birthday);
                    cmd.Parameters.AddWithValue("@role", employee.Role);
                    cmd.Parameters.AddWithValue("@status", employee.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Employee> ReadAll()
        {
            List<Employee> employees = new List<Employee>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_READALL, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = (int)reader["id"];
                            employee.Name = reader["nome"].ToString();
                            employee.Email = reader["email"].ToString();
                            employee.CPF = reader["cpf"].ToString();
                            employee.Birthday = (DateTime)reader["nascimento"];
                            employee.Role = (int)reader["cargo"];
                            employee.Status = (bool)reader["status"];
                            employee.Password = reader["senha"].ToString();

                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }

        public Employee? SelectSpecific(string Email)
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
                            Employee employee = new Employee();

                            employee.Id = reader.GetInt32(0);
                            employee.Name = reader.GetString(1).Replace("Æ", "ã");
                            employee.Email = reader.GetString(2);
                            employee.CPF = reader.GetString(3);
                            employee.Birthday = reader.GetDateTime(4);
                            employee.Role = reader.GetInt32(5);
                            employee.Status = reader.GetBoolean(6);
                            employee.Password = reader.GetString(7);

                            return employee;
                        } 
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public int SelectNextId()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_NEXTVAL, conn))
                {

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.GetInt32(0) + 1;
                        else return 0;
                    }
                }
            }
        }

        public bool SelectHrRole(int Id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_HRROLE, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader.HasRows) return true;
                        else return false;
                    }
                }
            }
        }

        public string SelectRole(int Id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_SELECTROLE, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader.HasRows) return reader.GetString(0);
                        else return "";
                    }
                }
            }
        }

        public void Update(Employee employee)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@name", employee.Name.Replace("Æ", "ã").Replace("Ò", "ã"));
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@cpf", employee.CPF);
                    cmd.Parameters.AddWithValue("@birthday", employee.Birthday);
                    cmd.Parameters.AddWithValue("@role", employee.Role);
                    cmd.Parameters.AddWithValue("@status", employee.Status);
                    cmd.Parameters.AddWithValue("@password", HashUtils.HashString(employee.Password));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Employee employee)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_DELETE, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
