using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DapperTesting.WebApp.Controllers
{
    public class AttachmentController : Controller
    {
        private readonly IAttachment _attachment;
        public AttachmentController(IAttachment attachment)
        {
            _attachment = attachment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddAttachment(AttachmentDTO attachment, IFormFile files)
        {
            var i = await _attachment.AddAttachment(attachment);
            return Ok(i);
        }
    }
}