using Workers.dao;
using Workers;
using PunchIn.dao;
using PunchIn;

namespace newTest
{
    public partial class PunchInViewerGeneral : UserControl
    {
        Employee employee = new Employee();
        Dictionary<string, int> EmployeeDictionary = new Dictionary<string, int>();

        public PunchInViewerGeneral()
        {
            InitializeComponent();
        }

        private void PunchInViewerGeneral_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            PnlLeft.BackColor = DefaultColors.DarkBlue;
            LblWelcome.ForeColor = DefaultColors.SandyBrown;
            LblIntro.ForeColor = DefaultColors.Gray;
            LblUpdateUser.ForeColor = DefaultColors.White;
            BtnUpdate.BackColor = DefaultColors.SandyBrown;
            BtnUpdate.FlatAppearance.BorderSize = 0;

            QueryEmployees();
        }
        
        public void UpdateEmployee(Employee employee)
        {
            this.employee = employee;
            UpdateData();
        }

        // Add Employees to Combo box
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

        // Changing Combo Box Index Updates Table
        private void CbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LblInvalid.ForeColor = DefaultColors.WarnPink;
                //LblInvalid.Visible = false

                EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                Employee? employee = Epsql.SelectSpecific(CbEmployees.SelectedItem.ToString());

                if (employee == null)
                {
                    return;
                }

                //ClearTable();
                UpdateEmployee(employee);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex);
            }
        }

        private void UpdateData()
        {
            if (DesignMode) return;
            TblLastRegisters.Controls.Clear();
            PopulateRegisters();
        }

        private void PopulateRegisters()
        {
            PunchInDaoPostgres psql = new PunchInDaoPostgres();
            List<ClockIn> clockList = psql.ReadAll(employee.Id, false);

            if (clockList == null || clockList.Count == 0)
            {
                Label label = new Label();
                label.Size = new Size(450, 40);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Margin = new Padding(75, 8, 0, 8);
                //label.ForeColor = DefaultColors.White;
                //label.BackColor = DefaultColors.SandyBrown;
                label.ForeColor = DefaultColors.White;
                label.BackColor = DefaultColors.DarkBlue;
                label.Text = "Nenhum Registro Encontrado!";
                label.Font = new Font("Neon 80s", 20, FontStyle.Regular);
                TblLastRegisters.Controls.Add(label);
                return;
            }

            foreach (ClockIn clock in clockList)
            {
                AddDateLabel(clock.Date.ToString("dd/MM/yyyy"));

                if (clock.MainClockOut != null)
                {
                    AddClockInLabel("Saída", clock.MainClockOut.ToString());
                }
                if (clock.LunchClockIn != null)
                {
                    AddClockInLabel("Entrada Almoço", clock.LunchClockIn.ToString());
                }
                if (clock.LunchClockOut != null)
                {
                    AddClockInLabel("Saída Almoço", clock.LunchClockOut.ToString());
                }
                if (clock.MainClockIn != null)
                {
                    AddClockInLabel("Entrada", clock.MainClockIn.ToString());
                }
            }
        }

        private void AddDateLabel(string Date)
        {
            Label label = new Label();
            label.Size = new Size(450, 40);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(75, 8, 0, 8);
            //label.ForeColor = DefaultColors.White;
            //label.BackColor = DefaultColors.SandyBrown;
            label.ForeColor = DefaultColors.White;
            label.BackColor = DefaultColors.DarkBlue;
            label.Text = Date;
            label.Font = new Font("Neon 80s", 20, FontStyle.Regular);
            TblLastRegisters.Controls.Add(label);
        }

        private void AddClockInLabel(string Type, string clockIn)
        {
            Label label = new Label();
            label.Size = new Size(400, 40);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(100, 8, 0, 8);
            label.ForeColor = DefaultColors.DarkBlue;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Text = $"{Type} | {clockIn}";
            label.Font = new Font("Neon 80s", 15, FontStyle.Regular);
            TblLastRegisters.Controls.Add(label);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            QueryEmployees();
        }
    }
}
