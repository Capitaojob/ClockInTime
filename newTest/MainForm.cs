using Workers;
using Workers.dao;

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
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            BtnManageUsers.BackColor = DefaultColors.LightBlue;

            BtnClockIn.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnConference.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnPayment.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnRole.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnSignIn.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnGeneralPayment.FlatAppearance.BorderColor = DefaultColors.LightBlue;
            BtnManageUsers.FlatAppearance.BorderColor = DefaultColors.LightBlue;

            EmployeeDaoPostgres psql = new EmployeeDaoPostgres();
            if (!psql.SelectHrRole(User.Role))
            {
                LblManagement.Visible = false;
                BtnSignIn.Visible = false;
                BtnRole.Visible = false;
                BtnGeneralPayment.Visible = false;
                BtnManageUsers.Visible = false;
            }

            ShowMainInfo();
        }

        // Side Buttons
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            LblPath.Text = "Início > Gerenciar Funcionário";
            HideAll();
            registerEmployee1.Show();

        }

        private void BtnClockIn_Click(object sender, EventArgs e)
        {
            LblPath.Text = "Início > Registro de Ponto";
            HideAll();
            punchInControl1.Show();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            LblPath.Text = "Início > Demonstrativo de Pagamento";
            HideAll();
            userPayroll1.Show();
        }

        private void PnlUserInfo_Click(object sender, EventArgs e)
        {
            ShowMainInfo();
        }

        private void PbUser_Click(object sender, EventArgs e)
        {
            ShowMainInfo();
        }

        private void BtnConference_Click(object sender, EventArgs e)
        {
            LblPath.Text = "Início > Consulta de Pontos";
            HideAll();
            punchInViewer1.Show();
        }

        private void ShowMainInfo()
        {
            LblPath.Text = "Início > Minha Conta";
            HideAll();
        }

        private void HideAll()
        {
            punchInControl1.Hide();
            registerEmployee1.Hide();
            userPayroll1.Hide();
            roleManagement1.Hide();
            punchInViewer1.Hide();
        }

        private void userData1_Load(object sender, EventArgs e)
        {
            userData1.UpdateUser(User);
        }

        private void punchInControl1_Load(object sender, EventArgs e)
        {
            punchInControl1.UpdateUser(User);
        }

        private void registerEmployee_Load(object sender, EventArgs e)
        {
            registerEmployee1.UpdateUser(User);
        }

        private void userPayroll1_Load(object sender, EventArgs e)
        {
            userPayroll1.UpdateUser(User);
        }

        private void punchInViewer1_Load(object sender, EventArgs e)
        {
            punchInViewer1.UpdateUser(User);
        }

        private void BtnRole_Click(object sender, EventArgs e)
        {
            LblPath.Text = "Início > Gerenciar Cargos";
            HideAll();
            roleManagement1.Show();
        }
    }
}
