using System;
using System.ComponentModel.DataAnnotations;

namespace Sabujcha.Models
{
    public class ContactUs
    {
        public int Id { get; set; } 

     
        public string ContacUserName { get; set; }

     
        public string ContactEmail { get; set; }

       
        public string ContactSubject { get; set; }
        
        public string ContactMessage { get; set; }
        public DateTime Date { get; set; }
   
    }
}
