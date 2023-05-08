using Npgsql;
using Roles;
using Roles.Dao;

namespace newTest
{
    public partial class RoleManagement : UserControl
    {
        Dictionary<string, int> RoleDictionary = new Dictionary<string, int>();

        public RoleManagement()
        {
            InitializeComponent();
        }

        private void RoleManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            BtnSave.BackColor = DefaultColors.SandyBrown;
            BtnNew.BackColor = DefaultColors.SandyBrown;
            BtnDelete.BackColor = DefaultColors.WarnPink;
            BtnNew.FlatAppearance.BorderSize = 0;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatAppearance.BorderSize = 0;

            LblWarning.Visible = false;
            LblWarning.ForeColor = DefaultColors.SandyBrown;

            QueryRoles();
        }

        private void QueryRoles()
        {
            RoleDaoPostgres psql = new RoleDaoPostgres();
            List<Role> roles = psql.ReadAll();

            RoleDictionary.Clear();

            foreach (Role role in roles)
            {
                RoleDictionary.Add(role.Name, role.Id);
            }

            AddComboValues();
        }

        private void AddComboValues()
        {
            comboBoxRoles.Items.Clear();

            foreach (KeyValuePair<string, int> item in RoleDictionary)
            {
                comboBoxRoles.Items.Add(item.Key);
            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRoles.SelectedIndex == -1)
                {
                    return;
                }

                RoleDaoPostgres psql = new RoleDaoPostgres();
                Role? role = psql.SelectSpecific(RoleDictionary[comboBoxRoles.SelectedItem.ToString()]);

                if (role == null)
                {
                    return;
                }

                TxtRoleName.Text = role.Name;
                TxtRoleWage.Text = role.Wage.ToString();
                TxtHours.Text = role.Hours.ToString();
                CbHR.Checked = role.Dp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRoles.SelectedIndex == -1)
                {
                    Role role = new Role();
                    role.Name = TxtRoleName.Text;
                    role.Hours = int.Parse(TxtHours.Text);
                    role.Wage = decimal.Parse(TxtRoleWage.Text);
                    role.Dp = CbHR.Checked;

                    RoleDaoPostgres psql = new RoleDaoPostgres();
                    psql.Insert(role);
                }
                else
                {
                    Role role = new Role();
                    role.Id = RoleDictionary[comboBoxRoles.SelectedItem.ToString()];
                    role.Name = TxtRoleName.Text;
                    role.Hours = int.Parse(TxtHours.Text);
                    role.Wage = decimal.Parse(TxtRoleWage.Text);
                    role.Dp = CbHR.Checked;

                    RoleDaoPostgres psql = new RoleDaoPostgres();
                    psql.Update(role);
                }

                QueryRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex.Message);
            }

            ClearInputs();
            LblWarning.Visible = true;
            LblWarning.Text = "Dados salvos com sucesso!";
        }

        private void TxtRoleWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            TxtRoleName.Text = "";
            TxtHours.Text = "";
            TxtRoleWage.Text = "";
            CbHR.Checked = false;
            comboBoxRoles.SelectedIndex = -1;
            LblWarning.ForeColor = DefaultColors.SandyBrown;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LblWarning.Visible = true;

            if (comboBoxRoles.SelectedIndex == -1)
            {
                LblWarning.ForeColor = DefaultColors.WarnRed;
                LblWarning.Text = "Nenhum cargo selecionado!";
            }
            else
            {
                try
                {
                    RoleDaoPostgres Rpsql = new RoleDaoPostgres();
                    Rpsql.Delete(RoleDictionary[comboBoxRoles.SelectedItem.ToString()]);

                    ClearInputs();
                    LblWarning.Text = "Dados salvos com sucesso!";

                    QueryRoles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }
            }
        }
    }
}
