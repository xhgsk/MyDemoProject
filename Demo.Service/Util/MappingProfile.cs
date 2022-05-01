using AutoMapper;
using Demo.Domain.Models;
using Demo.Service.ViewModels;

namespace Demo.Service.Util
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<PaginatedList<Client>, ClientsPageViewModel>();
            CreateMap<Goal, GoalViewModel>();
            CreateMap<GoalViewModel, Goal>();
            CreateMap<PaginatedList<Goal>, GoalsPageViewModel>();
        }
    }
}
