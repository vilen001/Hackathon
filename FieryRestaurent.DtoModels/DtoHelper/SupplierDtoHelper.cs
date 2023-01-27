using AutoMapper;
using FieryRestaurent.Entity.DtoModels;
using FieryRestaurent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.Mapping.DtoHelper
{
    public class SupplierDtoHelper : Profile
    {
        public SupplierDtoHelper()
        {
            CreateMap<Supplier, SupplierDto>();
            CreateMap<Buisness, SupplierBuisnessDto>();
            CreateMap<Address, SupplierAddressDto>();
        }
    }
}
