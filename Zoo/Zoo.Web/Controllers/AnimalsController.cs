using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using Zoo.Web.Services;
using Zoo.Web.ViewModels.Home;

namespace Zoo.Web.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly IAnimalsService animalsService;

        public AnimalsController(IAnimalsService animalsService)
        {
            this.animalsService = animalsService;
        }

        public IActionResult Index()
        {
            var animals = this.animalsService.GetAll().ToList();

            var viewModel = new IndexViewModel
            {
                Animals = animals
            };

            return this.View(viewModel);
        }

        public IActionResult Feed()
        {
            this.animalsService.FeedAnimals();

            return this.RedirectToAction(nameof(Index));
        }

        public IActionResult Hunger()
        {
            this.animalsService.Hunger();

            return this.RedirectToAction(nameof(Index));
        }
    }
}
