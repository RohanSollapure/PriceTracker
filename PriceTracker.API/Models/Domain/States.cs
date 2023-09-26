using System.ComponentModel.DataAnnotations;

namespace PriceTracker.API.Models.Domain
{
    public class States
    {
        [Key]
        public int ID { get; set; }
        public String StateName { get; set; } = "State_Name";

    }
}
