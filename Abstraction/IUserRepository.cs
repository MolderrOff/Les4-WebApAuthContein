using Les4_WebApAuthContein.Dto;
using Les4_WebApAuthContein.Models;

namespace Les4_WebApAuthContein.Abstraction
{
    public interface IUserRepository
    {
        int AddUser(UserDto user);
        RoleId CheckUser(LoginDto login);
        UserDto Authenticate(LoginDto loginDTO);

    }
}
