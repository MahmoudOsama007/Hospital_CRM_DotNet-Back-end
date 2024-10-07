namespace Test1_Blue_Api.Models.Dtos
{
    public class MajorSpecialistDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HospitalId { get; set; }  // Foreign key to Hospital
       // public List<MinorSpecialistDto> MinorSpecialists { get; set; } = new List<MinorSpecialistDto>();
    }

}
