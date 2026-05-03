using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    //Debe ser static para poder llamarse sin necesidad de crear una instancia de Extensions
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }
            string codigoNormalizado = code.Trim().ToUpper().Replace(" ", "-");
            return codigoNormalizado;
        }
    }
    // Trim elimina los espacios del inicio y del final de la cadena.
    // ToUpper pasa el texto a mayusculas.
    // Replace reemplaza " " por "-".
}
