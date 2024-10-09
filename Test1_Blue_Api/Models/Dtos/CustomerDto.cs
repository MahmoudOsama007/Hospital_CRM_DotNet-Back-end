namespace Test1_Blue_Api.Models.Dtos
{
    public class CustomerDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int AreaId { get; set; }
        public int CityId { get; set; }
        public int CompanyId { get; set; }
        public string PhoneNumber { get; set; }
        public string? OtherPhoneNumber { get; set; }
        public string? LandLineNumber { get; set; }
        public int PatientNumber { get; set; }
       // public ICollection<Ticket> Ticket { get; set; }

    }
}
