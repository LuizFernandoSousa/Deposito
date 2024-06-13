using AutoMapper;
using Deposito.Shared.Data.Data.Dtos.Suppliers;
using Deposito.Shared.Models.Model.Suppliers;


namespace Deposito.Shared.Data.Profiles
{
    public class SupplierProfiles : Profile
    {
        public SupplierProfiles()
        {
            CreateMap<CreateSupplierDtos, Supplier>();

            CreateMap<ReadSupplierDto, Supplier>();

        }



    }
}
