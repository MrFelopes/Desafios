using DesafioWeb;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/endereco")]
[ApiController]
public class EnderecoController : ControllerBase
{
    private readonly ViaCepService _viaCepService;
    private readonly EnderecoRepository _enderecoRepository;

    public EnderecoController(ViaCepService viaCepService, EnderecoRepository enderecoRepository) 
    {
        _viaCepService = viaCepService;
        _enderecoRepository = enderecoRepository; 
    }

    [HttpGet("buscar/{cep}")]
    public async Task<IActionResult> BuscarEndereco(string cep)
    {
        var endereco = await _viaCepService.BuscarCepAsync(cep);

        if (endereco == null ||
            string.IsNullOrWhiteSpace(endereco.Logradouro) ||
            string.IsNullOrWhiteSpace(endereco.Bairro) ||
            string.IsNullOrWhiteSpace(endereco.Localidade) ||
            string.IsNullOrWhiteSpace(endereco.Uf))
        {
            return NotFound("CEP não encontrado ou erro na requisição.");
        }

        _enderecoRepository.Adicionar(endereco); 

        return Ok(endereco);
    }

    [HttpGet("listar")]
    public IActionResult ListarEnderecos([FromQuery] string ordenarPor = "", [FromQuery] string ordem = "asc")
    {
        var enderecos = _enderecoRepository.Listar(ordenarPor, ordem);

        if (enderecos.Count == 0)
        {
            return NoContent(); 
        }

        return Ok(enderecos);
    }
}
