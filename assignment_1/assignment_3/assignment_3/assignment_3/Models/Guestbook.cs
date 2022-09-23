using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace assignment_3.Models
{
    public class Guestbook
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        [DisplayName("Title")]
        public string Title { get; set; }
        
        [Required]
        [StringLength(50)]
        [DisplayName("Message")]
        public string Message { get; set; }


    }
}