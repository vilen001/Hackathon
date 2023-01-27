using FieryRestaurent.Dal.DataBase;
using FieryRestaurent.Entity.Entity;
using FieryRestaurent.Entity.Repository;
using FieryRestaurent.Exceptions.CustomExceptions;
using FieryRestaurent.LoggingService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Dal.RepositoryImpl
{
    public class SupplierRepositoryImpl : ISupplierRepository
    {
           
        public readonly SupplierDbContext DbContext;
        private readonly ILoggerManager _logger;

        public SupplierRepositoryImpl(SupplierDbContext DbContext, ILoggerManager _logger)
        {
            this.DbContext = DbContext;
            this._logger = _logger;
        }
        public bool Post(Supplier Supplier)
        {
            try
            {
                _logger.LogInfo("Supplier Data added to repository.......");
                DbContext.Suppliers.Add(Supplier);
                DbContext.SaveChanges();
                return true;
            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Supplier> Get()
        {
            try
            {
                _logger.LogInfo("Supplier Data Fetched from Database and returned to Service.......");

                List<Supplier> suppliers = DbContext.Suppliers.Include("Address").Include("Buisness").ToList();
                return DbContext.Suppliers.ToList();
           
            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public Supplier Get(Guid SupplierID)
        {
            try
            {
                _logger.LogInfo("Supplier Data  By Supplier_ID is Fetched from Database and returned to Service.......");

                return DbContext.Suppliers.Where(x => x.SupplierID == SupplierID).First();
            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
