using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.WebApp.Controllers
{
    public class DateTestController : Controller
    {
        private readonly IDateTestService _dateTest;
        public DateTestController(IDateTestService dateTest)
        {
            _dateTest = dateTest;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dateTest.Get());
        }

        public IActionResult AddEditDate(DateTestDTO model)
        {
            return View(model);
        }
        public async Task<IActionResult> AddDate(DateTestDTO model)
        {
            await _dateTest.Create(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditDate(DateTestDTO model)
        {
            await _dateTest.Update(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteDate(int Id)
        {
            await _dateTest.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
