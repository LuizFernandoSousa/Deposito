
using DepositoDeBebidas.Model;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DepositoDeBebidas.Service
{
    public class TokenService
    {
        public string GenerateToken(Users users)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", users.UserName),
                new Claim("email", users.Email),
                new Claim("tel", users.PhoneNumber),
                new Claim("id", users.Id)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("9382y92ubnduidwhidusbcuiui2bdh8203d"));


            var signCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                    expires: DateTime.Now.AddMinutes(10),
                    claims: claims,
                    signingCredentials: signCredentials
                );


            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
