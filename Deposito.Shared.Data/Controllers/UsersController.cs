using AutoMapper;
using Deposito.Shared.Data.Data.DbContexts;
using Deposito.Shared.Data.Data.Dtos.Users;
using Deposito.Shared.Data.Services;
using Deposito.Shared.Models.Model.Users;
using Microsoft.AspNetCore.Mvc;

namespace Deposito.Shared.Data.Controllers
{
    [ApiController]
    [Route("Users")]// Aqui você decide o endereço da classe de controler, exemplo: https:/localhost:7082/users
    public class UsersController : ControllerBase
    {

        private UserServices _usersService;
        private UsersDbContext _usersDbContext;
        private IMapper _mapper;

        public UsersController(UserServices registerService, UsersDbContext usersDbContext, IMapper mapper)
        {
            _usersService = registerService;
            _usersDbContext = usersDbContext;
            _mapper = mapper;
        }

        [HttpGet ("GetAllUsers")]
        public IActionResult AllUsers(int skip = 0, int take = 50) 
        {
            var users = _usersDbContext.Users.ToList();
            return Ok(users);
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
            string token = await _usersService.Login(dto);
           
            return Ok(token);
        }

    }
}
