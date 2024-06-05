using AutoMapper;
using Client.Data;
using Client.Data.Dtos;
using Client.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers;

[ApiController]
[Route("Clients")]

public class SupplierController : ControllerBase
{
    private SupplierDbContext _DbContextSupplie;
    private IMapper _mapper;

    public SupplierController(SupplierDbContext DbContextSupplier, IMapper mapper)
    {
        _DbContextSupplie = DbContextSupplier;
        _mapper = mapper;
    }


    [HttpPost ("CreateSupplier")]
    public IActionResult CreateSupplier(CreateSupplierDtos supplierDto)
    {
        Supplier supplier = _mapper.Map<Supplier>(supplierDto);
        _DbContextSupplie.Suppliers.Add(supplier);
        _DbContextSupplie.SaveChanges();

        return Ok($"Supplier "+supplier.Name+" was create!!");

    }


    [HttpGet("AllSupplies")]
    public IEnumerable<Supplier> GetSupplies(int skip = 0, int take = 50) 
    {
        return _DbContextSupplie.Suppliers.Skip(skip).Take(take).ToList();
    
    }





}
