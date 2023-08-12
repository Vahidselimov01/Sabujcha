namespace Sabujcha.Models
{
    public class FooterContent
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
    public FooterTitles Titles { get; set; }
        public int? TitlesId { get; set; }

    }
}
