using Sabujcha.Models;
using System.Collections.Generic;

namespace Sabujcha.ViewModels
{
    public class FooterVM
    {
        public List<FooterContent> FooterContents { get; set; }
        public List<FooterTitles> FooterTitles { get; set; }
        public FooterContact FooterContact { get; set; }

    }
}
