using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdmonUserDAL.Context;
using AdmonUserDAL.Interfaces;
using AdmonUserEntities.Model;
using AdmonUserEntities.Transversales;
using Microsoft.EntityFrameworkCore;

namespace AdmonUserDAL.Class
{
    public class UserDAL : IUserDAL
    {
        private readonly UserDBContext _context = new UserDBContext();

        public IEnumerable<User> GetUsers()
        {
            var users = _context.User;
            return users;
        }

        public User GetUserforID(int id)
        {
            var user = _context.User.Find(id);
            return user;
        }

        public ResponseService CreateUser(User user)
        {
            ResponseService response = new ResponseService();
            GeneradorRespuestas generador = new GeneradorRespuestas();

            if (UserExists(user.Id))
            {
                response = generador.GetIncorrectResponse(10, "El usuario ya existe");
            }
            else
            {
                _context.User.Add(user);
                _context.SaveChanges();
                var enterpriseBD = _context.User.Find(user.Id);
                response = generador.GetCorrectResponse(enterpriseBD, "El usuario fue creado correctamente");
            }

            return response;
        }

        public ResponseService UpdateUser(int id, User user)
        {
            ResponseService response = new ResponseService();
            GeneradorRespuestas generador = new GeneradorRespuestas();

            _context.Entry(user).State = EntityState.Modified;

            if (!UserExists(id))
            {
                response = generador.GetIncorrectResponse(404, "El usuario no existe");
            }
            else
            {
                _context.SaveChanges();
                response = generador.GetCorrectResponse(null, "El usuario fue actualizado correctamente");
            }

            return response;


        }

        public ResponseService DeleteUser(int id)
        {
            ResponseService response = new ResponseService();
            GeneradorRespuestas generador = new GeneradorRespuestas();
            

            if (!UserExists(id))
            {
                response = generador.GetIncorrectResponse(404, "El usuario no existe");
            }
            else
            {
                User user = new User();
                user.Id = id;

                _context.Entry(user).State = EntityState.Deleted;
                _context.SaveChanges();
                response = generador.GetCorrectResponse(null, "El usuario fue eliminado correctamente");
            }

            return response;
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
