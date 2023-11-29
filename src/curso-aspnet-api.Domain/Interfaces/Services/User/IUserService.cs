using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos.User;
using curso_aspnet_api.Domain.Entities;

namespace curso_aspnet_api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserDto> Get(Guid id);
        Task<IEnumerable<UserDto>> GetAll();
        Task<UserCreateResultDto> Post(UserCreateDto user);
        Task<UserUpdateResultDto> Put(UserUpdateDto user);
        Task<bool> Delete(Guid id);
    }
}