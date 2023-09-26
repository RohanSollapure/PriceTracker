using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceTracker.API.Models.Domain
{
    public class Districts
    {
        [Key]
        public int ID { get; set; }
        public String DistrictName { get; set; } = "District_Name";

        public int StateID { get; set; }

        [ForeignKey("StateID")]
        public virtual States State { get; set; }
    }
}
