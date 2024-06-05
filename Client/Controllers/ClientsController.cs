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

public class ClientsController : ControllerBase
{
    private ClientsDbContext _clientDbContext;
    private IMapper _mapper;

    public ClientsController(ClientsDbContext clientDbContext, IMapper mapper)
    {
        _clientDbContext = clientDbContext;
        _mapper = mapper;
    }


    [HttpPost ("CreateClient")]
    public IActionResult CreateClient(CreateClientsDtos clientDto)
    {
        Clients clients = _mapper.Map<Clients>(clientDto);
        _clientDbContext.Clients.Add(clients);
        _clientDbContext.SaveChanges();

        return Ok($"Client"+clients.SocialReason+" was create!!");

    }


    [HttpGet("AllClients")]
    public IEnumerable<Clients> GetClients(int skip = 0, int take = 50) 
    {
        return _clientDbContext.Clients.Skip(skip).Take(take).ToList();
    
    }





}
