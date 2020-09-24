using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdmonUserClient.Models;
using AdmonUserClient.UserService;

namespace AdmonUserClient.Controllers
{
    public class UserController : Controller
    {
        UserService.UserServiceClient serviceClient = new UserService.UserServiceClient();

        // GET: User
        public ActionResult Index()
        {
            List<UserModel> listaUsermodel = new List<UserModel>();

            List<User> listaUsers = serviceClient.GetUsers().ToList();

            listaUsermodel = listaUsers.ConvertAll(x => new UserModel
            {
                Id = x.Id,
                Nombre = x.Nombre,
                TipoDocumento = x.TipoDocumento,
                NumeroDocumento = x.NumeroDocumento,
                FechaNacimiento = x.FechaNacimiento,
                Pais = x.Pais,
                Departamento = x.Departamento,
                Ciudad = x.Ciudad,
                Direccion = x.Direccion
            });

            return View(listaUsermodel);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }


        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            User usuario = new User();
            usuario.Id = user.Id;
            usuario.Nombre = user.Nombre;
            usuario.TipoDocumento = user.TipoDocumento;
            usuario.NumeroDocumento = user.NumeroDocumento;
            usuario.FechaNacimiento = user.FechaNacimiento;
            usuario.Pais = user.Pais;
            usuario.Departamento = user.Departamento;
            usuario.Ciudad = user.Ciudad;
            usuario.Direccion = user.Direccion;

            serviceClient.CreateUser(usuario);

            return RedirectToAction("Index", "User");
        }

        public ActionResult Edit(int id)
        {
            var usuario = serviceClient.GetUserforID(id);
            UserModel userModel = new UserModel();
            userModel.Id = usuario.Id;
            userModel.Nombre = usuario.Nombre;
            userModel.TipoDocumento = usuario.TipoDocumento;
            userModel.NumeroDocumento = usuario.NumeroDocumento;
            userModel.FechaNacimiento = usuario.FechaNacimiento;
            userModel.Pais = usuario.Pais;
            userModel.Departamento = usuario.Departamento;
            userModel.Ciudad = usuario.Ciudad;
            userModel.Direccion = usuario.Direccion;
            return View(userModel);

        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserModel user)
        {
            try
            {
                User usuario = new User();
                usuario.Id = user.Id;
                usuario.Nombre = user.Nombre;
                usuario.TipoDocumento = user.TipoDocumento;
                usuario.NumeroDocumento = user.NumeroDocumento;
                usuario.FechaNacimiento = user.FechaNacimiento;
                usuario.Pais = user.Pais;
                usuario.Departamento = user.Departamento;
                usuario.Ciudad = user.Ciudad;
                usuario.Direccion = user.Direccion;


                ResponseService response = serviceClient.UpdateUser(user.Id, usuario);
                if (response.Code == 0)
                {
                    return RedirectToAction("Index", "User");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            ResponseService response = serviceClient.DeleteUser(id);
            if (response.Code == 0)
            {
                return RedirectToAction("Index", "User");
            }

            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
