using Demo.Service.ViewModels;
using System.Threading.Tasks;

namespace Demo.Service.Interface
{
    public interface IGoalService
    {
        Task<GoalsPageViewModel> FindGoalsByClient(string clientId, int? pageNumber, int pageSize);
        GoalViewModel GetGoalById(string goalId);
        Task UpdateGoal(GoalViewModel model);
        Task CreateGoal(GoalViewModel model);
    }
}
