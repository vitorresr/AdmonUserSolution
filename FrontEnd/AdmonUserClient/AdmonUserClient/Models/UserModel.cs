using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmonUserClient.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
    }
}