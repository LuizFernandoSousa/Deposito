using AutoMapper;
using Product.Data.Dtos;
using Product.Model;

namespace Product.Profiles
{
    public class ProdutcProfile : Profile
    {

        public ProdutcProfile()
        {
            CreateMap<CreateProductDto, Products>();

            
            CreateMap<ReadAmoutProdutcDto, Products>();
            CreateMap<Products, ReadAmoutProdutcDto>();



        }
    }
}
