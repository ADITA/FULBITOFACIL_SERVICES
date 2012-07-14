using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagosServices.Clases
{
    public class Constantes
    {
        public const int CODIGO_RESPUESTA_TRANSACCION_OK = 0;
        public const int CODIGO_RESPUESTA_TRANSACCION_NUMERO_TARJETA_INEXISTENTE = 1;
        public const int CODIGO_RESPUESTA_TRANSACCION_SALDO_INSUFICIENTE = 2;
        public const int CODIGO_RESPUESTA_TRANSACCION_TOPE_SOBREPASADO = 3;
        public const int CODIGO_RESPUESTA_TRANSACCION_DATOS_TARJETA_INCORRECTOS = 4;

        public const string NOMBRE_TRANSACCION_APERTURA = "Apertura Cuenta";
        public const string NOMBRE_TRANSACCION_INGRESO = "Ingreso";
        public const string NOMBRE_TRANSACCION_EGRESO = "Egreso";
    }
}