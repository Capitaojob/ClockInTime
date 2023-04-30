using Npgsql;
using Workers;
using Workers.dao;

namespace newTest
{
    public partial class UserData : UserControl
    {
        Employee User = new Employee();

        public UserData()
        {
            InitializeComponent();
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateUser(Employee User)
        {
            this.User = User;
            UpdateData();
        }

        private void UpdateData()
        {
            LblUserName.Text = User.Name;
            TxtEmail.Text = User.Email;
            TxtCpf.Text = User.CPF;
            SelectUserRole();
        }

        private void SelectUserRole()
        {
            EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();

            TxtRole.Text = Epsql.SelectRole(User.Id);
        }

        private void BtnUpdatePw_Click(object sender, EventArgs e)
        {
            if (TxtPw.Text.Length < 6)
            {
                LblPwWarning.Text = "Senha muito curta!";
            }
            else if (TxtPw.Text.Length > 30)
            {
                LblPwWarning.Text = "Senha muito longa!";
            }
            else
            {
                User.Password = HashUtils.HashString(TxtPw.Text);
                using NpgsqlConnection conn = new("Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=tzrh");
                conn.Open();

                NpgsqlCommand cmd = new($"UPDATE funcionarios SET senha = '" + User.Password + "' WHERE email = '" + User.Email + "'", conn);
                cmd.ExecuteNonQuery();

                LblPwWarning.Text = "Senha alterada com sucesso!";
            }
        }

        private void ImgPwEye_Click(object sender, EventArgs e)
        {
            if (TxtPw.PasswordChar == '*')
            {
                TxtPw.PasswordChar = '\0';
                ImgPwEye.Image = Properties.Resources.hide;
                ImgPwEye.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                TxtPw.PasswordChar = '*';
                ImgPwEye.Image = Properties.Resources.view;
                ImgPwEye.BackgroundImage = Properties.Resources.view;
            }

            ImgPwEye.Refresh();
        }
    }
}
