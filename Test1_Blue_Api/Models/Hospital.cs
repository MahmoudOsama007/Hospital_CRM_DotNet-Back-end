using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models
{
    public class Hospital : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }
        public string? ContactNumber { get; set; }
        public ICollection<MajorSpecialist> MajorSpecialists { get; set; }
    }
}
