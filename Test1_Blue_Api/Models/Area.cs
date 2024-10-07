using System.ComponentModel.DataAnnotations.Schema;

namespace Test1_Blue_Api.Models
{
    public class Area : SoftDeleteCommen
    {
        public int Id { get; set; }
        public string Name { get; set; }



        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }




    }
}
