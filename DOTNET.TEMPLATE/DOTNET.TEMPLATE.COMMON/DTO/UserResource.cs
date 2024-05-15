using DOTNET.TEMPLATE.COMMON.CORE;

namespace DOTNET.TEMPLATE.COMMON.DTO
{
    public class UserResource :EntityResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Token { get; set; }
        public UserResource()
        {
            
        }
    }
}
