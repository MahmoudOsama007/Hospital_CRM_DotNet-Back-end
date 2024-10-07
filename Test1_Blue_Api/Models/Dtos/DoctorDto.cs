namespace Test1_Blue_Api.Models.Dtos
{
    public class DoctorDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualifications { get; set; }
        public string? ContactNumber { get; set; }
        //public int VerySpecificSpecialistId { get; set; }  // Foreign key to VerySpecificSpecialist


        public ICollection<Ticket> Ticket { get; set; }
    }

}
