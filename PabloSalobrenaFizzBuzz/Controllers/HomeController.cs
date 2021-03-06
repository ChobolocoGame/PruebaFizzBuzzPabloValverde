﻿using System.Web.Mvc;
using FizzBuzz.Services;
using FizzBuzz.ViewModel.Home;

namespace FizzBuzz.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public HomeController()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        public HomeController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        public ActionResult Index()
        {
            return View();
        }
        /*mandando el formulario por el método POST*/
        [HttpPost]
        public ActionResult Index(IndexViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Result = null;
                return View(viewModel);
            };

            viewModel.Result = _fizzBuzzService.Check(viewModel.Number.Value);

            return View(viewModel);
        }
    }
}
