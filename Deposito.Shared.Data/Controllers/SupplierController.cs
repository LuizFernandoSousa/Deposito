using AutoMapper;
using Deposito.Shared.Data.Data.DbContexts;
using Deposito.Shared.Data.Data.Dtos.Suppliers;
using Deposito.Shared.Models.Model.Suppliers;
using Microsoft.AspNetCore.Mvc;

namespace Deposito.Shared.Data.Controllers;

[ApiController]
[Route("Supplier")]

public class SupplierController : ControllerBase
{
    private DepositoDbContext _DbContextSupplie;
    private IMapper _mapper;

    public SupplierController(DepositoDbContext depositoDbContext, IMapper mapper)
    {
        _DbContextSupplie = depositoDbContext;
        _mapper = mapper;
    }


    [HttpPost("CreateSupplier")]
    public IActionResult CreateSupplier(CreateSupplierDtos supplierDto)
    {
        Supplier supplier = _mapper.Map<Supplier>(supplierDto);
        _DbContextSupplie.Suppliers.Add(supplier);
        _DbContextSupplie.SaveChanges();

        return Ok($"Supplier " + supplier.Name + " was create!!");

    }


    [HttpGet("AllSupplies")]
    public IEnumerable<Supplier> GetSupplies(int skip = 0, int take = 50)
    {
        return _DbContextSupplie.Suppliers.Skip(skip).Take(take).ToList();

    }

    [HttpDelete("DeleteOneSupplier")]
    public IActionResult DeleteSupplier(int id)
    {
        var delete = _DbContextSupplie.Suppliers
            .FirstOrDefault(product => product.IdSupplier == id);
        if (delete == null) return NotFound();


        _DbContextSupplie.Remove(delete);
        _DbContextSupplie.SaveChanges();

        return NoContent();
    }


    [HttpPut("UpdateProdut")]
    public IActionResult UpdateProduct(int id, [FromBody] ReadSupplierDto dtoSupplier)
    {
        var supplierToUpdate = _DbContextSupplie.Suppliers
            .FirstOrDefault(supplier => supplier.IdSupplier == id);


        if (supplierToUpdate == null) return NotFound();

        _mapper.Map(dtoSupplier, supplierToUpdate);
        _DbContextSupplie.SaveChanges();

        return NoContent();
    }



}
