﻿using AppService.Interfaces;
using Contracts.User;
using Infra.Data.Repositories.Interfaces;

namespace AppService.Mappers
{
    public sealed class ProcessUser : IProcessUser
    {
        private readonly IRepoUser _repoUser;
        public ProcessUser(IRepoUser repoUser)
            => _repoUser = repoUser;
        public bool Password(string Nome, string Password)
        {
            return _repoUser.ValidarUsuario(Nome, Password);
        }

        public int SalvarUsuario(UserRequest user)
        {
            return _repoUser.SalvarUsuario(UserMapper.FromRequest(user));
        }

        public UserResponse? GetUserByName(string name)
        {
            var resu = _repoUser.GetUserByName(name);
            if (resu == null) return null;
            return UserMapper.UserToReponse(resu);
        }


        public bool ValidationPassword(string Nome, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
