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
        private readonly ICategoriesRepository<Categories> _categoriesService;
        public DeveloperController(IDeveloperRepository<Developer> developerService, ICategoriesRepository<Categories> categoriesService)
        {
            _developerService = developerService;
            _categoriesService = categoriesService;
        }
        public IActionResult Index()
        {
            DeveloperIndex model = new DeveloperIndex();

            model.Developer = _developerService.Get().Select(c => c.ToListItem());
            model.Categories = _categoriesService.Get().Select(c => c.ToDetails());
            return View(model);

        }

        public IActionResult Details(int id)
        {
            DeveloperDetails model = _developerService.Get(id).ToDetails();
            model.CatePrincipal = (model.DevCategPrincipal is null)?null:_categoriesService.Get((int)model.DevCategPrincipal).ToDetails();
            return View(model);
        }

    }
}
