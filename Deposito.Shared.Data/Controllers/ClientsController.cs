using AutoMapper;
using Deposito.Shared.Data.Data.DbContexts;
using Deposito.Shared.Data.Data.Dtos.Client;
using Deposito.Shared.Data.Data.Dtos.Suppliers;
using Deposito.Shared.Models.Model.Client;
using Microsoft.AspNetCore.Mvc;

namespace Deposito.Shared.Data.Controllers;

[ApiController]
[Route("Clients")]

public class ClientsController : ControllerBase
{
    private DepositoDbContext _clientDbContext;
    private IMapper _mapper;

    public ClientsController(DepositoDbContext clientDbContext, IMapper mapper)
    {
        _clientDbContext = clientDbContext;
        _mapper = mapper;
    }


    [HttpPost("CreateClient")]
    public IActionResult CreateClient(CreateClientsDto clientDto)
    {
        Clients clients = _mapper.Map<Clients>(clientDto);
        _clientDbContext.Clients.Add(clients);
        _clientDbContext.SaveChanges();

        return Ok($"Client" + clients.SocialReason + " was create!!");

    }


    [HttpDelete("DeleteOneClient")]
    public IActionResult DeleteClient(int id)
    {
        var delete = _clientDbContext.Clients
            .FirstOrDefault(client => client.IdClient == id);
        if (delete == null) return NotFound();


        _clientDbContext.Remove(delete);
        _clientDbContext.SaveChanges();

        return NoContent();
    }

    [HttpPut("UpdateClient")]
    public IActionResult UpdateClient(int id, [FromBody] ReadSupplierDto dtoClient)
    {
        var clientToUpdate = _clientDbContext.Clients
            .FirstOrDefault(client => client.IdClient == id);


        if (clientToUpdate == null) return NotFound();

        _mapper.Map(dtoClient, clientToUpdate);
        _clientDbContext.SaveChanges();

        return NoContent();
    }


    [HttpGet("AllClients")]
    public IEnumerable<Clients> GetClients(int skip = 0, int take = 50)
    {
        return _clientDbContext.Clients.Skip(skip).Take(take).ToList();

    }


    [HttpGet("GetClientById")]
    public IActionResult GetClientById(int id)
    {
        var clientSelect = _clientDbContext.Clients
            .FirstOrDefault(client => client.IdClient == id);
        if (clientSelect == null) return NotFound();

        var clientDto = _mapper.Map<ReadSupplierDto>(clientSelect);

        return Ok(clientDto);
    }




}
