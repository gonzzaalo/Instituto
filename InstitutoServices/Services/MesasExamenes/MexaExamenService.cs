using InstitutoServices.Class;
using InstitutoServices.Interfaces.MesasExamenes;
using System.Text.Json;
using InstitutoServices.Services.Commons;
using InstitutoServices.Models.MesasExamenes;

namespace InstitutoServices.Services.MesasExamenes
{
    public class MesaExamenService : GenericService<MesaExamen>, IMesaExamenService
    {
        public MesaExamenService()
        {
        }

        public MesaExamenService(HttpClient client) : base(client)
        {

        }


        public async Task<List<MesaExamen>?> GetByTurnoAndCarreraAsync(int? idTurno, int? idCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idTurno={idTurno}&idCarrera={idCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<MesaExamen>>(content, options); ;
        }
    }
}
