using System;
using System.Collections.Generic;
using System.Text;
using AdmonUserEntities.Model;

namespace AdmonUserEntities.Transversales
{
    public class GeneradorRespuestas
    {
        public ResponseService GetCorrectResponse(User responseData, string message)
        {
            ResponseService respuesta = new ResponseService();
            respuesta.Code = 0;
            respuesta.Message = message;
            respuesta.ResponseData = responseData;

            return respuesta;
        }

        public ResponseService GetIncorrectResponse(int codeError, string message)
        {
            ResponseService respuesta = new ResponseService();
            respuesta.Code = codeError;
            respuesta.Message = message;

            return respuesta;
        }
    }
}
