using System.Collections.Generic;

namespace Sabujcha.Models
{
    public class HeaderCatagorys
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CatagoryNames>CatagoryNames { get; set; }

    }
}
