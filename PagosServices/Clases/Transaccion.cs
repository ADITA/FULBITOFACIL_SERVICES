using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagosServices.Clases
{
    public class Transaccion
    {

        public string TipoTransaccion { get; set; }

        public double MontoTransacion { get; set; }

        public double SaldoCta { get; set; }

    }
}