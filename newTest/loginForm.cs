using Microsoft.VisualBasic;
using newTest;
using Npgsql;

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

        private void pwInput_TextChanged(object sender, EventArgs e)
        {
            if (pwInput.Text != "")
            {
                int PassScore = 0;

                foreach (char c in pwInput.Text)
                {
                    PassScore += c * 24 % 200;
                }

                if (PassScore < 800)
                {
                    TxtLoginWarning.Text = "Senha fraca";
                }
                else if (pwInput.Text.Contains(' '))
                {
                    TxtLoginWarning.Text = "Senha não pode conter espaço";
                }
                else
                {
                    TxtLoginWarning.Text = "";
                }
            }
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
            using NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=JOpe2004!; Database=TzRH");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM funcionarios WHERE email = '{loginInput.Text}' AND status = '1'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && loginInput.Text == dr.GetString(2) && pwInput.Text == dr.GetString(7))
            {
                Employee.Name = dr.GetString(1);
                Employee.Email = dr.GetString(2);
                Employee.CPF = dr.GetString(3);
                Employee.Birthday = (dr.GetDateTime(4)).ToString();
                Employee.Role = dr.GetInt32(5);
                Employee.Password = dr.GetString(7);

                TxtLoginWarning.Text = "Entrando...";
                this.Hide();
                MainForm newMainForm = new();
                newMainForm.Closed += (s, args) => this.Close();
                newMainForm.Show();
            }
            else
            {
                TxtLoginWarning.Text = "Login inválido!";
                pwInput.Text = "";
            }

            dr.Close();
        }
    }
}