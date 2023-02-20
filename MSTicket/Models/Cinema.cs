using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MTickets.Models
{
    public class Cinema
    {
        [Key]
        
        public int Id { get; set; }
        [Display(Name= "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships ( Отношения )
        public List <Movie> Movies { get; set; } 

    }
}
