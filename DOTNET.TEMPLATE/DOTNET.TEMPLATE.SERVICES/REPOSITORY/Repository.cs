using DOTNET.TEMPLATE.BUSINESS.Repository;
using DOTNET.TEMPLATE.DATAACCESS;

namespace DOTNET.TEMPLATE.SERVICES.REPOSITORY
{
    internal class Repository : IRepository<MyContextDb>
    {
        public MyContextDb ContextDb { get; }

        public Repository(MyContextDb contextDb)
        {
            ContextDb = contextDb;
        }

        public async Task<T> Create<T>(T obj) where T : class
        {
            ContextDb.Set<T>().Add(obj);

            await ContextDb.SaveChangesAsync();

            return obj;
        }

        public IQueryable<T> ReadAll<T>() where T : class
        {
            IQueryable<T> query  = ContextDb.Set<T>();

            return query;
        }

        public async Task<T> Update<T>(T obj) where T : class
        {
            ContextDb.Set<T>().Update(obj);

            await ContextDb.SaveChangesAsync();

            return obj;
        }

        public async Task Delete<T>(T obj) where T : class
        {
            ContextDb.Set<T>().Remove(obj);

            await ContextDb.SaveChangesAsync();

        }
    }
}
