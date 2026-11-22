using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselSayfam.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }       
        public string Surname { get; set; }       
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }

}
