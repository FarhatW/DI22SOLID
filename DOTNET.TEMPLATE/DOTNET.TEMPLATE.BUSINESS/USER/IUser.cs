using DOTNET.TEMPLATE.COMMON.DTO;

namespace DOTNET.TEMPLATE.BUSINESS.USER
{
    public interface IUser
    {
        public UserResource GetUserById(int id);
        public IEnumerable<UserResource> GetAll();
        public void Add(UserResource userResource);
        public void Update(UserResource userResource);
        public void Delete(int id);
    }
}
