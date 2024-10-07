namespace Test1_Blue_Api.Models.Dtos
{
    public class VerySpecificSpecialistDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinorSpecialistId { get; set; }  // Foreign key to MinorSpecialist
       // public List<DoctorDto> Doctors { get; set; } = new List<DoctorDto>();
    }

}
