using Microsoft.EntityFrameworkCore;
using Net_Core_Web_API.CustomSql;

namespace Net_Core_Web_API.StoreProcedures
{
    public class BaseStoredProc : IBaseStoredProc
    {
        public readonly StoredProcedureClass _spContext;
        public BaseStoredProc(StoredProcedureClass spContext)
        {
            _spContext= spContext;
        }

        public  Task<int> ExecuteStoredProcAsync(string storedProcedure, params object[] parameters)
        {
            throw new NotImplementedException();

        }

        public async Task<TEntity> ExecuteStoredProcAsync<TEntity>(string storedProcedure, params object[] parameters) where TEntity : class
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Task.Run(() =>
            {
                return _spContext.Set<TEntity>()
                    .FromSqlRaw(storedProcedure.ExtendParameters(parameters.Length), parameters)
                    .AsNoTracking()
                    .AsEnumerable()
                    .FirstOrDefault();
            });
#pragma warning restore CS8603 // Possible null reference return.
        }

        public  async Task<ICollection<TEntity>> ExecuteStoredProcCollectionAsync<TEntity>(string storedProcedure, params object[] parameters) where TEntity : class
        {
            return await _spContext.Set<TEntity>()
               .FromSqlRaw(storedProcedure.ExtendParameters(parameters.Length), parameters)
               .AsNoTracking()
               .ToListAsync();
        }

        public  Task<int> ExecuteStoredProcWithIDAsync(string storedProcedure, params object[] parameters)
        {
            throw new NotImplementedException();

        }
    }

    
}
