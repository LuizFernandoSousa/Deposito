using AutoMapper;
using Deposito.Shared.Data.Data.DbContexts;
using Deposito.Shared.Data.Data.Dtos.Proxduct;
using Deposito.Shared.Models.Model.Product;
using Microsoft.AspNetCore.Mvc;



namespace Deposito.Shared.Data.Controllers;

[ApiController]
[Route("Product")]
public class ProductController : ControllerBase
{
    private DepositoDbContext _dbContextProduct;
    private IMapper _mapper;

    public ProductController(IMapper mapper, DepositoDbContext dbContextProduct)
    {
        _mapper = mapper;
        _dbContextProduct = dbContextProduct;
    }



    [HttpPost("CreateProduct")]
    public IActionResult CreateProdutc(CreateProductDto dtoProduct)
    {
        Product product = _mapper.Map<Product>(dtoProduct);
        _dbContextProduct.Products.Add(product);
        _dbContextProduct.SaveChanges();

        return Ok($"Produto {dtoProduct.Name}");

    }


    [HttpGet("GetAllProduct")]
    public IEnumerable<Product> GetAllProducts(int skip = 0, int take = 50)
    {
        return _dbContextProduct.Products.Skip(skip).Take(take).ToList();

    }

   

    [HttpDelete ("DeleteOneProduct")]
    public IActionResult DeleteProduct(int id) 
    {
        var delete = _dbContextProduct.Products
            .FirstOrDefault (product => product.IdProduct == id);
        if (delete == null) return NotFound();


        _dbContextProduct.Remove(delete);
        _dbContextProduct.SaveChanges();

        return  NoContent();
    }


    [HttpPut("UpdateProdut")]
    public IActionResult UpdateProduct(int id, [FromBody] ReadProductDto dtoProduct)
    {
        var productToUpdate = _dbContextProduct.Products
            .FirstOrDefault(product => product.IdProduct == id);


        if (productToUpdate == null) return NotFound();

        _mapper.Map(dtoProduct, productToUpdate);        
        _dbContextProduct.SaveChanges();

        return NoContent();
    }






    [HttpGet("GetProductById")]
    public IActionResult GetProductById(int id)
    {
        var productSelect = _dbContextProduct.Products
            .FirstOrDefault(product => product.IdProduct == id);
        if (productSelect == null)return NotFound();

        var productDto = _mapper.Map<ReadProductDto>(productSelect);

        return Ok(productDto);
    }



    [HttpGet("GetAmoutProduct")]
    public IActionResult GetAmout(int id)
    {
        var select = _dbContextProduct.Products
            .FirstOrDefault(product => product.IdProduct == id);
        if (select == null) return NotFound();

        var productDto = _mapper.Map<ReadAmoutProdutcDto>(select);

        return Ok(productDto);
    }






}
