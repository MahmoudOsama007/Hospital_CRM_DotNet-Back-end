namespace Test1_Blue_Api.Models
{
    public class SoftDeleteCommen 
    {
        public DateTime? DeleteAt { get; set; } = null;
        public bool IsDeleted { get; set; } = false;
        public DateTime? UpdateAt { get; set; } = null;
        public bool IsActive { get; set; } = true; // Default to true
    }

}
