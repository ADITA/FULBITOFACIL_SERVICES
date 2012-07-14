using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PagosServices.Clases;

namespace PagosServices
{
    /// <summary>
    /// Servicio Web en C# para pago con tarjetas el alquiler de una cancha de fulbito
    /// </summary>
    [WebService(Namespace = "http://localhost/PagosServices", Name="PagoServices", Description="Servicio Web para pago de tarjetas de credito" )]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {
        [WebMethod]
        public RespuestaTransaccion PagarServicioDebito(string numeroTarjeta, string codigoTarjeta)
        {
            if (numeroTarjeta.Equals("5118-4220-1740-9754") && codigoTarjeta.Equals("1234"))
            {
                return new RespuestaTransaccion { TransaccionValida = true, CodigoRespuestaTransaccion = Constantes.CODIGO_RESPUESTA_TRANSACCION_OK, CodigoTransaccion = 100 };
            }
            else
            {
                return new RespuestaTransaccion { TransaccionValida = false, CodigoRespuestaTransaccion = Constantes.CODIGO_RESPUESTA_TRANSACCION_DATOS_TARJETA_INCORRECTOS, CodigoTransaccion = 0 };
            }
        }

        [WebMethod]
        public RespuestaTransaccion PagarServicioCredito(string numeroTarjeta, string nombreTarjetahabiente, string cvv2)
        {
            if (numeroTarjeta.Equals("5118-4220-1740-9754") && nombreTarjetahabiente.Equals("Yo soy Ralph") && cvv2.Equals("123"))
            {
                return new RespuestaTransaccion { TransaccionValida = true, CodigoRespuestaTransaccion = Constantes.CODIGO_RESPUESTA_TRANSACCION_OK, CodigoTransaccion = 110 };
            }
            else
            {
                return new RespuestaTransaccion { TransaccionValida = false, CodigoRespuestaTransaccion = Constantes.CODIGO_RESPUESTA_TRANSACCION_DATOS_TARJETA_INCORRECTOS, CodigoTransaccion = 0 };
            }
        }

        [WebMethod]
        public List<Transaccion> ListarTransacciones(string numeroCuenta)
        {
            List<Transaccion> lstTransacciones = new List<Transaccion>();

            lstTransacciones.Add(new Transaccion
            {
                TipoTransaccion = Constantes.NOMBRE_TRANSACCION_APERTURA,
                MontoTransacion = 0.00,
                SaldoCta = 0.00
            });

            lstTransacciones.Add(new Transaccion
            {
                TipoTransaccion = Constantes.NOMBRE_TRANSACCION_INGRESO,
                MontoTransacion = 120.00,
                SaldoCta = 120.00
            });

            lstTransacciones.Add(new Transaccion
            {
                TipoTransaccion = Constantes.NOMBRE_TRANSACCION_INGRESO,
                MontoTransacion = 60.00,
                SaldoCta = 180.00
            });

            return lstTransacciones;
        }

    }
}