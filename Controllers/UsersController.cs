using asp.net_core_demo.Dto;
using asp.net_core_demo.Services;
using asp.net_core_demo.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace asp.net_core_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        // about logger https://docs.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line
        private readonly ILogger<UsersController> _logger;
        private readonly UserService _userService;

        public UsersController(ILogger<UsersController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        // http://localhost:5000/users/all
        [HttpGet("all")]
        public async Task<List<UserBasicDTO>> GetAllUsersAsync()
        {
            return await _userService.GetAll();
        }

        //http://localhost:5000/users/add
        [HttpPost("add")]
        public async Task AddUser([FromBody] UserRegisterDTO userRegisterDTO)
        {
            var userValidator = new UserValidator();
            var results = userValidator.Validate(userRegisterDTO);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    _logger.LogInformation("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
                return;
            }
            await _userService.AddUser(userRegisterDTO);
            _logger.LogInformation("new user added");
        }
    }
}
