using FieryRestaurent.Entity.Entity;
using FieryRestaurent.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Entity.DtoModels
{
    public class SupplierAddressDto
    { 
        public string? StreetAddress { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public int ZipCode { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
    }
}
