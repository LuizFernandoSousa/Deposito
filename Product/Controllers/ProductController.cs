using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Product.Data;
using Product.Data.Dtos;
using Product.Model;



namespace Product.Controllers;

[ApiController]
[Route("Product")]
public class ProductController : ControllerBase
{
    private ProductDbContext _dbContextProduct;
    private IMapper _mapper;

    public ProductController(IMapper mapper, ProductDbContext dbContextProduct)
    {
        _mapper = mapper;
        _dbContextProduct = dbContextProduct;
    }



    [HttpPost ("CreateProduct")]
    public IActionResult CreateProdutc(CreateProductDto dto)
    {
        Products product = _mapper.Map<Products>(dto);
        _dbContextProduct.Products.Add(product);
        _dbContextProduct.SaveChanges();

        return Ok($"Produto {dto.Name}");

    }


    [HttpGet ("GetAllProduct")]
    public IEnumerable<Products> GetAllProducts(int skip = 0, int take = 50) 
    {
        return _dbContextProduct.Products.Skip(skip).Take(take).ToList();
    
    }

    [HttpGet ("GetProductById")]
    public IActionResult GetProductById(int id)
    {
        var productSelect = _dbContextProduct.Products
            .FirstOrDefault(product => product.Id == id);
        if (productSelect == null)
        {
            return NotFound();
        }            
        return Ok(productSelect);          
    }

    [HttpGet("GetAmoutProduct")]
    public IActionResult GetAmout(int id)
    {
        var select = _dbContextProduct.Products
            .FirstOrDefault (product => product.Id == id);
        if(select == null) return NotFound();

        var productDto = _mapper.Map<ReadAmoutProdutcDto>(select);

        return Ok(productDto);
    }





}
