using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagosServices.Clases
{
    public class RespuestaTransaccion
    {
        public bool TransaccionValida { get; set; }

        public int CodigoRespuestaTransaccion { get; set; }

        public int CodigoTransaccion { get; set; }
    }
}