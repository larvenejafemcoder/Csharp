using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street{ get; set; }
        public string City{ get; set; }
        public string State{ get; set; }
    }
}