using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        public string formatoMoneda(decimal price)
        {
            return price.ToString("C");
        }

    }
}
