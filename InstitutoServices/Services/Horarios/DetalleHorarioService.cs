using InstitutoServices.Class;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using System.Text.Json;
using InstitutoServices.Interfaces.Horarios;
using InstitutoServices.Services.Commons;
using InstitutoServices.Models.Horarios;

namespace InstitutoServices.Services.Horarios
{
    public class DetalleHorarioService : GenericService<DetalleHorario>, IDetalleHorarioService
    {

        public DetalleHorarioService(HttpClient client): base(client) 
        {

        }

        public DetalleHorarioService()
        {
        }

        public async Task<List<DetalleHorario>?> GetByCarreraAsync(int? idCicloLectivo, int? idCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idCicloLectivo={idCicloLectivo}&idCarrera={idCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<DetalleHorario>>(content, options); ;
        }
        public async Task<List<DetalleHorario>?> GetByAnioCarreraAsync(int? idCicloLectivo, int? idAnioCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idCicloLectivo={idCicloLectivo}&idAnioCarrera={idAnioCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<DetalleHorario>>(content, options); ;
        }
    }
}
