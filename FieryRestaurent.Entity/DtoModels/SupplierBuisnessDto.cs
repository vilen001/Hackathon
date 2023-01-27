using FieryRestaurent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Entity.DtoModels
{
    public class SupplierBuisnessDto
    {
        public string? BuisnessName { get; set; }
        public string? LicenseNumber { get; set; }
        public DateTime LicesnseDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
