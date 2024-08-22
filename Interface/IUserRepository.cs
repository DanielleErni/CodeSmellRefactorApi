using System;
using CodeSmellRefactorApi.Dto;

namespace CodeSmellRefactorApi.Interface;

public interface IUserRepository
{
    Task<List<UserDto>> GetUsers();
}
