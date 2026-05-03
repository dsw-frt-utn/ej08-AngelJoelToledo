using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
/*Problema N° 1
Crear un método público ObtenerEtiquetaProducto dentro de una clase parcial
ProductHelper.
El método debe recibir:
● long code
● string description
● decimal price
Debe retornar una cadena con el formato:
[code] description - price
El precio debe mostrarse en formato moneda.
Condiciones:
● La clase ProductHelper debe estar dividida en dos archivos usando partial.
● En un archivo debe ubicarse el método ObtenerEtiquetaProducto.
● En el otro archivo debe ubicarse al menos otro método auxiliar o constante utilizada
por el método principal.*/

{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string precioFormateado = formatoMoneda(price);
            return $"[{code}] {description} - {precioFormateado}";
        }

    }
}
