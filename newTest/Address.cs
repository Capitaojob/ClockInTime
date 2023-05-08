namespace Location
{
    public class Address
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

        private string _cep = "";
        public string CEP
        { 
            get
            {
                return _cep;
            }
            set
            {
                _cep = value;
            }
        }

        private string _street = "";
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }

        private int _number = 0;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        private string _neighbourhood = "";
        public string Neighbourhood
        {
            get
            {
                return _neighbourhood;
            }
            set
            {
                _neighbourhood = value;
            }
        }

        private string _suplement = "";
        public string Suplement
        {
            get
            {
                return _suplement;
            }
            set
            {
                _suplement = value;
            }
        }

        private string _city = "";
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        private string _state = "";
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
    }
}
