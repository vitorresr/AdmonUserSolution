using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AdmonUserEntities.Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        [DataMember]
        public string TipoDocumento { get; set; }

        [DataMember]
        public string NumeroDocumento { get; set; }

        [DataMember]
        public DateTime FechaNacimiento { get; set; }

        [DataMember]
        public string Pais { get; set; }

        [DataMember]
        public string Departamento { get; set; }

        [DataMember]
        public string Ciudad { get; set; }
    }
}
