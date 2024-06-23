using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_RH.Models;
using WebApi_RH.Service.FuncionarioService;

namespace WebApi_RH.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioInterface _funcionarioInterface;
    public FuncionarioController(IFuncionarioInterface funcionarioInterface)
    {
        _funcionarioInterface = funcionarioInterface;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
    {
        return Ok(await _funcionarioInterface.GetFuncionarios());
    }


        
}
