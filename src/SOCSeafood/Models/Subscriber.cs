using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOCSeafood.Models
{
    [Table("Subscribers")]
    public class Subscriber
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        public string Name { get; set; }
    }
}
