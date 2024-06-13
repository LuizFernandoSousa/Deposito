using AutoMapper;
using Deposito.Shared.Data.Data.Dtos.Users;
using Deposito.Shared.Models.Model.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Deposito.Shared.Data.Services
{
    public class UserServices
    {
        private IMapper _mapper;
        private UserManager<Users> _userManager;
        private SignInManager<Users> _signInManager;
        private TokenService _tokenService;

        public UserServices(UserManager<Users> userManager, IMapper mapper, SignInManager<Users> signInManager, TokenService tokenService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

       
        public async Task RegisterAsync(CreateUsersDto dto)
        {
            Users user = _mapper.Map<Users>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Fail to create a user");
            }

        }

        public async Task<string> Login(LoginUsersDto dto)
        {
            var result = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

            if (!result.Succeeded)
            {
                throw new ApplicationException("User not autenticated");
            }

            var user = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(user => user.NormalizedUserName == dto.Username.ToUpper());

            var token = _tokenService.GenerateToken(user);

            return token;


        }
    }
}
