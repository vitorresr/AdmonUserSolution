using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AdmonUserBLL;
using AdmonUserDAL.Class;
using AdmonUserEntities.Model;
using AdmonUserEntities.Transversales;

namespace AdmonUserWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        private UserBLL _negocioBLL;

        public ResponseService CreateUser(User user)
        {
            ResponseService response = new ResponseService();
            GeneradorRespuestas generador = new GeneradorRespuestas();

            try
            {
                this._negocioBLL = new UserBLL(new UserDAL());
                response = this._negocioBLL.CreateUser(user);
            }
            catch (Exception ex)
            {
                response = generador.GetIncorrectResponse(ex.GetHashCode(), ex.Message);
            }

            return response;
        }

        public ResponseService DeleteUser(int id)
        {
            ResponseService response = new ResponseService();
            GeneradorRespuestas generador = new GeneradorRespuestas();

            try
            {
                this._negocioBLL = new UserBLL(new UserDAL());
                response = this._negocioBLL.DeleteUser(id);
            }
            catch (Exception ex)
            {
                response = generador.GetIncorrectResponse(ex.GetHashCode(), ex.Message);
            }

            return response;
        }

        public IEnumerable<User> GetUsers()
        {
            this._negocioBLL = new UserBLL(new UserDAL());
            var users = this._negocioBLL.GetUsers();
            return users;
        }

        public User GetUserforID(int id)
        {
            this._negocioBLL = new UserBLL(new UserDAL());
            var user = this._negocioBLL.GetUserforID(id);
            return user;
        }

        public ResponseService UpdateUser(int id, User user)
        {
            ResponseService response = new ResponseService();
            GeneradorRespuestas generador = new GeneradorRespuestas();

            try
            {
                this._negocioBLL = new UserBLL(new UserDAL());
                response = this._negocioBLL.UpdateUser(id, user);
            }
            catch (Exception ex)
            {
                response = generador.GetIncorrectResponse(ex.GetHashCode(), ex.Message);
            }

            return response;
        }
    }
}
