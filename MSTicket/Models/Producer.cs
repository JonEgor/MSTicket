using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }

        //Отношения (Relationships) 
        public List<Movie> Movies { get; set; }

    }


}
