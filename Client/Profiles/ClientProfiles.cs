using AutoMapper;
using Client.Data.Dtos;
using Client.Model;


namespace Client.Profiles
{
    public class ClientProfiles : Profile
    {
        public ClientProfiles()
        {
            CreateMap<CreateClientsDtos, Clients>();

        }



    }
}
