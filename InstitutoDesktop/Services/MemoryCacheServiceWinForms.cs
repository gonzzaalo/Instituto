using InstitutoDesktop.Util;
using InstitutoServices.Interfaces;
using InstitutoServices.Services.Commons;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoDesktop.Services
{
    public class MemoryCacheServiceWinForms : MemoryCacheService
    {
        public MemoryCacheServiceWinForms(IMemoryCache memoryCache) : base(memoryCache)
        {
           
        }
        public override async Task<List<T>> GetAllCacheAsync<T>(string key) where T : class
        {
            //ShowInActivity.Show($"Descargando/actualizando la lista de {key}");
            var retorno= await base.GetAllCacheAsync<T>(key);
            //ShowInActivity.Hide();
            return retorno;
        }
        public override async Task<bool> DeleteCacheAsync<T>(int id, string key) where T : class
        {
            ShowInActivity.Show($"Eliminando un registro en {key}");
            var retorno= await base.DeleteCacheAsync<T>(id, key);
            ShowInActivity.Hide();
            return retorno;
        }
        public override async Task<T> AddCacheAsync<T>(T entity, string key) where T : class
        {
            ShowInActivity.Show($"Agregando un registro en {key}");
            var retorno= await base.AddCacheAsync<T>(entity, key);
            ShowInActivity.Hide();
            return retorno;
        }
        public override async Task<bool> UpdateCacheAsync<T>(T entity, string key) where T : class
        {
            ShowInActivity.Show($"Actualizando un registro en {key}");
            var retorno = await base.UpdateCacheAsync<T>(entity, key);
            ShowInActivity.Hide();
            return retorno;
        }
    }
}
