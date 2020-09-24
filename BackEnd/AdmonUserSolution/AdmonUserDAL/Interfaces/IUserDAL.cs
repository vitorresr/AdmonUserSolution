using System;
using System.Collections.Generic;
using System.Text;
using AdmonUserEntities.Model;
using AdmonUserEntities.Transversales;

namespace AdmonUserDAL.Interfaces
{
    public interface IUserDAL
    {
        IEnumerable<User> GetUsers();

        User GetUserforID(int id);

        ResponseService CreateUser(User user);

        ResponseService UpdateUser(int id, User user);

        ResponseService DeleteUser(int id);

    }
}
