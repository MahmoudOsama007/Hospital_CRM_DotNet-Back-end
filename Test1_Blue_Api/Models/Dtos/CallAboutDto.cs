namespace Test1_Blue_Api.Models.Dtos
{
    public class CallAboutDto : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CallTypeId { get; set; }
      //  public bool IsActive { get; set; }

    }

}
