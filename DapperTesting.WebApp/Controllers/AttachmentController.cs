using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DapperTesting.WebApp.Controllers
{
    public class AttachmentController : Controller
    {
        private readonly IAttachment _attachment;
        private readonly IConfiguration _configuration;
        public AttachmentController(IAttachment attachment, IConfiguration configuration)
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
            string path = _configuration.GetConnectionString("Path")+files.FileName;
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await files.CopyToAsync(stream);
            }
            return Ok();
        }

        public async Task<IActionResult> AddAttachment(AttachmentDTO attachment)
        {
            var i = await _attachment.AddAttachment(attachment);
            return Ok(i);
        }
    }
}