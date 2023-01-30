using CONSUMINDOapi.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace CONSUMINDOapi.Services
{
    public class APIService
    {
        public HttpClient _httpClient;

        private string URL = "http://192.168.64.250:82/api/pessoas";

        public APIService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<PessoaModel>> Listar()
        {
            var response = await _httpClient.GetAsync(URL);
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<PessoaModel>>(responseContent);

        }
    }
}
