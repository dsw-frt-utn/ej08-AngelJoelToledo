using System;
using System.Collections.Generic;
using System.Text;
/*
Problema N° 3
Crear un método público CompararCopias, dentro de una clase Problema3, que reciba:
● int originalValue
● Product product
El método debe:
1. Copiar originalValue en una variable local.
2. Incrementar solo la copia.
3. Copiar la referencia de product en otra variable local.
4. Modificar la descripción del producto copiado mediante el método disponible en la
clase.
5. Retornar una cadena con el formato:
valorOriginal-valorCopia-descripcionProducto
*/

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue;
            copiaValor += 1;

            Product copiaProducto = product;

            copiaProducto.ModificarDescripcion("Producto modificado");



            return $"{originalValue} - {copiaValor} - {copiaProducto.descripcion}";
        }

    }

    public class Product
    {
        public string descripcion { get; set; }

        public string ModificarDescripcion(string nuevaDescripcion)
        {
            descripcion = nuevaDescripcion;
            return descripcion;
        }


    }

}

/*
int copiaValor = originalValue;
copiaValor++;

Product copiaProducto = product;
copiaProducto.Description = "Producto modificado";

return $"{originalValue}-{copiaValor}-{copiaProducto.Description}";
*/