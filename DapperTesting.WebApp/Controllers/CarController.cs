using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using System.Threading.Tasks;

namespace DapperTesting.WebApp.Controllers
{
    public class CarController : Controller
    {
        private readonly ICar _car;
        private readonly IDateTest _dateTest;
        public CarController(ICar car, IDateTest dateTest)
        {
            _car = car;
            _dateTest = dateTest;
        }
        public async Task<IActionResult> CarList()
        {
            return View(await _car.GetCars());
        }

        public async Task<IActionResult> AddEditCar(CarDTO model)
        {
            ViewData["DateList"] = await _dateTest.GetDate();
            ViewData["CarList"] = await _car.GetCars();
            ViewData["DateList2"] = new SelectList(await _dateTest.GetDate());
            return View(model);
        }
        public async Task<IActionResult> AddCar(CarDTO model)
        {
            await _car.AddCar(model);
            return RedirectToAction("CarList");
        }

        public async Task<IActionResult> DeleteCar(int Id)
        {
            await _car.DeleteCar(Id);
            return RedirectToAction("CarList");
        }

        public async Task<IActionResult> EditCar(CarDTO model)
        {
            await _car.EditCar(model);
            return RedirectToAction("CarList");
        }
    }
}