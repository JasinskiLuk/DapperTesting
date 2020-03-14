using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DapperTesting.WebApp.Controllers
{
    public class DateTestController : Controller
    {
        private readonly IDateTest _dateTest;
        public DateTestController(IDateTest dateTest)
        {
            _dateTest = dateTest;
        }

        public async Task<IActionResult> DateTest()
        {
            return View(await _dateTest.GetDate());
        }

        public IActionResult AddEditDate(DateTestDTO model)
        {
            return View(model);
        }
        public async Task<IActionResult> AddDate(DateTestDTO model)
        {
            await _dateTest.AddDate(model);
            return RedirectToAction("DateTest");
        }

        public async Task<IActionResult> DeleteDate(int Id)
        {
            await _dateTest.DeleteDate(Id);
            return RedirectToAction("DateTest");
        }

        public async Task<IActionResult> EditDate(DateTestDTO model)
        {
            await _dateTest.EditDate(model);
            return RedirectToAction("DateTest");
        }
    }
}
