using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
/*
Problema N° 6
Crear un método público NormalizarCodigoProducto, dentro de una clase Problema6,
que reciba:
● string code
Debe retornar un string.
Condiciones:
● El método debe usar un método de extensión llamado ToProductCode.
● El método de extensión se debe crear en otra clase, en otro archivo, denominada
Extensions
● El método de extensión debe:
○ eliminar espacios al inicio y al final,
○ convertir el texto a mayúsculas,
○ reemplazar espacios internos por guiones.
● Si el código es null, debe retornar "SIN-CODIGO".
Ejemplo:
" ab 123 x " => "AB-123-X"
 */
{
    internal class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            return code.ToProductCode();

        }
    }


}
