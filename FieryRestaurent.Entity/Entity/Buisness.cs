using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Entity.Entity
{
    public class Buisness
    {
        public int BuisnessID { get; set; }
        [Required]
        public string? BuisnessName { get; set; }
        [Required]
        public string? LicenseNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}",
                       ApplyFormatInEditMode = true)]
        public DateTime LicesnseDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}",
                       ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}",
                        ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }
        [Required]
        public string? LastModifiedBy { get; set; }
       

    }
}
