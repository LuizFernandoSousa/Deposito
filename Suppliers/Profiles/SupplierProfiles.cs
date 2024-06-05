using AutoMapper;
using Client.Data.Dtos;
using Client.Model;


namespace Client.Profiles
{
    public class SupplierProfiles : Profile
    {
        public SupplierProfiles()
        {
            CreateMap<CreateSupplierDtos, Supplier>();

        }



    }
}
