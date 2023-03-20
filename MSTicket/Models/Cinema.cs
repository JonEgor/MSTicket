using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using MSTicket.Data.Base;

namespace MTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        
        public int Id { get; set; }
        [Display(Name= "Cinema Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string Logo { get; set; }
      
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        public string Name { get; set; }
       
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema Description is required")]
        public string Description { get; set; }

        //Relationships ( Отношения )
        public List <Movie> Movies { get; set; } 

    }
}
