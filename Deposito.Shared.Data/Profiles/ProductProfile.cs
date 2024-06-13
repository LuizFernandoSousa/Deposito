using AutoMapper;
using Deposito.Shared.Data.Data.Dtos.Proxduct;
using Deposito.Shared.Models.Model.Product;

namespace Deposito.Shared.Data.Profiles;

public class ProductProfile : Profile
{

    public ProductProfile()
    {
        CreateMap<CreateProductDto, Product>();


        CreateMap<ReadAmoutProdutcDto, Product>();
        CreateMap<Product, ReadAmoutProdutcDto>();

        CreateMap<ReadProductDto, Product>();

    }
}
