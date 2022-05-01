using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Service.ViewModels
{
    public class GoalViewModel
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
    }

    public class GoalsPageViewModel
    {
        public IEnumerable<GoalViewModel> Goals { get; set; }
        public string ClientId { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
