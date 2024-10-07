using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1_Blue_Api.Models
{
    public class Doctor : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Qualification { get; set; }

        [ForeignKey("VerySpecificSpecialist")]
        public int VerySpecificSpecialistId { get; set; }

        public VerySpecificSpecialist VerySpecificSpecialist { get; set; }
        public string ?ContactNumber { get; set; }


    }
}
