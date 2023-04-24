using Workers;

namespace newTest
{
    public partial class MainForm : Form
    {
        Employee User;

        public MainForm(Employee User)
        {
            this.User = User;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.InputGray;
            PnlMainLeft.BackColor = DefaultColors.DarkBlue;
            PnlDivider.BackColor = DefaultColors.Gray;
            LblLogoTop.BackColor = DefaultColors.DarkBlue;
            PnlMainContent.BackColor = DefaultColors.White;

            LblLogoTop.ForeColor = DefaultColors.SandyBrown;
            LblQuestionMark.ForeColor = DefaultColors.White;
            LblPath.ForeColor = DefaultColors.DarkBlue;
            LblClockIn.ForeColor = DefaultColors.WhiteGray;
            LblPayment.ForeColor = DefaultColors.WhiteGray;
            LblManagement.ForeColor = DefaultColors.WhiteGray;

            BtnClockIn.BackColor = DefaultColors.LightBlue;
            BtnConference.BackColor = DefaultColors.LightBlue;
            BtnPayment.BackColor = DefaultColors.LightBlue;
            BtnRole.BackColor = DefaultColors.LightBlue;
            BtnSignIn.BackColor = DefaultColors.LightBlue;
            BtnGeneralPayment.BackColor = DefaultColors.LightBlue;

            BtnClockIn.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnConference.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnPayment.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnRole.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnSignIn.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnGeneralPayment.FlatAppearance.BorderColor = DefaultColors.LightBlue;

            if (User.Role != 3)
            {
                LblManagement.Visible = false;
                BtnSignIn.Visible = false;
                BtnRole.Visible = false;
                BtnGeneralPayment.Visible = false;
            }

            ShowMainInfo();
        }

        // Side Buttons
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            LblPath.Text = "Início > Registrar Funcionário";
            HideAll();
            registerEmployee.Show();

        }

        private void BtnClockIn_Click(object sender, EventArgs e)
        {
            LblPath.Text = "Início > Registro de Ponto";
            HideAll();
            punchInControl1.Show();
        }

        private void PnlUserInfo_Click(object sender, EventArgs e)
        {
            ShowMainInfo();
        }

        private void PbUser_Click(object sender, EventArgs e)
        {
            ShowMainInfo();
        }

        private void ShowMainInfo()
        {
            LblPath.Text = "Início > Minha Conta";
            HideAll();
        }

        private void HideAll()
        {
            punchInControl1.Hide();
            registerEmployee.Hide();
        }

        private void userData1_Load(object sender, EventArgs e)
        {
            userData1.UpdateUser(User);
        }

        private void punchInControl1_Load(object sender, EventArgs e)
        {
            punchInControl1.UpdateUser(User);
        }
    }
}
