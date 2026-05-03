using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
/*
Problema N° 5
Crear un método público ObtenerImporteFinal, dentro de una clase Problema5, que
reciba:
● Sale sale
Debe retornar un decimal.
La clase base Sale debe tener un método virtual CalculateTotal.
Deben existir al menos dos clases derivadas:
● RetailSale
● WholesaleSale
Cada clase derivada debe redefinir el cálculo del total.
Condiciones:
● RetailSale retorna el importe sin descuento.
● WholesaleSale aplica un descuento del 10%.
● El método ObtenerImporteFinal debe llamar a sale.CalculateTotal().
● La resolución debe demostrar que se ejecuta el método correspondiente según el
tipo real del objeto recibido.

//Este Punto final no me quedo muy en claro, asi que en programa llama a cada clase derivada por separada, para mostrar su importe final

 */


{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            

            return sale.CalculateTotal();
        }
    }

    public class Sale
    {
        public decimal total { get; set; }
        public virtual decimal CalculateTotal()
        {
            return total;
        }
    }

    public class RetailSale: Sale
    {
        public override decimal CalculateTotal()
        {
            return total;
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            decimal descuento = total * 0.1m;
            return total - descuento;
        }
    }

}
