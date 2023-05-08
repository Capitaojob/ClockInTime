namespace Location
{
    public class Address
    {
        public int Id { get; set; }

        public string CEP { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public string Neighbourhood { get; set; }

        public string Suplement { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public Address()
        {
            this.Id = 0;
            this.CEP = "";
            this.Street = "";
            this.Number = 0;
            this.Neighbourhood = "";
            this.Suplement = "";
            this.City = "";
            this.State = "";
        }
    }
}
