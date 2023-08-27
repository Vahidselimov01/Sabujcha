using Sabujcha.Models;
using System.Collections.Generic;

namespace Sabujcha.ViewModels
{
    public class HomeViewModels
    {
        public List<Products>products { get; set; }
        public List<ProductsIcons>productsIcons { get; set; }
		public List<ContactUs> Contacts { get; set; }
		public ContactUs contactUs { get; set; }
	}
}
