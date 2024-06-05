using AutoMapper;
using DepositoDeBebidas.Data.Dtos;
using DepositoDeBebidas.Model;

namespace DepositoDeBebidas.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<CreateUsersDto, Users>();
        }

       
    }
}
