using System.Net.Http.Json;
using CodeSmellRefactorApi.Dto;
using CodeSmellRefactorApi.Interface;

namespace CodeSmellRefactorApi.Data;

public class UserRepository : IUserRepository
{
    private readonly HttpClient _httpClient;
    
    public UserRepository()
    {
        _httpClient = new HttpClient();
    }
    public async Task<List<UserDto>> GetUsers()
    {
        return await _httpClient.GetFromJsonAsync<List<UserDto>>("https://fake-json-api.mock.beeceptor.com/users") ?? throw new ArgumentNullException();
    }

}
