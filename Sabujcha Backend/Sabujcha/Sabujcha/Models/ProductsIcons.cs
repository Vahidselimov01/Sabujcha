using System.Collections.Generic;
using System;

namespace Sabujcha.Models
{
    public class ProductsIcons
    {
        public int Id { get; set; }

        public string IconsName { get; set; }
        public Products products { get; set; }  
        public int ProductsId { get; set; }

       
    }
}
