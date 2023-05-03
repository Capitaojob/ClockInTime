namespace Roles
{
    public class Role
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _name = "";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _hours = 0;
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value;
            }
        }

        private decimal _wage = 0;
        public decimal Wage
        {
            get
            {
                return _wage;
            }
            set
            {
                _wage = value;
            }
        }

        private bool _dp = false;
        public bool Dp
        {
            get
            {
                return _dp;
            }
            set 
            { 
                _dp = value; 
            }
        }
    }
}
