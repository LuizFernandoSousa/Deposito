using AutoMapper;
using DepositoDeBebidas.Data.Dtos;
using DepositoDeBebidas.Model;
using DepositoDeBebidas.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DepositoDeBebidas.Controllers
{
    [ApiController]
    [Route("[Controller]")]// Aqui você decide o endereço da classe de controler, exemplo: https:/localhost:7082/users
    public class UsersController : ControllerBase
    {
        
        private UserServices _usersService;

        public UsersController(UserServices registerService)
        {
            _usersService = registerService;
        }

        [HttpPost("Register")]//https:/localhost:7082/users/Register
        public async Task<IActionResult> CreateUsers(CreateUsersDto dto)
        {  
            
            await _usersService.RegisterAsync(dto);
            return Ok("User create");
        }


        [HttpPost("Login")]//https:/localhost:7082/users/Login
        public async Task<IActionResult> Login(LoginUsersDto dto)
        {
            var token = await _usersService.Login(dto);
            return Ok(token);
        }
       
    }
}
