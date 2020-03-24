using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<IActionResult> AddAttachment(AttachmentDTO attachment)
        {
            await _attachment.AddAttachment(attachment);
            return Ok();
        }
    }
}