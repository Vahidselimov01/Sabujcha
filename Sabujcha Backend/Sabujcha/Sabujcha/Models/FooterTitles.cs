using System.Collections.Generic;

namespace Sabujcha.Models
{
    public class FooterTitles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<FooterContent> FooterContents { get; set; }

    }
}
