using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models.Dtos
{
    public class MinorSpecialistDto : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Major Specialist ID is required.")]
        public int MajorSpecialistId { get; set; }  // Foreign key to MajorSpecialist

       // public List<VerySpecificSpecialistDto> VerySpecificSpecialists { get; set; } = new List<VerySpecificSpecialistDto>();
    }
}
