using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using AdmonUserEntities.Model;

namespace AdmonUserEntities.Transversales
{
    [DataContract]
    public class ResponseService
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public User ResponseData { get; set; }
    }
}
