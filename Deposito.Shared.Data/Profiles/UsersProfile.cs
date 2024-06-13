using AutoMapper;
using Deposito.Shared.Data.Data.Dtos.Users;
using Deposito.Shared.Models.Model.Users;

namespace Deposito.Shared.Data.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<CreateUsersDto, Users>();

            CreateMap<Users, ReadUsersDto>();
            CreateMap<ReadUsersDto,Users>();
        }


    }
}
