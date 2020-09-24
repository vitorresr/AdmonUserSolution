using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AdmonUserEntities.Model;
using AdmonUserEntities.Transversales;

namespace AdmonUserWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        IEnumerable<User> GetUsers();

        [OperationContract]
        User GetUserforID(int id);

        [OperationContract]
        ResponseService CreateUser(User user);

        [OperationContract]
        ResponseService UpdateUser(int id, User user);

        [OperationContract]
        ResponseService DeleteUser(int id);
    }
}
