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
        public string? CustomerName { get; set; }
        //[DataType("nvarchar(max)")]
        //public string? Address { get; set; }

        //[Required]
        //public string PhoneNumber { get; set; }
        //public string? OtherPhoneNumber { get; set; }
        //public string? LandLineNumber { get; set; }
        //[Required]
        //public int? PatientNumber { get; set; }
        
        
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }


        public int CallTypeId { get; set; }
        public int CallAboutId { get; set; }
        public int CallServiceId { get; set; }





        [Required]
        //[ForeignKey("Hospital2")]
        public int? AssignedHospitalId { get; set; }

        public int? MajorSpecialistId { get; set; }

        public int? MinorSpecialistId { get; set; }

        public int? VerySpecificSpecialistId { get; set; }

        public int DoctorId { get; set; }

        public int? TicketNumber { get; set; }


        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; } = DateTime.Now;
    }
}
