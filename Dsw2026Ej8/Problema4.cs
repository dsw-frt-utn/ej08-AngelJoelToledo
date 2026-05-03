using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8

/*
 Problema N° 4
Crear un método público CalcularPromedio, dentro de una clase Problema4, que
reciba:
● int? nota1
● int? nota2
● int? nota3
Debe retornar un double.
Condiciones:
● Debe calcular el promedio solo con las notas que tengan valor.
● Si las tres notas son null, debe retornar 0.
● Si una nota tiene valor menor que 0 o mayor que 10, debe ignorarse.
● No debe lanzar excepción si alguna nota es null.
*/

{

    internal class Problema4
    {
        public double CalcularPromedio(int? nota1 , int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidadNotas = 0;
           
            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
            {
                suma += nota1.Value;
                cantidadNotas += 1 ;
            }
            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
            {
                suma += nota2.Value;
                cantidadNotas += 1 ;
            }
            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
            {
                suma += nota3.Value;
                cantidadNotas += 1 ;
            }

            double promedio = suma > 0 ? (double)suma / cantidadNotas : 0 ;
            return promedio;
        }
    }
}
