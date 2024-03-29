﻿using Backend.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly CastlesAndNestAppDbContext _context;
        private readonly ILogger<FilesController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FilesController(CastlesAndNestAppDbContext context, ILogger<FilesController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("get");
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<string>>> Post()
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count == 0)
            {
                return BadRequest("No file was sent!");
            }
            var filesToUpload = HttpContext.Request.Form.Files;
            List<string> uniqueFileNames = null;

            if (filesToUpload != null)
            {
                uniqueFileNames = new List<string>();
                if (_webHostEnvironment.WebRootPath == null)
                {
                    var wrt = Directory.CreateDirectory(Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot"));
                    if (wrt != null)
                    {
                        Directory.CreateDirectory(Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot", "images"));
                    }
                    _webHostEnvironment.WebRootPath = Path.Combine(_webHostEnvironment.ContentRootPath, "wwwroot");
                }
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                foreach (var fileToUpload in filesToUpload)
                {
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + fileToUpload.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using var fileStream = new FileStream(filePath, FileMode.Create);
                    await fileToUpload.CopyToAsync(fileStream);
                    uniqueFileNames.Add(uniqueFileName);
                }
            }            
            return Ok(uniqueFileNames);
        }

        [HttpDelete("{filename}")]
        [Authorize]
        public void Delete(string filename)
        {
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            string filePath = Path.Combine(uploadsFolder, filename);
            System.IO.File.Delete(filePath);
        }
    }
}

