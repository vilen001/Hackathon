using FieryRestaurent.Dal.RepositoryImpl;
using FieryRestaurent.Entity.Entity;
using FieryRestaurent.Exceptions.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class SupplierServiceImpl 
    {
        public SupplierRepositoryImpl _ServiceRespo;
        public SupplierServiceImpl(SupplierRepositoryImpl _ServiceRespo)
        {
            this._ServiceRespo = _ServiceRespo;
        }

        public bool AddSuplier(Supplier supplier)
        {
            _ServiceRespo.AddSupplier(supplier);
            DateTime expirationDate = DateTime.Now.AddYears(10);
            DateTime now = DateTime.Now;

            TimeSpan diff = expirationDate - now;

            int years = (diff.Days) / 365;
            try
            {
                if (diff.TotalDays >= 3653)
                {
                    throw new LicienseExpiredException("Your License is Expired!!");
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Supplier> GetAllSuppliers()
        {

            return _ServiceRespo.GetAllSuppliers();
        }

        public Supplier GetSupplierByID(Guid SupplierID)
        {
            return _ServiceRespo.GetSupplierByID(SupplierID);
        }

    }
}

