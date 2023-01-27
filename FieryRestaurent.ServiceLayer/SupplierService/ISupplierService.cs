using FieryRestaurent.Entity.DtoModels;
using FieryRestaurent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.ServiceLayer.SupplierService
{
    public interface ISupplierService
    {
        public Supplier Post(SupplierDto SupplierDto);
        public List<SupplierDto> Get();
        public SupplierDto Get(Guid SupplierID);
    }
}
