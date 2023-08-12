namespace Sabujcha.Models
{
    public class CatagoryNames
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HeaderCatagorys HeaderCatagorys { get; set; }
        public int? HeaderCatagorysId { get; set; }

    }
}
