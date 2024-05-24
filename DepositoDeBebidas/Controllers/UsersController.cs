using AutoMapper;
using DepositoDeBebidas.Data.Dtos;
using DepositoDeBebidas.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DepositoDeBebidas.Controllers
{
    [ApiController]
    [Route("[Controller]")]



    public class UsersController : ControllerBase
    {
        private IMapper _mapper;
        private UserManager<Users> _userManager;

        public UsersController(IMapper mapper, UserManager<Users> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsers(CreateUsersDto dto)
        {  
            Users user = _mapper.Map<Users>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (result.Succeeded)
            {
                return Ok("User create");
            }
            else
            {
                throw new ApplicationException("Fail to create a user");
            }

        }

       
    }
}
