using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselSayfam.Models
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }      
        public string Title { get; set; }       
        public string SubTitle { get; set; }    
        public string Date { get; set; }        
        public string Description { get; set; } 
    }

}