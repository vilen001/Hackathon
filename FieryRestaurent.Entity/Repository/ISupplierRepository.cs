using FieryRestaurent.Entity.DtoModels;
using FieryRestaurent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Entity.Repository
{
    public interface ISupplierRepository 
    {
        bool Post(Supplier Supplier);
        Supplier Get(Guid SupplierID);
        List<Supplier> Get();
       
       // List<Supplier> GetSupplierByPagination();
    }
}
