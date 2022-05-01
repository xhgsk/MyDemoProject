using Demo.Service.Interface;
using Demo.Service.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Controllers
{
    [Authorize]
    public class GoalController : Controller
    {
        private readonly IGoalService _goalService;
        private readonly ILogger<GoalController> _logger;
        private const int pageSzie = 10;
        public GoalController(IGoalService goalService, ILogger<GoalController> logger)
        {
            _goalService = goalService;
            _logger = logger;
        }
        // GET: GoalController
        public async Task<ActionResult> Index(string clientId, int? pageNumber)
        {
            if (string.IsNullOrEmpty(clientId))
            {
                return NotFound();
            }

            try
            {
                var goals = await _goalService.FindGoalsByClient(clientId, pageNumber, pageSzie);
                return View(goals);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Goal List Error");
                throw;
            }

        }

        // GET: GoalController/Details/GUID
        public ActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            try
            {
                var goal = _goalService.GetGoalById(id);
                return View(goal);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Goal List Error");
                return View(new GoalViewModel());
            }
        }

        // GET: GoalController/Create
        public ActionResult Create(string clientId)
        {
            if (string.IsNullOrEmpty(clientId))
            {
                return NotFound();
            }

            return View(new GoalViewModel() { ClientId = clientId });
        }

        // POST: GoalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(string clientId, [Bind("Title,Details,ClientId")] GoalViewModel model)
        {
            try
            {
                if (clientId != model.ClientId || string.IsNullOrEmpty(clientId))
                {
                    return NotFound();
                }

                await _goalService.CreateGoal(model);
                return RedirectToAction(nameof(Index), new { clientId = model.ClientId });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Create Goal Error");
                return RedirectToAction(nameof(Index), new { clientId = model.ClientId });
            }
        }

        // GET: GoalController/Edit/Guid
        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            try
            {
                var goal = _goalService.GetGoalById(id);
                return View(goal);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Edit Goal Error");
                return RedirectToAction(nameof(Details), new { id = id });
            }

        }

        // POST: GoalController/Edit/GUID
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, [Bind("Id,Title,Details,ClientId")] GoalViewModel model)
        {

            if (id != model.Id || string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _goalService.UpdateGoal(model);
                    return RedirectToAction(nameof(Details), new { id = id });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Edit Goal Error");
                }

            }
            return View(model);
        }
    }
}
