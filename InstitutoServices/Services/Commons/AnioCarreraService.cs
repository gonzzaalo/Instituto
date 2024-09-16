using InstitutoServices.Class;
using InstitutoServices.Interfaces.Commons;
using System.Text.Json;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Services.Commons
{
    public class AnioCarreraService : GenericService<AnioCarrera>, IAnioCarreraService
    {

        public AnioCarreraService(HttpClient client): base(client) 
        {

        }

        public AnioCarreraService()
        {
        }

        public async Task<List<AnioCarrera>?> GetByCarreraAsync(int? idCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idCarrera={idCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<AnioCarrera>>(content, options); ;
        }
    }
}
