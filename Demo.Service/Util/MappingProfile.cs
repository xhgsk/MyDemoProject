using AutoMapper;
using Demo.Domain.Models;
using Demo.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Service.Util
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<PaginatedList<Client>, ClientsPageViewModel>();
        }
    }
}
