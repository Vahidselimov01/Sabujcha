﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabujcha.Models
{
    public class AboutUsArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Signature { get; set; }
        [NotMapped]
        public FormFile FormFile { get; set; }
        [NotMapped]
        public FormFile FormFile2 { get; set; }
    }
}
