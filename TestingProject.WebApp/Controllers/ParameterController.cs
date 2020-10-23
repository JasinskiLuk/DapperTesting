using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.WebApp.Controllers
{
    public class ParameterController : Controller
    {
        private readonly IParameterService _parameterService;
        public ParameterController(IParameterService parameterService)
        {
            _parameterService = parameterService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Get()
        {
            IEnumerable<ParameterDTO> parameters = Enumerable.Empty<ParameterDTO>();

            parameters = await _parameterService.Get();

            return Json(parameters);
        }
    }
}
