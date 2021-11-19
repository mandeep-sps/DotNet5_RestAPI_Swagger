namespace Net_Core_Web_API.StoreProcedures
{
    public interface IBaseStoredProc
    {
        ////  Execute Stored Proc Async // 
        public Task<int> ExecuteStoredProcAsync
            (string storedProcedure, params object[] parameters);

        /// <summary>
        /// Execute Stored Proc With ID Async
        /// </summary>
        public Task<int> ExecuteStoredProcWithIDAsync
            (string storedProcedure, params object[] parameters);

        /// <summary>
        /// Execute Stored Proc Async
        /// </summary>
        public Task<TEntity> ExecuteStoredProcAsync<TEntity>
            (string storedProcedure, params object[] parameters) where TEntity : class;

        /// <summary>
        /// Execute Stored Proc Collection Async
        /// </summary>
        public Task<ICollection<TEntity>> ExecuteStoredProcCollectionAsync<TEntity>
            (string storedProcedure, params object[] parameters) where TEntity : class;
    }
}
