using Microsoft.AspNetCore.Mvc;
using WebApplicationZDZ.NovaPasta;

namespace WebApplicationZDZ.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class dadosClienteController : ControllerBase
  {


    public dadosClienteController()
    {
    
    }

    [HttpPost(Name = "GetdadosClientes")]
    public DadosCliente Get([FromBody] DadosCliente dadosCliente)
    {
      return dadosCliente;
    }
  }
}
