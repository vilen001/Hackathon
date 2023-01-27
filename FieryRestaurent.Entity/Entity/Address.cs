using FieryRestaurent.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Entity.Entity
{
    public class Address
    {
        [Required]
       public int AddressID { get; set; }
        [Required]
        public string? StreetAddress { get; set; }
        [Required]
        public City City { get; set; }
        [Required]
        public State State { get; set; }
        [Required]
        public Country Country { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public long Latitude { get; set; }
        [Required]
        public long Longitude { get; set; }   
     
    }
}
