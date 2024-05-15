namespace DOTNET.TEMPLATE.BUSINESS.Repository
{
    public interface IRepository<U>
    {
        public U ContextDb { get; }
        
        public Task<T> Create<T>(T obj) where T : class;
        public IQueryable<T> ReadAll<T>() where T : class;
        public Task<T> Update<T>(T obj) where T : class;
        public Task Delete<T>(T obj) where T : class;
    }
}
