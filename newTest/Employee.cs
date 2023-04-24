using Npgsql;

namespace Workers
{
    // Classe dos funcionários da empresa
    public class Employee
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _name = "";
        public string Name
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _email = "";
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        private string _cpf = "";
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }

        private string _pw = "";
        public string Password
        {
            get
            {
                return _pw;
            }
            set
            {
                _pw = value;
            }
        }

        private DateTime _bday;
        public DateTime Birthday
        {
            get
            {
                return _bday;
            }
            set
            {
                _bday = value;
            }
        }

        private int _role = 0;
        public int Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }

        private bool _status = true;
        public bool Status
        {
            get {
                return _status;
            }
            set {
                _status = value;
            }
        }

        public static bool Login(string UserEmail, string Password)
        {
            string connString = "Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=tzrh";
            string sql = "SELECT * FROM funcionarios WHERE email = @email AND status = '1'";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("email", UserEmail);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && Password == reader.GetString(7))
                        { 
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }
}
