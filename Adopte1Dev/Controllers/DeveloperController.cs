using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adopte1Dev.BLL.Entities;
using Adopte1Dev.ASP.Handlers;
using Adopte1Dev.ASP.Models;
using Adopte1Dev.Common.Repositories;

namespace Adopte1Dev.ASP.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly IDeveloperRepository<Developer> _developerService;
        public DeveloperController(IDeveloperRepository<Developer> developerService)
        {
            _developerService = developerService;
        }
        public IActionResult Index()
        {
            IEnumerable<DeveloperListItem> model = _developerService.Get().Select(c => c.ToListItem());
            return View(model);
        }

        public IActionResult Details(int id)
        {
            DeveloperDetails model = _developerService.Get(id).ToDetails();
            return View(model);
        }

    }
}
