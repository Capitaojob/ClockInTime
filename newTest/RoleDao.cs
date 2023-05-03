﻿using Location;
using newTest;
using Npgsql;

namespace Roles.Dao
{
    internal interface IRoleDao
    {
        void Insert(Role role);
        List<Role> ReadAll();
        void Update(Role role);
        void Delete(Role role);
    }

    public class RoleDaoPostgres : IRoleDao
    {
        private readonly string connString;
        private const string SQL_INSERT = "INSERT INTO endereco (id_func_end, cep, rua, numero, bairro, complemento, cidade, estado) VALUES (@id, @cep, @street, @number, @neighbourhood, @suplement, @city, @state)";
        private const string SQL_READALL = "SELECT * FROM funcionarios";
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
                                        WHERE cargo.id_cargo = @id AND dados_impostos.id_imposto = 1";

        private const string SQL_UPDATE = "UPDATE funcionarios SET nome = @name, email = @email, cpf = @cpf, nascimento = @birthday, cargo = @role, status = @status, senha = @password WHERE id = @id";
        private const string SQL_DELETE = "DELETE FROM funcionarios WHERE id = @id";

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
                    //cmd.Parameters.AddWithValue("@id", role.Id);
                    //cmd.Parameters.AddWithValue("@cep", role.CEP);
                    //cmd.Parameters.AddWithValue("@street", role.Street);
                    //cmd.Parameters.AddWithValue("@number", role.Number);
                    //cmd.Parameters.AddWithValue("@neighbourhood", role.Neighbourhood);
                    //cmd.Parameters.AddWithValue("@suplement", role.Suplement);
                    //cmd.Parameters.AddWithValue("@city", role.City);
                    //cmd.Parameters.AddWithValue("@state", role.State);
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
                            //employee.Id = (int)reader["id"];
                            //employee.Name = reader["nome"].ToString();
                            //employee.Email = reader["email"].ToString();
                            //employee.CPF = reader["cpf"].ToString();
                            //employee.Birthday = (DateTime)reader["nascimento"];
                            //employee.Role = (int)reader["cargo"];
                            //employee.Status = (bool)reader["status"];
                            //employee.Password = reader["senha"].ToString();

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
                            role.Dp = reader.GetBoolean(3);
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

        public void Update(Role address)
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

        public void Delete(Role address)
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
