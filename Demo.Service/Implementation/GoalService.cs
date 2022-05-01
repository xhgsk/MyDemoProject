using AutoMapper;
using Demo.Domain.Models;
using Demo.Repository.Interface;
using Demo.Service.Interface;
using Demo.Service.Util;
using Demo.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Service.Implementation
{
    public class GoalService : IGoalService
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public GoalService(IGoalRepository goalRepository, IMapper mapper)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
        }
        public async Task<GoalsPageViewModel> FindGoalsByClient(string clientId, int? pageNumber, int pageSize)
        {
            var pages = await PaginatedList<Goal>.CreateAsync(_goalRepository.Find(a => a.ClientId.ToString() == clientId), pageNumber ?? 1, pageSize);
            var model = _mapper.Map<GoalsPageViewModel>(pages);
            model.Goals = _mapper.Map<IEnumerable<GoalViewModel>>(pages);
            model.ClientId = clientId;
            return model;
        }

        public GoalViewModel GetGoalById(string goalId)
        {
            var goal = _goalRepository.GetById(goalId);
            var model = _mapper.Map<GoalViewModel>(goal);
            return model;
        }

        public async Task UpdateGoal(GoalViewModel model)
        {
            var goal = _goalRepository.GetById(model.Id);
            goal.Details = model.Details;
            goal.Title = model.Title;
            _goalRepository.Update(goal);
            await _goalRepository.Commit();
        }

        public async Task CreateGoal(GoalViewModel model)
        {
            var goal = _mapper.Map<Goal>(model);
            goal.DateCreated = DateTime.Now;
            _goalRepository.Add(goal);
            await _goalRepository.Commit();
        }

    }
}
