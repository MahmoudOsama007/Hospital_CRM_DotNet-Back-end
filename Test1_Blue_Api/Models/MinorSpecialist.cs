using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1_Blue_Api.Models
{
    public class MinorSpecialist : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [ForeignKey(nameof(MajorSpecialist))]
        public int MajorSpecialistId { get; set; }

        public MajorSpecialist MajorSpecialist { get; set; }

        public ICollection<VerySpecificSpecialist> VerySpecificSpecialists { get; set; } = new List<VerySpecificSpecialist>();
    }
}
