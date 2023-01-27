using FieryRestaurent.Entity.Entity;
using FieryRestaurent.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Entity.DtoModels
{
    public class SupplierDto
    {

        public Guid SupplierID { get; set; }
        public string? SupplierName { get; set; }
        public bool Is_Active { get; set; }
        public int BuisnessID { get; set; }
        public Buisness? Buisness { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }


    }
}
