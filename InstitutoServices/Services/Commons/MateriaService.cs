using InstitutoServices.Class;
using InstitutoServices.Interfaces;
using System.Text.Json;
using InstitutoServices.Interfaces.Commons;
using InstitutoServices.Models.Commons;

namespace InstitutoServices.Services.Commons
{
    public class MateriaService : GenericService<Materia>, IMateriaService
    {
        public MateriaService()
        {
        }

        public MateriaService(HttpClient client) : base(client)
        {

        }

        
        public async Task<List<Materia>?> GetByAnioCarreraAsync(int? idAnioCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idAnioCarrera={idAnioCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Materia>>(content, options); ;
        }
    }
}
