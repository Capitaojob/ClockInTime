using System.Text.RegularExpressions;
using Npgsql;

namespace newTest
{
    public partial class RegisterEmployee : UserControl
    {
        Dictionary<string, int> RoleDictionary = new Dictionary<string, int>();

        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            PnlLeft.BackColor = DefaultColors.DarkBlue;
            LblTz.ForeColor = DefaultColors.SandyBrown;
            LblGreet.ForeColor = DefaultColors.Gray;
            btnRegister.BackColor = DefaultColors.SandyBrown;
            btnRegister.FlatAppearance.BorderSize = 0;

            LblInvalid.Visible = false;

            QueryRoles();
            AddComboValues();
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            ValidateField("Name");
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            ValidateField("Email");
        }

        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            ValidateField("CPF");
        }

        private void comboBoxRoles_Leave(object sender, EventArgs e)
        {
            ValidateField("Role");
        }

        private void TxtBirthday_Leave(object sender, EventArgs e)
        {
            ValidateField("Birthday");
        }

        private bool ValidateField(string Field)
        {
            LblInvalid.ForeColor = DefaultColors.WarnRed;
            LblInvalid.Visible = false;
            LblInvalid.Location = new Point(94, 244);

            if (Field == "Name")
            {
                if (TxtName.Text.Length < 5)
                {
                    TxtName.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Campo Nome Inválido!";
                    LblInvalid.Visible = true;

                    return false;
                }
                else
                {
                    TxtName.BackColor = SystemColors.Window;

                    return true;
                }
            }
            else if (Field == "Email")
            {
                if (!TxtEmail.Text.Contains('@') || !(TxtEmail.Text.Length >= 3))
                {
                    TxtEmail.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Campo Email Inválido!";
                    LblInvalid.Visible = true;

                    return false;
                }
                else
                {
                    TxtEmail.BackColor = SystemColors.Window;

                    return true;
                }
            }
            else if (Field == "CPF")
            {
                Regex rx = new Regex(@"(\d{3}[.-]?\d{3}[.-]?\d{3}[.-]?\d{2})");
                bool match = rx.IsMatch(TxtCPF.Text);

                if (TxtCPF.Text.Length < 11 || TxtCPF.Text.Length > 14 || !match)
                {
                    TxtCPF.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Campo CPF Inválido!";
                    LblInvalid.Visible = true;

                    return false;
                }
                else
                {
                    TxtCPF.BackColor = SystemColors.Window;

                    return true;
                }
            }
            else if (Field == "Birthday")
            {
                Regex rx = new Regex(@"((0[1-9]|[1-2][0-9]|3[0-1])[/](0[1-9]|1[0-2])[/]\d{4})");
                bool match = rx.IsMatch(TxtBirthday.Text);

                if (!match)
                {
                    TxtBirthday.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Campo Nascimento Inválido!";
                    LblInvalid.Location = new Point(44, 244);
                    LblInvalid.Visible = true;

                    return false;
                }
                else
                {
                    TxtBirthday.BackColor = SystemColors.Window;

                    return true;
                }
            }
            else if (Field == "Role")
            {
                if (comboBoxRoles.SelectedIndex == -1)
                {
                    comboBoxRoles.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Campo Cargo Inválido!";
                    LblInvalid.Visible = true;

                    return false;
                }
                else
                {
                    comboBoxRoles.BackColor = SystemColors.Window;

                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void QueryRoles()
        {
            string connString = "Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=tzrh";
            string sql = "SELECT id_cargo, nome_cargo FROM cargo;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoleDictionary.Add(reader.GetString(1), reader.GetInt32(0));
                        }
                    }
                }
            }
        }

        private void AddComboValues()
        {
            foreach (KeyValuePair<string, int> item in RoleDictionary)
            {
                comboBoxRoles.Items.Add(item.Key);
            }
        }

        private string FormatCPF(string CPF)
        {
            char[] chars = CPF.ToCharArray();
            string FormatedCPF = "";

            foreach (char c in chars)
            {
                if (c != '.' && c != '-')
                {
                    FormatedCPF += c;
                }
            }

            return FormatedCPF;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateField("Name") && ValidateField("Email") && ValidateField("CPF") && ValidateField("Birthday") && comboBoxRoles.SelectedItem != null)
            {
                if (RoleDictionary.ContainsKey(comboBoxRoles.SelectedItem.ToString()))
                {
                    try
                    {
                        string connString = "Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=tzrh";
                        string SQL_INSERT = "INSERT INTO funcionarios (nome, email, cpf, nascimento, cargo, status, senha) VALUES (@name, @email, @cpf, @birthday, @role, '1', @password)";

                        using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                        {
                            conn.Open();

                            using (NpgsqlCommand cmd = new NpgsqlCommand(SQL_INSERT, conn))
                            {
                                cmd.Parameters.AddWithValue("@name", TxtName.Text);
                                cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                                cmd.Parameters.AddWithValue("@cpf", FormatCPF(TxtCPF.Text));
                                cmd.Parameters.AddWithValue("@birthday", DateTime.Parse(TxtBirthday.Text));
                                cmd.Parameters.AddWithValue("@role", RoleDictionary[comboBoxRoles.SelectedItem.ToString()]);
                                cmd.Parameters.AddWithValue("@password", HashUtils.HashString("tz1234"));
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    LblInvalid.ForeColor = DefaultColors.SandyBrown;
                    LblInvalid.Visible = true;
                    LblInvalid.Text = "Usuário Cadastrado!";

                    TxtName.Text = "";
                    TxtEmail.Text = "";
                    TxtCPF.Text = "";
                    TxtBirthday.Text = "";
                    comboBoxRoles.SelectedIndex = -1;
                }
            }
        }
    }
}
