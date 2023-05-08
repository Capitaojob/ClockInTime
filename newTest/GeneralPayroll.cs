using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.Protocols;
using Workers;
using Workers.dao;

namespace newTest
{
    public partial class GeneralPayroll : UserControl
    {
        Dictionary<string, int> EmployeeDictionary = new Dictionary<string, int>();

        public GeneralPayroll()
        {
            InitializeComponent();
        }

        private void GeneralPayroll_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            PnlLeftInfo.BackColor = DefaultColors.DarkBlue;

            LblWelcome.ForeColor = DefaultColors.SandyBrown;
            LblIntro.ForeColor = DefaultColors.Gray;

            BtnGeneratePayroll.BackColor = DefaultColors.SandyBrown;
            BtnGeneratePayroll.FlatAppearance.BorderSize = 0;

            DtStart.Value = DateTime.Now.AddMonths(-1);
            QueryEmployees();
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = FBD.SelectedPath;
                BtnFolder.Text = selectedPath;
            }
        }

        private void BtnGeneratePayroll_Click(object sender, EventArgs e)
        {
            if (CbIsGeneralPaycheck.Checked)
            {
                // General Paycheck
                // Todo
            }
            else
            {
                if (CbEmployees.SelectedIndex == -1)
                {
                    return;
                }

                EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                Employee employee = Epsql.SelectSpecific(CbEmployees.SelectedItem.ToString());

                if (employee == null)
                {
                    return;
                }

                PayrollUtils payrollUtils = new PayrollUtils();
                payrollUtils.GeneratePayrollPdf(employee, BtnFolder.Text, DtStart.Value, DtEnd.Value);
            }
        }

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
    }
}
