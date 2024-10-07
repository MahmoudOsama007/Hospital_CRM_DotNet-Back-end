using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models
{
    

    public class CallType : SoftDeleteCommen
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        //public bool IsActive { get; set; } = true; // Default to true
    }

}
