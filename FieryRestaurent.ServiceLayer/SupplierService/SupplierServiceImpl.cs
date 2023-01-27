using AutoMapper;
using FieryRestaurent.Entity.DtoModels;
using FieryRestaurent.Entity.Entity;
using FieryRestaurent.Entity.Repository;
using FieryRestaurent.Exceptions.CustomExceptions;
using FieryRestaurent.LoggingService;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Reflection.Metadata.Ecma335;

namespace FieryRestaurent.ServiceLayer.SupplierService
{
    public class SupplierServiceImpl : ISupplierService
    {
        private readonly ISupplierRepository Srepo;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IMemoryCache memorycache;

        public SupplierServiceImpl(ISupplierRepository Srepo, ILoggerManager _logger, IMapper _mapper, IMemoryCache memorycache)
        {
            this.Srepo = Srepo;
            this._logger = _logger;
            this._mapper = _mapper;
            this.memorycache = memorycache;
        }

        public List<SupplierDto> Get()
        {
            try
            {
                List<Supplier> supplers;
                if (!memorycache.TryGetValue("Suppliers", out supplers))
                {
                    memorycache.Set("Suppliers", Srepo.Get());
                }

                _logger.LogInfo("Supplier Data returned...");

                List<Supplier> supplier = memorycache.Get("Suppliers") as List<Supplier>;
                List<SupplierDto> SupplierDto = _mapper.Map<List<Supplier>, List<SupplierDto>>(supplier);

                return SupplierDto;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public SupplierDto Get(Guid SupplierID)
        {
            try
            {
                _logger.LogInfo($"Su[[lier with {SupplierID} gets executed");
                Supplier supplier = Srepo.Get(SupplierID);
                SupplierDto supplier2 = _mapper.Map<Supplier, SupplierDto>(supplier);

                return supplier2;
            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public Supplier Post(SupplierDto SupplierDto)
        {
            try
            {
                Supplier supplier = _mapper.Map<SupplierDto, Supplier>(SupplierDto);

                _logger.LogInfo("Supplier Posted Successfully......");

                bool result = false;
                var now = DateTime.Today;
                int Licenseyear = (now.Year - SupplierDto.Buisness.LicesnseDate.Year - 1) +
                (((now.Month > SupplierDto.Buisness.LicesnseDate.Month) ||
                ((now.Month == SupplierDto.Buisness.LicesnseDate.Month) && (now.Day >= SupplierDto.Buisness.LicesnseDate.Day))) ? 1 : 0);
                if (Licenseyear >= 0)
                {
                    if ((Licenseyear <= 10))
                    {
                        SupplierDto.SupplierID = Guid.NewGuid();
                        SupplierDto.Buisness.DateCreated = DateTime.Now;
                        SupplierDto.Buisness.LastModifiedDate = DateTime.Now;
                        result = Srepo.Post(supplier);
                    }
                    else
                    {
                        throw new InvalidLicenseException("You License is expired");
                    }
                }
                  else
                  {
                    throw new InvalidLicenseException("Invalid Date Entered");
                  }
                  if (result != null) 
                  {
                    Srepo.Post(supplier);
                    return supplier;
                  }
                 else 
                  {
                    throw new InvalidLicenseException("Enter Valid Data");
                  }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

