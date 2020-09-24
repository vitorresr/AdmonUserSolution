using System;
using System.Collections.Generic;
using System.Text;
using AdmonUserDAL.Interfaces;
using AdmonUserEntities.Model;
using AdmonUserEntities.Transversales;

namespace AdmonUserBLL
{
    public class UserBLL
    {
        private IUserDAL _repositorioDAL;

        public UserBLL(IUserDAL repositorioDAL)
        {
            this._repositorioDAL = repositorioDAL;
        }

        public IEnumerable<User> GetUsers()
        {
            return _repositorioDAL.GetUsers();
        }

        public User GetUserforID(int id)
        {
            return _repositorioDAL.GetUserforID(id);
        }

        public ResponseService CreateUser(User user)
        {
            return _repositorioDAL.CreateUser(user);
        }

        public ResponseService UpdateUser(int id, User user)
        {
            return _repositorioDAL.UpdateUser(id, user);
        }

        public ResponseService DeleteUser(int id)
        {
            return _repositorioDAL.DeleteUser(id);
        }

    }
}
