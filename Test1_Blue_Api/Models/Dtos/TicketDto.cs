using System;
using System.ComponentModel.DataAnnotations;

namespace Test1_Blue_Api.Models.Dtos
{
    public class TicketDto : SoftDeleteCommen
    {
        // Unique identifier for the ticket
        public int Id { get; set; }
        // Name of the Customer
        [Required]
        public string CustomerName { get; set; }
        //// Address details
        //[DataType("nvarchar(max)")]
        //public string? Address { get; set; }

        //// Phone numbers
        //[Required]
        //public string? PhoneNumber { get; set; }
        //public string? OtherPhoneNumber { get; set; }
        //public string? LandLineNumber { get; set; }
        //// Patient number
        //[Required]
        //public int? PatientNumber { get; set; }
        
        public int? CustomerId{ get; set; }
     

        public int CallTypeId { get; set; }
        public int CallAboutId { get; set; }
        public int CallServiceId { get; set; }



        // ID of the assigned hospital
        [Required]
        public int? AssignedHospitalId { get; set; }
        // IDs for specialists
        public int? MajorSpecialistId { get; set; }
        public int? MinorSpecialistId { get; set; }
        public int? VerySpecificSpecialistId { get; set; }
        // ID of the assigned doctor
        public int DoctorId { get; set; }


        public int? TicketNumber { get; set; }



        // Date of creation and modification
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
