using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Zadatak.Dtos;
using Zadatak.Models;

namespace Zadatak.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Category, CategoryDto>();


            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            //Mapper.CreateMap<CarDto, Car>()
            //    .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}