using System.ComponentModel.DataAnnotations;

namespace PriceTracker.API.Models.Domain
{
    public class Categories
    {
        [Key]
        public int ID { get; set; }
        public String CategoryName { get; set; } = "Category_Name";
    }
}
