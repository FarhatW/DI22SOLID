using DOTNET.TEMPLATE.COMMON.CORE;
namespace DOTNET.TEMPLATE.COMMON.MODELS
{
    public class User :Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public User()
        {
            
        }
    }
}
