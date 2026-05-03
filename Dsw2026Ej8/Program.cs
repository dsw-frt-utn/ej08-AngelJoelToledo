using static Dsw2026Ej8.ProductHelper;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(code: 1001,  description: "Laptop", price: 1599.99m);
            Console.WriteLine(etiqueta);

            Problema2 resumen = new Problema2();
            string resumenVenta = resumen.CrearResumenVenta(productCode: 1100, productDescription: "Celular", quantity: 2, unitPrice: 1299.99m);
            Console.WriteLine(resumenVenta);    

            Problema3 compara = new Problema3();
            string comparacion = compara.CompararCopias(originalValue: 1, product: new Product { descripcion = "Producto original" });
            Console.WriteLine(comparacion);

            Problema4 notas = new Problema4();
            double promedio = notas.CalcularPromedio(nota1: 6, nota2: 10, nota3: 3);
            Console.WriteLine($"Promedio: {promedio:F2}");
            //promedio:F2 Muestra el promedio con 2 decimales

            Problema5 compra = new Problema5();
            RetailSale compraRetail = new RetailSale { total =  100 };
            WholesaleSale compraWholesale = new WholesaleSale { total =  100 };
            Console.WriteLine($"Importe final retail: {compra.ObtenerImporteFinal(compraRetail):F2}");
            Console.WriteLine($"Importe final wholesale: {compra.ObtenerImporteFinal(compraWholesale):F2}");

            Problema6 codigo = new Problema6();
            string codigoNormalizado = codigo.NormalizarCodigoProducto(code: "  ab0 123 x ");
            Console.WriteLine(codigoNormalizado);


        }
    }
}

