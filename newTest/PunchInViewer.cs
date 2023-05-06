using PunchIn.dao;
using PunchIn;
using Workers;
using Microsoft.VisualBasic.Devices;

namespace newTest
{
    public partial class PunchInViewer : UserControl
    {
        Employee User = new Employee();

        public PunchInViewer()
        {
            InitializeComponent();
        }

        private void PunchInViewer_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            PnlLeft.BackColor = DefaultColors.DarkBlue;
            LblWelcome.ForeColor = DefaultColors.SandyBrown;
            LblIntro.ForeColor = DefaultColors.Gray;
            BtnUpdate.BackColor = DefaultColors.SandyBrown;
            BtnUpdate.FlatAppearance.BorderSize = 0;
        }

        public void UpdateUser(Employee User)
        {
            this.User = User;
            UpdateData();
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
            List<ClockIn> clockList = psql.ReadAll(User.Id, false);

            if (clockList == null || clockList.Count == 0)
            {
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
            UpdateData();
        }
    }
}
