using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Models.MesasExamenes;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoServices.Services.Commons
{
    public class MemoryCacheService
    {
        protected readonly IMemoryCache _memoryCache;

        public MemoryCacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }


        // Método para obtener los datos de la caché
        public virtual async Task<List<T>> GetAllCacheAsync<T>(string key) where T : class, IEntityWithId
        {
            if (_memoryCache.TryGetValue(key, out List<T> cachedList))
            {
                return cachedList;
            }
            IGenericService<T> genericService = new GenericService<T>();
            var list= await genericService.GetAllAsync();
            _memoryCache.Set(key, list);
            return list;
        }
        //método para eliminar un dato usando el generic y si lo logra, lo elimina de la caché
        public virtual async Task<bool> DeleteCacheAsync<T>(int id, string key) where T : class, IEntityWithId
        {
            IGenericService<T> genericService = new GenericService<T>();
            var result = await genericService.DeleteAsync(id);
            if (result)
            {
                var list = await GetAllCacheAsync<T>(key);
                var item = list.FirstOrDefault(x => x.Id == id);
                list.Remove(item);
                _memoryCache.Set(key, list);
            }
            return result;
        }
        //método para agregar un dato usando el generic y si lo logra, lo agrega a la caché
        public virtual async Task<T> AddCacheAsync<T>(T entity, string key) where T : class, IEntityWithId
        {
            IGenericService<T> genericService = new GenericService<T>();
            var result = await genericService.AddAsync(entity);
            if (result != null)
            {
                var list = await GetAllCacheAsync<T>(key);
                list.Add(result);
                _memoryCache.Set(key, list);
            }
            return result;
        }
        //método para actualizar un dato usando el generic y si lo logra, lo actualiza en la caché
        public virtual async Task<bool> UpdateCacheAsync<T>(T entity, string key) where T : class, IEntityWithId
        {
            IGenericService<T> genericService = new GenericService<T>();
            var result = await genericService.UpdateAsync(entity);
            if (result)
            {
                var list = await GetAllCacheAsync<T>(key);
                var item = list.FirstOrDefault(x => x.Id == entity.Id);
                list.Remove(item);
                list.Add(entity);
                _memoryCache.Set(key, list);
            }
            return result;
        }
        //método para vaciar la caché de una determinada key
        public void ClearCache(string key)
        {
            _memoryCache.Remove(key);
        }
    }
}
