using AutoMapper;
using FieryRestaurent.Entity.DtoModels;
using FieryRestaurent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurent.ServiceLayer.Mapping
{
    public class SupplierDtoHelper : Profile
    {
        public SupplierDtoHelper()
        {
            CreateMap<Supplier, SupplierDto>().ReverseMap();
            CreateMap<Buisness, SupplierBuisnessDto>().ReverseMap();
            CreateMap<Address, SupplierAddressDto>().ReverseMap();
        }
    }
}
