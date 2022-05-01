using Demo.Repository.Interface;
using Demo.Service.Interface;

namespace Demo.Service.Implementation
{
    public class GoalService : IGoalService
    {
        private readonly IGoalRepository _goalRepository;
        public GoalService(IGoalRepository goalRepository)
        {
            _goalRepository = goalRepository;
        }

    }
}
