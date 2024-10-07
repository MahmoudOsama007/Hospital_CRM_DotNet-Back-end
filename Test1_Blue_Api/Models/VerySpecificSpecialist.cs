using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models
{
    public class VerySpecificSpecialist : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("MinorSpecialist")]
        public int MinorSpecialistId { get; set; }

        public MinorSpecialist MinorSpecialist { get; set; }

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>(); // Initialize collection
    }
}
