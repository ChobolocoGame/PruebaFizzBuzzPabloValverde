using System.Web.Mvc;
using FizzBuzz.Services;
using WebApplication2.ViewModels.Home;

namespace FizzBuzz.Controllers
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
        /*Enviamos el formulario vía POST*/
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
