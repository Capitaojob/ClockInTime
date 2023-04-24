namespace PunchIn
{
    public class ClockIn
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _idEmployee;
        public int IdEmployee 
        { 
            get { return _idEmployee; }
            set { _idEmployee = value; }
        }

        private DateTime _date;
        public DateTime Date 
        { 
            get { return _date; } 
            set {  _date = value; } 
        }

        private TimeSpan? _mainClockIn; 
        public TimeSpan? MainClockIn
        {
            get { return _mainClockIn; }
            set { _mainClockIn = value; }
        }

        private TimeSpan? _lunchClockOut;
        public TimeSpan? LunchClockOut
        {
            get { return _lunchClockOut; }
            set { _lunchClockOut = value; }
        }

        private TimeSpan? _lunchClockIn;
        public TimeSpan? LunchClockIn
        {
            get { return _lunchClockIn; }
            set { _lunchClockIn = value; }
        }

        private TimeSpan? _mainClockOut;
        public TimeSpan? MainClockOut
        {
            get { return _mainClockOut; }
            set { _mainClockOut = value; }
        }
    }
}
