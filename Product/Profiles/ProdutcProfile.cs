using AutoMapper;
using Product.Data.Dtos;
using Product.Model;

namespace Product.Profiles;

public class ProdutcProfile : Profile
{

    public ProdutcProfile()
    {
        CreateMap<CreateProductDto, Productsss>();

        
        CreateMap<ReadAmoutProdutcDto, Productsss>();
        CreateMap<Productsss, ReadAmoutProdutcDto>();



    }
}
