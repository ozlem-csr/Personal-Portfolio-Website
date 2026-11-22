using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselSayfam.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }        
        public string Description { get; set; }  
        public string ImageUrl { get; set; }     
    }

}