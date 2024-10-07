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
        // Address details
        [DataType("nvarchar(max)")]
        public string? Address { get; set; }
        // ID of the assigned area
        [Required]
        public string AssignedAreaId { get; set; }
        // ID of the assigned city
        [Required]
        public string AssignedCityId { get; set; }
        // ID of the assigned company
        [Required]
        public string AssignedCompanyId { get; set; }
        // Phone numbers
        [Required]
        public string PhoneNumber { get; set; }
        public string? OtherPhoneNumber { get; set; }
        public string? LandLineNumber { get; set; }
        // Patient number
        [Required]
        public int PatientNumber { get; set; }

        public int? CustomerId{ get; set; }


        public string CallTypeId { get; set; }
        public string CallAboutId { get; set; }
        public string CallServiceId { get; set; }



        // ID of the assigned hospital
        [Required]
        public string? AssignedHospitalId { get; set; }
        // IDs for specialists
        public string? MajorSpecialistId { get; set; }
        public string? MinorSpecialistId { get; set; }
        public string? VerySpecificSpecialistId { get; set; }
        // ID of the assigned doctor
        public string DoctorId { get; set; }





        // Date of creation and modification
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
