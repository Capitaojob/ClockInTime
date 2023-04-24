using System.Timers;
using PunchIn;
using PunchIn.dao;
using Workers;

namespace newTest
{
    public partial class PunchIn : UserControl
    {
        Employee User;
        System.Timers.Timer timer;

        public PunchIn(Employee User)
        {
            this.User = User;

            InitializeComponent();

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimerElapsed;
        }

        public void UpdateUser(Employee User)
        {
            this.User = User;
        }

        private void PunchIn_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            PnlRight.BackColor = DefaultColors.DarkBlue;
            BtnPunchIn.BackColor = DefaultColors.SandyBrown;

            BtnPunchIn.ForeColor = DefaultColors.White;

            LblLastRegisters.ForeColor = DefaultColors.WhiteGray;

            timer.Start();

            PunchInDaoPostgres psql = new PunchInDaoPostgres();
            ClockIn CurrentClockIn = psql.SelectSpecific(User.Id);

            PopulateRegisters();

            if (CurrentClockIn == null)
            {
                ClockIn newDay = new ClockIn();

                newDay.IdEmployee = User.Id;
                newDay.Date = DateTime.Now.Date;
                newDay.MainClockIn = null;
                newDay.LunchClockOut = null;
                newDay.LunchClockIn = null;
                newDay.MainClockOut = null;

                psql.Insert(newDay);

                CurrentClockIn = psql.SelectSpecific(User.Id);
            }

            LblUserId.Text = CurrentClockIn.Id.ToString();
            LblDate.Text = CurrentClockIn.Date.ToString("dd/MM/yyyy");
            LblMainIn.Text = CurrentClockIn.MainClockIn.ToString();
            LblLunchOut.Text = CurrentClockIn.LunchClockOut.ToString();
            LblLunchIn.Text = CurrentClockIn.LunchClockIn.ToString();
            LblMainOut.Text = CurrentClockIn.MainClockOut.ToString();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                lblCurrentTime.Text = DateTime.Now.ToString("HH:mm | dd/MM/yyyy");
            }));
        }

        private void BtnPunchIn_Click(object sender, EventArgs e)
        {
            PunchInDaoPostgres psql = new PunchInDaoPostgres();
            ClockIn CurrentClockIn = psql.SelectSpecific(User.Id);

            TimeSpan CurrentTime = TimeSpan.FromHours(DateTime.Now.Hour)
                        + TimeSpan.FromMinutes(DateTime.Now.Minute)
                        + TimeSpan.FromSeconds(DateTime.Now.Second);

            if (CurrentClockIn == null)
            {
                return;
            }

            if (CurrentClockIn.MainClockIn == null)
            {
                CurrentClockIn.MainClockIn = CurrentTime;
            }
            else if (CurrentClockIn.LunchClockOut == null)
            {
                CurrentClockIn.LunchClockOut = CurrentTime;
            }
            else if (CurrentClockIn.LunchClockIn == null)
            {
                CurrentClockIn.LunchClockIn = CurrentTime;
            }
            else if (CurrentClockIn.MainClockOut == null)
            {
                CurrentClockIn.MainClockOut = CurrentTime;
            }
            else
            {
                MessageBox.Show("Não há mais pontos para bater!");
                return;
            }

            psql.Update(CurrentClockIn);
        }

        private void PopulateRegisters()
        {
            PunchInDaoPostgres psql = new PunchInDaoPostgres();
            List<ClockIn> clockList = psql.ReadAll(User.Id);

            if (clockList != null)
            {
                foreach (ClockIn clock in clockList)
                {
                    string Date = clock.Date.ToString("dd/MM/yyyy");

                    if (clock.MainClockIn != null)
                    {
                        AddClockInLabel(Date, clock.MainClockIn.ToString());
                    }
                    if (clock.LunchClockOut != null)
                    {
                        AddClockInLabel(Date, clock.LunchClockOut.ToString());
                    }
                    if (clock.LunchClockIn != null)
                    {
                        AddClockInLabel(Date, clock.LunchClockIn.ToString());
                    }
                    if (clock.MainClockOut != null)
                    {
                        AddClockInLabel(Date, clock.MainClockOut.ToString());
                    }
                }
            }
        }

        private void AddClockInLabel(string Date, string clockIn)
        {
            Label label = new Label();
            label.Size = new Size(211, 30);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(0, 0, 0, 5);
            label.BackColor = DefaultColors.White;
            label.ForeColor = DefaultColors.DarkBlue;
            label.Text = $"{Date} | {clockIn}";
            TblLastRegisters.Controls.Add(label);
        }
    }
}
