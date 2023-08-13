using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabujcha.Models
{
    public class Products
    {
        public int Id { get; set; }
        [MinLength(3),MaxLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUlr { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal? OldPrice { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal? NewPrice { get; set; }
        public int? Rate { get; set; }   
        public List<ProductsIcons> ProductIcons { get; set; }
        [NotMapped]
        public IFormFile FormImage { get; set; }



    }
}
