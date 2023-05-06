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
            this.BackColor = DefaultColors.White;
            LblUserName.BackColor = DefaultColors.White;
            BtnUpdatePw.BackColor = DefaultColors.SandyBrown;
            BtnUpdatePw.FlatAppearance.BorderSize = 0;
            PnlLeft.BackColor = DefaultColors.DarkBlue;

            LblWelcome.ForeColor = DefaultColors.SandyBrown;
            LblIntro.ForeColor = DefaultColors.Gray;

            TxtCpf.BackColor = DefaultColors.InputGray;
            TxtEmail.BackColor = DefaultColors.InputGray;
            TxtPw.BackColor = DefaultColors.InputGray;
            TxtRole.BackColor = DefaultColors.InputGray;

            BtnChangeAc.BackColor = DefaultColors.SandyBrown;
            BtnChangeAc.FlatAppearance.BorderSize = 0;

            BtnQuit.BackColor = DefaultColors.SandyBrown;
            BtnQuit.FlatAppearance.BorderSize = 0;

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
            if (DesignMode) return;

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
                EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                Epsql.Update(User);

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

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void BtnChangeAc_Click(object sender, EventArgs e)
        {
            ParentForm.Hide();

            loginForm login = new loginForm();
            login.Closed += (s, args) => ParentForm.Close();
            login.Show();
        }
    }
}
