using App10.Api.Data;
using App10.Api.Dtos;
using App10.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace App10.Api.Controllers
{
    [Route("api/products")]
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _env;
        private readonly ApiResponse _response;

        public ProductsController(ApplicationDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _response.Result = await _db.Products.ToListAsync();
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        [HttpGet("{id:int}", Name = "GetItem")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                _response.IsSuccessful = false;
                _response.Errors.Add("Invalid ID.");
                _response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }
            var model = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (model == null)
            {
                _response.IsSuccessful = false;
                _response.Errors.Add("Item not found.");
                _response.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_response);
            }
            _response.Result = model;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] ProductCreateDto dto) //fromform for the image
        {
            try
            {
                if (dto == null || string.IsNullOrEmpty(dto.Name) || dto.Price <= 0)
                {
                    _response.IsSuccessful = false;
                    _response.Errors.Add("Invalid data.");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                if (ModelState.IsValid == false)
                {
                    _response.IsSuccessful = false;
                    _response.Errors.Add("Invalid model state.");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                //image file validation
                if (dto.File == null || dto.File.Length == 0) //!!!file type check can be added here
                {
                    _response.IsSuccessful = false;
                    _response.Errors.Add("Image file is required.");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                if (dto.File.Length > 2 * 1024 * 1024) //2MB limit
                {
                    _response.IsSuccessful = false;
                    _response.Errors.Add("Image file size exceeds the limit of 2MB.");
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var imagesPath = Path.Combine(_env.WebRootPath, "images");
                if (!Directory.Exists(imagesPath))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                var filePath = Path.Combine(imagesPath, dto.File.FileName);
                //delete file if exists
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }

                //upload file
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await dto.File.CopyToAsync(stream);
                }

                var model = new Product
                {
                    Name = dto.Name,
                    Category = dto.Category,
                    Price = dto.Price,
                    Tag = dto.Tag,
                    Description = dto.Description,
                    Image = $"images/{dto.File.FileName}" //relative path
                };

                await _db.Products.AddAsync(model);
                await _db.SaveChangesAsync();

                _response.Result = dto;
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetItem", new { id = model.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Errors.Add(ex.Message);
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            // Log the exception (optional)
            return BadRequest(_response);

        }
    }
}
