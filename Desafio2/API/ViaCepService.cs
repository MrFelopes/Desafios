using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesafioWeb
{
    public class ViaCepService
    {
        private readonly HttpClient _httpClient;

        public ViaCepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Endereco?> BuscarCepAsync(string cep)
        {
            var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

            if (!response.IsSuccessStatusCode)
            {
                return null; 
            }

            var json = await response.Content.ReadAsStringAsync();
            var endereco = JsonSerializer.Deserialize<Endereco>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return endereco?.Cep != null ? endereco : null; 
        }
    }
}
