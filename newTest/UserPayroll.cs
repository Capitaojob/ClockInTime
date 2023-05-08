using Workers;

namespace newTest
{
    public partial class UserPayroll : UserControl
    {
        Employee User = new Employee();

        public UserPayroll()
        {
            InitializeComponent();
        }

        private void UserPayroll_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            //PnlLeftInfo.BackColor = DefaultColors.InputGray;
            PnlLeftInfo.BackColor = DefaultColors.DarkBlue;

            LblWelcome.ForeColor = DefaultColors.SandyBrown;
            LblIntro.ForeColor = DefaultColors.Gray;

            BtnGeneratePayroll.BackColor = DefaultColors.SandyBrown;
            //BtnGeneratePayroll.FlatStyle = FlatStyle.Flat;
            BtnGeneratePayroll.FlatAppearance.BorderSize = 0;

            DtStart.Value = DateTime.Now.AddMonths(-1);
        }

        public void UpdateUser(Employee User)
        {
            this.User = User;
        }

        private void BtnGeneratePayroll_Click(object sender, EventArgs e)
        {
            PayrollUtils payrollUtils = new PayrollUtils();
            payrollUtils.GeneratePayrollPdf(User, BtnFolder.Text, DtStart.Value, DtEnd.Value);
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = FBD.SelectedPath;
                BtnFolder.Text = selectedPath;
            }
        }
    }
}
