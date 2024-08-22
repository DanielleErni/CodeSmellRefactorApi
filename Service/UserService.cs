using CodeSmellRefactorApi.Dto;
using CodeSmellRefactorApi.Interface;

namespace CodeSmellRefactorApi.Service;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<List<UserDto>> GetUsers()
    {
        List<UserDto> users = await _userRepository.GetUsers();
        int index = 1;

        foreach (var user in users)
        {
            if (index%2 == 0)
            {
                user.name += " pogi";
            }
            else
            {
                user.name += " ganda";
            }

            index++;
        }
        return users;
    }
}
