using InstitutoServices.Class;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using System.Text.Json;
using InstitutoServices.Interfaces.Horarios;
using InstitutoServices.Services.Commons;
using InstitutoServices.Models.Horarios;

namespace InstitutoServices.Services.Horarios
{
    public class HorarioService : GenericService<Horario>, IHorarioService
    {
        public HorarioService()
        {
        }

        public HorarioService(HttpClient client) : base(client)
        {

        }


        public async Task<List<Horario>?> GetByCarreraAsync(int? idCicloLectivo, int? idCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idCicloLectivo={idCicloLectivo},idCarrera={idCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Horario>>(content, options); ;
        }
    }
}
