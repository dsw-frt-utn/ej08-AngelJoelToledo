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
        }
    }
}

