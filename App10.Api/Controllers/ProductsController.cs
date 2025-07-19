using App10.Api.Data;
using App10.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace App10.Api.Controllers
{
    [Route("api/products")]
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly ApiResponse _apiResponse;

        public ProductsController(ApplicationDbContext db)
        {
            _db = db;
            _apiResponse = new();
        }

        [HttpGet]
        public IActionResult Get()
        {
            _apiResponse.Result = _db.Products.ToList();
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }

        [HttpGet("{id:int}", Name ="GetProduct")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
            {
                _apiResponse.IsSuccessful = false;
                _apiResponse.Errors.Add("Invalid ID.");
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_apiResponse);
            }
            var product = _db.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                _apiResponse.IsSuccessful = false;
                _apiResponse.Errors.Add("Item not found.");
                _apiResponse.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_apiResponse);
            }
            _apiResponse.Result = product;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }
    }
}
