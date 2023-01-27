using FieryRestaurent.Entity.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieryRestaurent.Entity.Entity
{
    public class Supplier
    {
        
        public Guid SupplierID { get; set; }
        [Required]
        public string? SupplierName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public bool Is_Active { get; set; }
        public int BuisnessID { get; set; }
        [ForeignKey("BuisnessID")]
        public Buisness? Buisness { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address? Address { get; set; }

        public string generateID(Guid SupplierId)
        {
            long i = 1;

            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }

            string UniqueID_Format = String.Format("{ SU202300001}");

            return UniqueID_Format;
        }
    }
}