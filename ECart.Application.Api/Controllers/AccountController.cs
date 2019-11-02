using ECart.Application.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECart.Application.Api.Controllers
{
    [Route("api/account")]
    public class AccountController : Controller
    {
        private readonly ILoginService _IloginService;
        public AccountController(ILoginService iLoginService)
        {
           _IloginService = iLoginService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string userName, string password)
        {
            try
            {
                return Ok(_IloginService.GetToken(userName, password));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}