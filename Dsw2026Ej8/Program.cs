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
        }
    }
}

