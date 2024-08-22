using System;
using CodeSmellRefactorApi.Dto;

namespace CodeSmellRefactorApi.Interface;

public interface IUserService
{
    Task<List<UserDto>> GetUsers();
}
