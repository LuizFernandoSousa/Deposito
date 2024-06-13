using AutoMapper;
using Deposito.Shared.Data.Data.Dtos.Client;
using Deposito.Shared.Data.Data.Dtos.Proxduct;
using Deposito.Shared.Models.Model.Client;

namespace Deposito.Shared.Data.Profiles
{
    public class ClientProfiles : Profile
    {
        public ClientProfiles()
        {
            CreateMap<CreateClientsDto, Clients>();

            CreateMap<ReadProductDto, Clients>();

        }



    }
}
