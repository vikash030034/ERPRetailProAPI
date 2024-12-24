using Data;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Models.DTO;
using Models.InputModels;
using Models.ViewModels;
using Services;
using Services.Interfaces.User;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRetailProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UsersController : ControllerBase
    {
        private readonly ERPRetailProDbContext _context;
        private readonly ITokenManager _tokenManager;
        private readonly IUserService _userService;

        public UsersController(ERPRetailProDbContext context, ITokenManager tokenManager,
              IUserService userService)
        {
            _context = context;
            _tokenManager = tokenManager;
            _userService = userService;

        }

        [Authorize]
        [HttpGet("GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllUsers()
        {

            var res = await _userService.GetAllUsersList();
            return Ok(res);
        }
     

        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginInputModel model)
        {

            var user = await _userService.FindByUserAsync(model.UserId);
            if (user != null &&  _userService.CheckUserPasswordAsync(user, model.Password))
            {
                var token = await _tokenManager.GenerateUserTokenAsync(user);
                return Ok(new
                {
                    token,
                    userId = user.Abbr,
                    name = user.UName,
                });
            }

            return Unauthorized();
        }

    }


}
