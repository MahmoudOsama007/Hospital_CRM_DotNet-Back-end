namespace Test1_Blue_Api.Models.Dtos
{
    public class HospitalDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? ContactNumber { get; set; }
       // public List<MajorSpecialistDto> MajorSpecialists { get; set; } = new List<MajorSpecialistDto>();
    }

}
