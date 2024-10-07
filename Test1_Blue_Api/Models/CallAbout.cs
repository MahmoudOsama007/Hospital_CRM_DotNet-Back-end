using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1_Blue_Api.Models
{
   
    public class CallAbout : SoftDeleteCommen
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [ForeignKey("CallType")]
        public int CallTypeId { get; set; }
        public CallType CallType { get; set; }
      //  public bool IsActive { get; set; } = true; // Default to true
    }

}
