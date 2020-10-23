using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.WebApp.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _car;
        private readonly IDateTestService _dateTest;
        public CarController(ICarService car, IDateTestService dateTest)
        {
            _car = car;
            _dateTest = dateTest;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _car.Get());
        }

        public async Task<IActionResult> AddEditCar(CarDTO model)
        {
            ViewData["DateList"] = await _dateTest.Get();
            ViewData["CarList"] = await _car.Get();
            ViewData["DateList2"] = new SelectList(await _dateTest.Get());
            return View(model);
        }
        public async Task<IActionResult> Create(CarDTO model)
        {
            await _car.Create(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(CarDTO model)
        {
            await _car.Update(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int Id)
        {
            await _car.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}