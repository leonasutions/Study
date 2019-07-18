using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using fix.Dtos;
using fix.Models;

namespace fix.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customers, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customers>();
        }
    }
}