using System;
using System.Linq;
using System.Threading.Tasks;
using curso_aspnet_api.Data.Context;
using curso_aspnet_api.Data.Repository.User;
using curso_aspnet_api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace curso_aspnet_api.Data.Test
{
    public class UsuarioCrudCompleto : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvider;

        public UsuarioCrudCompleto(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD de Usuário")]
        [Trait("CRUD", "UsuarioEntity")]
        public async Task  E_Possivel_Realizar_CRUD_Usuario()
        {
            using (var context = _serviceProvider.GetService<ApiDataContext>())
            {
                var _repositorio = new UserRepository(context);
                var _userEntity = new UserEntity
                {
                    Email = Faker.Internet.Email(),
                    Name = Faker.Name.FullName()
                };

                var _userCriado = await _repositorio.InsertAsync(_userEntity);
                Assert.NotNull(_userCriado);
                Assert.Equal(_userEntity.Email, _userCriado.Email);
                Assert.Equal(_userEntity.Name,_userCriado.Name);
                Assert.False(_userCriado.Id == Guid.Empty);

                _userEntity.Name = Faker.Name.First();
                var _userAtualizado = await _repositorio.UpdateAsync(_userEntity);
                Assert.NotNull(_userAtualizado);
                Assert.Equal(_userEntity.Email, _userAtualizado.Email);
                Assert.Equal(_userEntity.Name,_userAtualizado.Name);

                var _userExiste = await _repositorio.ExistAsync(_userAtualizado.Id);
                Assert.True(_userExiste);

                var _userSelecionado = await _repositorio.SelectAsync(_userAtualizado.Id);
                Assert.NotNull(_userSelecionado);
                Assert.Equal(_userAtualizado.Email, _userSelecionado.Email);
                Assert.Equal(_userAtualizado.Name,_userSelecionado.Name);

                var _todosUsuarios = await _repositorio.SelectAsync();
                Assert.NotNull(_todosUsuarios);
                Assert.NotEmpty(_todosUsuarios);
                Assert.True(_todosUsuarios.Count() > 1);

                var _usuarioDeletado = await _repositorio.DeleteAsync(_userSelecionado.Id);
                Assert.True(_usuarioDeletado);

                var _usuarioPadrao = await _repositorio.FindByLogin("admin@gmail.com");
                Assert.NotNull(_usuarioPadrao);
                Assert.Equal("admin@gmail.com", _usuarioPadrao.Email);
                Assert.Equal("Admin", _usuarioPadrao.Name);

            }
        }
    }
}