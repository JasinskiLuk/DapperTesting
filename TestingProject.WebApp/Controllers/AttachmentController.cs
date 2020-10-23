using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.WebApp.Controllers
{
    public class AttachmentController : Controller
    {
        private readonly IAttachmentService _attachment;
        private readonly IConfiguration _configuration;
        public AttachmentController(IAttachmentService attachment, IConfiguration configuration)
        {
            _attachment = attachment;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddFile(IFormFile files)
        {
            string path = _configuration.GetConnectionString("Path") + files.FileName;
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await files.CopyToAsync(stream);
            }
            return Ok();
        }

        public async Task<IActionResult> Create(AttachmentDTO attachment)
        {
            var Id = await _attachment.Create(attachment);
            return Ok(Id);
        }
    }
}