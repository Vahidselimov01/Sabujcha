using System.Collections.Generic;

namespace Sabujcha.Models
{
    public class HeaderNav
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BasketIcon { get; set; }
        public List<NavDropName> DropNames { get; set; }

    }
}
