using ECart.Application.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECart.Application.Api.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly ICartItemService _ICartItemService;
        public ProductController(ICartItemService iCartItemService)
        {
            _ICartItemService = iCartItemService;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetCartItems()
        {
            try
            {
                return Ok(_ICartItemService.GetItems());
            }
            catch (Exception ex)
            {
                Console.Write("Hi");
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}