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

            QueryRoles();
        }

        private void QueryRoles()
        {
            string connString = DbConnection.connString;
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

            AddComboValues();
        }

        private void AddComboValues()
        {
            foreach (KeyValuePair<string, int> item in RoleDictionary)
            {
                comboBoxRoles.Items.Add(item.Key);
            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoleDaoPostgres psql = new RoleDaoPostgres();
            Role role = psql.SelectSpecific(comboBoxRoles.SelectedIndex);

            TxtRoleName.Text = role.Name;
            TxtRoleWage.Text = role.Wage.ToString();
            CbHR.Checked = role.Dp;
        }
    }
}
