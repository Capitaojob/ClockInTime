using System.Text.RegularExpressions;
using Location;
using Location.dao;
using Newtonsoft.Json.Linq;
using Npgsql;
using Roles.Dao;
using Roles;
using Workers;
using Workers.dao;
using Phone.dao;
using Phone;

namespace newTest
{
    public partial class RegisterEmployee : UserControl
    {
        Dictionary<string, int> RoleDictionary = new Dictionary<string, int>();
        Dictionary<string, int> EmployeeDictionary = new Dictionary<string, int>();
        //Employee User = new Employee();

        // Update Variables
        Employee updEmployee = new Employee();
        Address updAddress = new Address();
        Phones updPhone = new Phones();

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
            LblInvalid.ForeColor = DefaultColors.WarnRed;
            LblUpdateUser.ForeColor = DefaultColors.White;

            BtnRegister.BackColor = DefaultColors.SandyBrown;
            BtnRegister.FlatAppearance.BorderSize = 0;
            BtnNew.BackColor = DefaultColors.SandyBrown;
            BtnNew.FlatAppearance.BorderSize = 0;
            BtnDisable.BackColor = DefaultColors.WarnPink;
            BtnDisable.FlatAppearance.BorderSize = 0;

            LblInvalid.Visible = false;

            if (DesignMode) return;
            QueryRoles();
            QueryEmployees();
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
                EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                if (Epsql.SelectSpecific(TxtEmail.Text) == null ? false : true && BtnRegister.Text != "Atualizar")
                {
                    TxtEmail.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Email já cadastrado!";
                    LblInvalid.Visible = true;
                    return false;
                }
                else if (!TxtEmail.Text.Contains('@') || !(TxtEmail.Text.Length >= 3))
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
                if (CbRoles.SelectedIndex == -1)
                {
                    CbRoles.BackColor = DefaultColors.WarnPink;
                    LblInvalid.Text = "Campo Cargo Inválido!";
                    LblInvalid.Visible = true;

                    return false;
                }
                else
                {
                    CbRoles.BackColor = SystemColors.Window;

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

        private void CbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LblInvalid.ForeColor = DefaultColors.WarnPink;
                LblInvalid.Visible = false;

                if (CbEmployees.SelectedIndex == -1)
                {
                    BtnRegister.Text = "Registrar";
                    return;
                }

                EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                Employee? employee = Epsql.SelectSpecific(CbEmployees.SelectedItem.ToString());

                if (employee == null)
                {
                    return;
                }

                ClearInputs();

                // General Info
                updEmployee = employee;
                TxtName.Text = employee.Name;
                TxtEmail.Text = employee.Email;
                TxtCPF.Text = employee.CPF;
                TxtBirthday.Text = employee.Birthday.Date.ToString("dd/MM/yyyy");

                // Role Combo Box
                RoleDaoPostgres Rpsql = new RoleDaoPostgres();
                string role = Rpsql.SelectSpecific(employee.Role).Name;
                if (role == null)
                {
                    LblInvalid.Visible = true;
                    LblInvalid.Text = "Cargo não encontrado!";
                }
                else
                {
                    int index = CbRoles.FindStringExact(role);
                    if (index != -1)
                    {
                        CbRoles.SelectedIndex = index;
                    }
                }

                // Address Text
                AddressDaoPostgres Apsql = new AddressDaoPostgres();
                Address address = Apsql.SelectSpecific(employee.Id);
                if (address == null)
                {
                    LblInvalid.Visible = true;
                    LblInvalid.Text = "Endereço não encontrado!";
                }
                else
                {
                    updAddress = address;
                    TxtCEP.Text = address.CEP;
                    TxtNumber.Text = address.Number.ToString();
                    TxtAddSuplement.Text = address.Suplement;
                }

                // Phone Text
                PhoneDaoPostgres Ppsql = new PhoneDaoPostgres();
                Phones phone = Ppsql.SelectSpecific(employee.Id);
                if (phone == null)
                {
                    LblInvalid.Visible = true;
                    LblInvalid.Text = "Telefone não encontrado!";
                }
                else
                {
                    updPhone = phone;
                    TxtPhone.Text = phone.Number;
                }

                BtnRegister.Text = "Atualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }
        }

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
                CbRoles.Items.Add(item.Key);
            }
        }

        // CPF / CEP Validation
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

        private async Task<bool> CheckCEP()
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

                    if (!dataObj.ContainsKey("erro")) return true;
                }

                TxtCEP.BackColor = DefaultColors.WarnPink;
                LblInvalid.Text = "Campo CEP Inválido!";
                LblInvalid.Visible = true;
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\n\nCEP não encontrado! Digite novamente");
                return false;
            }
        }

        private async Task<Address> GetAddress(int Id)
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
                        return null;
                        //return false;
                    }

                    Address address = new Address();

                    address.Id = Id;
                    address.CEP = CEP;
                    address.Street = dataObj["logradouro"].ToString();
                    address.Number = int.Parse(TxtNumber.Text);
                    address.Suplement = TxtAddSuplement.Text;
                    address.Neighbourhood = dataObj["bairro"].ToString();
                    address.City = dataObj["localidade"].ToString();
                    address.State = dataObj["uf"].ToString();

                    return address;
                    //AddressDaoPostgres psql = new AddressDaoPostgres();
                    //psql.Insert(address);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}\n\nTente novamente!");
                    return null;
                }
                //return true;
            }
            else
            {
                MessageBox.Show($"CEP não encontrado, erro {response.StatusCode}. Digite novamente");
                return null;
            }
        }

        // Input Manage
        private void ClearInputs()
        {
            TxtName.Text = "";
            TxtEmail.Text = "";
            TxtCPF.Text = "";
            TxtBirthday.Text = "";
            TxtAddSuplement.Text = "";
            TxtCEP.Text = "";
            TxtNumber.Text = "";
            TxtPhone.Text = "";
            CbRoles.SelectedIndex = -1;
            CbEmployees.SelectedIndex = -1;
            LblInvalid.Visible = false;
        }

        private void ResetInputColors()
        {
            TxtName.BackColor = SystemColors.Window;
            TxtCPF.BackColor = SystemColors.Window;
            TxtEmail.BackColor = SystemColors.Window;
            TxtBirthday.BackColor = SystemColors.Window;
            TxtAddSuplement.BackColor = SystemColors.Window;
            TxtCEP.BackColor = SystemColors.Window;
            TxtNumber.BackColor = SystemColors.Window;
            TxtPhone.BackColor = SystemColors.Window;
        }

        // Buttons
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateField("Name") && ValidateField("Email") && ValidateField("CPF") && ValidateField("Birthday") && ValidateField("Phone") && CbRoles.SelectedItem != null)
            {
                bool isCepCorrect = await CheckCEP(); //GetAddress
                if (RoleDictionary.ContainsKey(CbRoles.SelectedItem.ToString()) && isCepCorrect)
                {
                    if (BtnRegister.Text == "Atualizar")
                    {
                        try
                        {
                            // Update User
                            updEmployee.Name = TxtName.Text;
                            updEmployee.Email = TxtEmail.Text;
                            updEmployee.Birthday = DateTime.Parse(TxtBirthday.Text);
                            updEmployee.CPF = TxtCPF.Text;
                            updEmployee.Role = RoleDictionary[CbRoles.SelectedItem.ToString()];

                            EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                            Epsql.Update(updEmployee);

                            // Update Address
                            updAddress = await GetAddress(updEmployee.Id);
                            updAddress.Number = int.Parse(TxtNumber.Text);
                            updAddress.Suplement = TxtAddSuplement.Text;

                            AddressDaoPostgres Apsql = new AddressDaoPostgres();
                            Apsql.Update(updAddress);

                            // Update Phone
                            updPhone.Number = TxtPhone.Text;

                            PhoneDaoPostgres Ppsql = new PhoneDaoPostgres();
                            Ppsql.Update(updPhone);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro! " + ex);
                        }

                        LblInvalid.Text = "Usuário Atualizado!";
                        BtnRegister.Text = "Registrar";

                    }
                    else
                    {
                        try
                        {
                            // Register Address
                            EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                            int Id = Epsql.SelectNextId();

                            Address address = await GetAddress(Id);
                            AddressDaoPostgres psql = new AddressDaoPostgres();
                            psql.Insert(address);

                            // Register Phone
                            PhoneDaoPostgres Ppsql = new PhoneDaoPostgres();
                            Ppsql.Insert(Id, TxtPhone.Text);

                            // Register User
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
                                    cmd.Parameters.AddWithValue("@role", RoleDictionary[CbRoles.SelectedItem.ToString()]);
                                    cmd.Parameters.AddWithValue("@password", HashUtils.HashString("tz1234"));
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                        LblInvalid.Text = "Usuário Cadastrado!";
                    }
                    LblInvalid.ForeColor = DefaultColors.SandyBrown;
                    LblInvalid.Visible = true;
                    ClearInputs();
                    QueryEmployees();
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ResetInputColors();
        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Quer mesmo inativar este usuário?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                if (updEmployee.Name == TxtName.Text)
                {
                    updEmployee.Status = false;
                    EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                    Epsql.Update(updEmployee);
                    ClearInputs();
                    ResetInputColors();
                    QueryEmployees();
                }
                else
                {
                    MessageBox.Show("Algo deu errado, tente novamente!");
                }
            }
        }
    }
}
