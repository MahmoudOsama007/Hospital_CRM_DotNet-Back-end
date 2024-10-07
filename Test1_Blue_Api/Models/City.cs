namespace Test1_Blue_Api.Models
{
    public class City : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Area> Area { get; set; }

        public virtual ICollection<Customer> customer { get; set; }
       

    }
}
