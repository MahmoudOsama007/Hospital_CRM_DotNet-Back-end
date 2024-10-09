using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1_Blue_Api.Models
{
    public class Customer : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType("nvarchar[max]")]
        public string? Address { get; set; }
        [Required]
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        public Area Area { get; set; }  // Navigation property

        [Required]
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }  // Navigation property


        [Required]
        public string PhoneNumber { get; set; }

        public string? OtherPhoneNumber { get; set; }

        public string? LandLineNumber { get; set; }

        [Required]
        public int PatientNumber { get; set; }

        public ICollection<Ticket>? Ticket { get; set; }


        public DateTime? CreationDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; } = DateTime.Now;



    }
}
