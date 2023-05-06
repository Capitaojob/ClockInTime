namespace Roles
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Hours { get; set; }

        public decimal Wage { get; set; }

        public bool Dp { get; set; }

        public Role()
        {
            this.Name = "";
        }
    }
}
