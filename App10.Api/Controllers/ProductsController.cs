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
    }
}
