using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Desc { get; set; }
        public string Img { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        public double PriceSale { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

    }
}
