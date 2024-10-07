using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models
{
    public class MajorSpecialist : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }

        public Hospital Hospital { get; set; }

        public ICollection<MinorSpecialist> MinorSpecialists { get; set; }
    }
}
