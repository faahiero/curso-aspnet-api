using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using curso_aspnet_api.Domain.Dtos.User;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces;
using curso_aspnet_api.Domain.Interfaces.Repository;
using curso_aspnet_api.Domain.Interfaces.Services.User;
using curso_aspnet_api.Domain.Models;

namespace curso_aspnet_api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _repository;
        private readonly IMapper _mapper;

        public UserService(IRepository<UserEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserDto> Get(Guid id)
        {
            var userEntity = await _repository.SelectAsync(id);
            var userDto = _mapper.Map<UserDto>(userEntity);
            return userDto ?? new UserDto();
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var userEntities =  await _repository.SelectAsync();
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(userEntities);
            return userDtos;
        }

        public async Task<UserCreateResultDto> Post(UserCreateDto user)
        {
            var userModel = _mapper.Map<UserModel>(user);
            var userEntity = _mapper.Map<UserEntity>(userModel);
            var result = await _repository.InsertAsync(userEntity);
            var userCreateResultDto = _mapper.Map<UserCreateResultDto>(result);
            return userCreateResultDto;
        }

        public async Task<UserUpdateResultDto> Put(UserUpdateDto user)
        {
            var userModel = _mapper.Map<UserModel>(user);
            var userEntity = _mapper.Map<UserEntity>(userModel);
            var result = await _repository.UpdateAsync(userEntity);
            var userUpdateResultDto = _mapper.Map<UserUpdateResultDto>(result);
            return userUpdateResultDto;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}