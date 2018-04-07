using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using NewVidly.Dtos;
using NewVidly.Models;

namespace NewVidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Domain To DTO

            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<MovieGenre, MovieGenreDto>();

            #endregion

            #region DTO To Domain

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            #endregion

        }

    }
}