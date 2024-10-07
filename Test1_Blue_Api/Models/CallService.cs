using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Test1_Blue_Api.Models
{


    public class CallService : SoftDeleteCommen
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [ForeignKey("CallAbout")]
        public int CallAboutId { get; set; }
        public CallAbout CallAbout { get; set; }
       // public bool IsActive { get; set; } = true; // Default to true
    }

}
