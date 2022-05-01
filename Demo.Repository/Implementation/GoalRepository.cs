using Demo.Domain.Data;
using Demo.Domain.Models;
using Demo.Repository.Interface;

namespace Demo.Repository.Implementation
{
    public class GoalRepository : BaseRepository<Goal>, IGoalRepository
    {
        public GoalRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
