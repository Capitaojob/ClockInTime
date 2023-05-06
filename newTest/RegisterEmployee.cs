using System.Text.RegularExpressions;
using Location;
using Location.dao;
using Newtonsoft.Json.Linq;
using Npgsql;
using Roles.Dao;
using Roles;
using Workers;
using Workers.dao;

namespace newTest
{
    public partial class RegisterEmployee : UserControl
    {
        Dictionary<string, int> RoleDictionary = new Dictionary<string, int>();
        Dictionary<string, int> EmployeeDictionary = new Dictionary<string, int>();
        Employee User = new Employee();

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
            BtnRegister.BackColor = DefaultColors.SandyBrown;
            LblInvalid.ForeColor = DefaultColors.WarnRed;
            LblUpdateUser.ForeColor = DefaultColors.White;
            BtnRegister.FlatAppearance.BorderSize = 0;

            LblInvalid.Visible = false;

            if (DesignMode) return;
            QueryRoles();
            QueryEmployees();
        }

        public void UpdateUser(Employee User)
        {
            this.User = User;
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

        private void TxtNumber_Leave(object sender, EventArgs e)
        {
            ValidateField("Phone");
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            ValidateField("CEP");
        }

        private bool ValidateField(string Field)
        {
            //LblInvalid.ForeColor = DefaultColors.WarnRed;
            LblInvalid.Visible = false;

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
            else if (Field == "Phone")
            {
                Regex rx = new Regex(@"^(\d{11})$");

                if (!rx.IsMatch(TxtPhone.Text))
                {
                    TxtPhone.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Campo Telefone (com DDD) Inválido!";
                    LblInvalid.Visible = true;

                    return false;
                }
                else
                {
                    TxtPhone.BackColor = SystemColors.Window;

                    return true;
                }
            }
            else if (Field == "CEP")
            {
                CheckCEP();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Employee Combo Box

        private void QueryEmployees()
        {
            EmployeeDaoPostgres psql = new EmployeeDaoPostgres();
            List<Employee> employees = psql.ReadAll();

            EmployeeDictionary.Clear();

            foreach (Employee e in employees)
            {
                EmployeeDictionary.Add(e.Email, e.Id);
            }

            AddEmployeeComboValues();
        }

        private void AddEmployeeComboValues()
        {
            CbEmployees.Items.Clear();

            foreach (KeyValuePair<string, int> item in EmployeeDictionary)
            {
                CbEmployees.Items.Add(item.Key);
            }
        }

        //private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (comboBoxRoles.SelectedIndex == -1)
        //        {
        //            return;
        //        }

        //        RoleDaoPostgres psql = new RoleDaoPostgres();
        //        Role? role = psql.SelectSpecific(RoleDictionary[comboBoxRoles.SelectedItem.ToString()]);

        //        if (role == null)
        //        {
        //            return;
        //        }

        //        //TxtRoleName.Text = role.Name;
        //        //TxtRoleWage.Text = role.Wage.ToString();
        //        //TxtHours.Text = role.Hours.ToString();
        //        //CbHR.Checked = role.Dp;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro! " + ex);
        //    }
        //}

        // Role Combo Box

        private void QueryRoles()
        {
            RoleDaoPostgres psql = new RoleDaoPostgres();
            List<Role> roles = psql.ReadAll();

            foreach (Role role in roles)
            {
                RoleDictionary.Add(role.Name, role.Id);
            }

            AddRoleComboValues();
        }

        private void AddRoleComboValues()
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

        private async void CheckCEP()
        {
            string CEP = TxtCEP.Text;

            try
            {
                string URL = "https://viacep.com.br/ws/" + CEP + "/json";
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(URL);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JObject dataObj = JObject.Parse(data);

                    TxtCEP.BackColor = SystemColors.Window;

                    if (!dataObj.ContainsKey("erro"))
                    {
                        return;
                    }
                }

                TxtCEP.BackColor = DefaultColors.WarnPink;
                LblInvalid.Text = "Campo CEP Inválido!";
                LblInvalid.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\n\nCEP não encontrado! Digite novamente");
            }
        }

        private async Task<bool> FillCEP()
        {
            string CEP = TxtCEP.Text;

            string URL = "https://viacep.com.br/ws/" + CEP + "/json";
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string data = await response.Content.ReadAsStringAsync();
                    JObject dataObj = JObject.Parse(data);

                    if (dataObj.ContainsKey("erro") || TxtNumber.Text == "")
                    {
                        return false;
                    }

                    Address address = new Address();

                    EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                    address.Id = Epsql.SelectNextId();
                    address.CEP = CEP;
                    address.Street = dataObj["logradouro"].ToString();
                    address.Number = int.Parse(TxtNumber.Text);
                    address.Suplement = TxtAddSuplement.Text;
                    address.Neighbourhood = dataObj["bairro"].ToString();
                    address.City = dataObj["localidade"].ToString();
                    address.State = dataObj["uf"].ToString();

                    AddressDaoPostgres psql = new AddressDaoPostgres();

                    psql.Insert(address);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}\n\nTente novamente!");
                }


                return true;
            }
            else
            {
                MessageBox.Show($"CEP não encontrado, erro {response.StatusCode}. Digite novamente");
                return false;
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateField("Name") && ValidateField("Email") && ValidateField("CPF") && ValidateField("Birthday") && ValidateField("Phone") && comboBoxRoles.SelectedItem != null)
            {
                bool isCepCorrect = await FillCEP();
                if (RoleDictionary.ContainsKey(comboBoxRoles.SelectedItem.ToString()) && isCepCorrect)
                {
                    try
                    {
                        string connString = DbConnection.connString;
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
                    TxtAddSuplement.Text = "";
                    TxtCEP.Text = "";
                    TxtNumber.Text = "";
                    TxtPhone.Text = "";
                    comboBoxRoles.SelectedIndex = -1;
                }
            }
        }
    }
}
