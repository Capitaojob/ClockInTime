using Microsoft.VisualBasic.ApplicationServices;
using Workers;
using Workers.dao;

namespace newTest
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.DarkBlue;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            ImgPwEye.BackColor = DefaultColors.InputGray;

            MiddlePanel.BackColor = DefaultColors.White;
            TxtLoginWarning.BackColor = DefaultColors.White;

            loginInput.BackColor = DefaultColors.InputGray;
            loginInput.AutoSize = false;
            loginInput.Size = new Size(390, 120);

            pwInput.BackColor = DefaultColors.InputGray;
            pwInput.AutoSize = false;
            pwInput.Size = new Size(390, 120);

            loginBtn.Size = new Size(390, 60);
        }

        private void ImgPwEye_Click(object sender, EventArgs e)
        {
            if (pwInput.PasswordChar == '*')
            {
                pwInput.PasswordChar = '\0';
                ImgPwEye.Image = Properties.Resources.hide;
                ImgPwEye.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                pwInput.PasswordChar = '*';
                ImgPwEye.Image = Properties.Resources.view;
                ImgPwEye.BackgroundImage = Properties.Resources.view;
            }

            ImgPwEye.Refresh();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginClick();
        }

        private void pwInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginClick();
            }
        }

        private void LoginClick()
        {
            if (loginInput.Text != "" && pwInput.Text != "")
            {
                EmployeeDaoPostgres psql = new EmployeeDaoPostgres();
                Employee? User = psql.SelectSpecific(loginInput.Text);

                if (User != null && Employee.Login(loginInput.Text, HashUtils.HashString(pwInput.Text)))
                {
                    TxtLoginWarning.Text = "Entrando...";
                    this.Hide();

                    MainForm newMainForm = new MainForm(User);
                    newMainForm.Closed += (s, args) => this.Close();
                    newMainForm.Show();
                }
                else
                {
                    TxtLoginWarning.Text = "Login inválido!";
                    pwInput.Text = "";
                }
            }
        }

        private void LblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            ForgotPassword newForgotPassword = new ForgotPassword();
            newForgotPassword.Closed += (s, args) => this.Close();
            newForgotPassword.Show();
        }
    }
}