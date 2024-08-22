using CodeSmellRefactorApi.Data;
using CodeSmellRefactorApi.Dto;
using CodeSmellRefactorApi.Interface;
using CodeSmellRefactorApi.Service;

namespace CodeSmellRefactorApi;

public class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            IUserRepository userRepository = new UserRepository();
            IUserService userService = new UserService(userRepository);

            List<UserDto> users = await userService.GetUsers();

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.id}");
                Console.WriteLine($"Name: {user.name}");
                Console.WriteLine($"Usern: {user.username}");
                Console.WriteLine($"Email: {user.email}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
