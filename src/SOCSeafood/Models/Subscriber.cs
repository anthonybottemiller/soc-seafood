using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOCSeafood.Models
{
    [Table("Customers")]
    public class Subscriber
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}
