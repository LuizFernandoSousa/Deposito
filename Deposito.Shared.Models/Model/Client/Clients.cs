using System.ComponentModel.DataAnnotations;

namespace Deposito.Shared.Models.Model.Client;

public class Clients
{
    [Key]
    public int IdClient { get; set; }
    public string SocialReason { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }




}
