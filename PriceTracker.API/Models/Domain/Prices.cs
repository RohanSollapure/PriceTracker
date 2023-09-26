using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceTracker.API.Models.Domain
{
    public class Prices
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set; } = "Name of Vegetable, Fruit, Flower";
        public int Price { get; set; }
        public DateTime Date { get; set; } = new DateTime(2022, 1, 1);
        public int  CID { get; set; }
        public int DID { get; set; }

        [ForeignKey("CID")]
        public virtual Categories Categories { get; set; }

        [ForeignKey("DID")]
        public virtual Districts Districts { get; set; }

    }
}
