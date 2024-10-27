using InstitutoServices.Interfaces;

namespace InstitutoServices.Services.Commons
{
    public interface IMemoryCacheService
    {
        Task<List<T>> GetAllCacheAsync<T>(string key) where T : class, IEntityWithId;
        Task<bool> DeleteCacheAsync<T>(int id, string key) where T : class, IEntityWithId;
        Task<T> AddCacheAsync<T>(T entity, string key) where T : class, IEntityWithId;
        Task<bool> UpdateCacheAsync<T>(T entity, string key) where T : class, IEntityWithId;
        void ClearCache(string key);
    }
}