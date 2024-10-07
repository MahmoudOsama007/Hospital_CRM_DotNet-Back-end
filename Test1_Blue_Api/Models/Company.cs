using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models
{
    public class Company : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        
    }
}
