using Location;
using newTest;
using Npgsql;

namespace Roles.Dao
{
    internal interface IRoleDao
    {
        void Insert(Role role);
        List<Role> ReadAll();
        void Update(Role role);
        void Delete(int Id);
    }

    public class RoleDaoPostgres : IRoleDao
    {
        private readonly string connString;
        private const string SQL_INSERT = "INSERT INTO cargo (nome_cargo, salario, dp, carga_horaria) VALUES (@name, @wage, @dp, @hours)";
        private const string SQL_READALL = "SELECT * FROM cargo";
        private const string SQL_SELECT = "SELECT * FROM cargo WHERE id_cargo = @RoleId";
        private const string SQL_INSS = @"SELECT DISTINCT
                                        cargo.nome_cargo,
                                        CASE 
                                        WHEN cargo.salario <= (SELECT salario_max FROM dados_impostos WHERE id = 1 AND id_imposto = 1) THEN 
                                        (SELECT porcentagem FROM dados_impostos WHERE id = 1 AND id_imposto = 1) 
                                        WHEN cargo.salario <= (SELECT salario_max FROM dados_impostos WHERE id = 2 AND id_imposto = 1) AND cargo.salario > (SELECT salario_max FROM dados_impostos WHERE id = 1 AND id_imposto = 1) THEN 
                                        (SELECT porcentagem FROM dados_impostos WHERE id = 2 AND id_imposto = 1) 
                                        WHEN cargo.salario <= (SELECT salario_max FROM dados_impostos WHERE id = 3 AND id_imposto = 1) AND cargo.salario > (SELECT salario_max FROM dados_impostos WHERE id = 2 AND id_imposto = 1) THEN 
                                        (SELECT porcentagem FROM dados_impostos WHERE id = 3 AND id_imposto = 1)  
                                        ELSE 
                                        (SELECT porcentagem FROM dados_impostos WHERE id = 4 AND id_imposto = 1) 
                                        END AS inss
                                        FROM cargo, dados_impostos
                                        WHERE cargo.id_cargo = @id AND dados_impostos.id_imposto = 1"; // Will Change

        private const string SQL_UPDATE = "UPDATE cargo SET nome_cargo = @name, salario = @wage, dp = @dp, carga_horaria = @hours WHERE id_cargo = @id;";
        private const string SQL_DELETE = "DELETE FROM cargo WHERE id_cargo = @id";

        public RoleDaoPostgres()
        {
            connString = DbConnection.connString;
        }

        public void Insert(Role role)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@name", role.Name);
                    cmd.Parameters.AddWithValue("@wage", role.Wage);
                    cmd.Parameters.AddWithValue("@dp", role.Dp);
                    cmd.Parameters.AddWithValue("@hours", role.Hours);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Role> ReadAll()
        {
            List<Role> roles = new List<Role>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_READALL, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Role role = new Role();
                            role.Id = reader.GetInt32(0);
                            role.Name = reader.GetString(1);
                            role.Wage = reader.GetDecimal(2);
                            role.Dp = reader.IsDBNull(3) ? false : reader.GetBoolean(3);
                            role.Hours = reader.GetInt32(4);

                            roles.Add(role);
                        }
                    }
                }
            }
            return roles;
        }

        public Role? SelectSpecific(int Id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_SELECT, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleId", Id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Role role = new Role();
                            role.Id = reader.GetInt32(0);
                            role.Name = reader.GetString(1);
                            role.Wage = reader.GetDecimal(2);
                            role.Dp = reader.IsDBNull(3) ? false : reader.GetBoolean(3);
                            role.Hours = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);

                            return role;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public decimal SelectINSS(int Id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_INSS, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetDecimal(1);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        public void Update(Role role)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("id", role.Id);
                    cmd.Parameters.AddWithValue("@name", role.Name);
                    cmd.Parameters.AddWithValue("@wage", role.Wage);
                    cmd.Parameters.AddWithValue("@dp", role.Dp);
                    cmd.Parameters.AddWithValue("@hours", role.Hours);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int Id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_DELETE, conn))
                {
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
