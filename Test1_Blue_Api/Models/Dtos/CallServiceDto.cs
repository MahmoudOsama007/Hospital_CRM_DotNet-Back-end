namespace Test1_Blue_Api.Models.Dtos
{
    public class CallServiceDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CallAboutId { get; set; }
       // public bool IsActive { get; set; }

    }

}
