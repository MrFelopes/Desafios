using System.Collections.Generic;
using System.Linq;
using DesafioWeb;

public class EnderecoRepository
{
    private readonly List<Endereco> _enderecos = new();

    public void Adicionar(Endereco endereco)
    {
        if (endereco != null) 
        {
            _enderecos.Add(endereco);
        }
    }

    public List<Endereco> Listar(string ordenarPor, string ordem)
    {
        var listaOrdenada = _enderecos.AsQueryable();

        if (!string.IsNullOrEmpty(ordenarPor))
        {
            listaOrdenada = ordenarPor.ToLower() switch
            {
                "cidade" => ordem == "desc" ? listaOrdenada.OrderByDescending(e => e.Localidade) : listaOrdenada.OrderBy(e => e.Localidade),
                "bairro" => ordem == "desc" ? listaOrdenada.OrderByDescending(e => e.Bairro) : listaOrdenada.OrderBy(e => e.Bairro),
                "estado" => ordem == "desc" ? listaOrdenada.OrderByDescending(e => e.Uf) : listaOrdenada.OrderBy(e => e.Uf),
                _ => listaOrdenada
            };
        }

        return listaOrdenada.ToList();
    }
}
