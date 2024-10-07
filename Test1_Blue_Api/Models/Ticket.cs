using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1_Blue_Api.Models
{
    public class Ticket : SoftDeleteCommen
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [DataType("nvarchar(max)")]
        public string? Address { get; set; }
        [Required]
        //[ForeignKey("Area2")]
        public string AssignedAreaId { get; set; }
        [Required]
        //[ForeignKey("City2")]
        public string AssignedCityId { get; set; }
        [Required]
        //[ForeignKey("Company2")]
        public string AssignedCompanyId { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? OtherPhoneNumber { get; set; }
        public string? LandLineNumber { get; set; }
        [Required]
        public int PatientNumber { get; set; }
        
        
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }


        public string CallTypeId { get; set; }
        public string CallAboutId { get; set; }
        public string CallServiceId { get; set; }





        [Required]
        //[ForeignKey("Hospital2")]
        public string? AssignedHospitalId { get; set; }

        public string? MajorSpecialistId { get; set; }

        public string? MinorSpecialistId { get; set; }

        public string? VerySpecificSpecialistId { get; set; }

        public string DoctorId { get; set; }

  


        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
    }
}
