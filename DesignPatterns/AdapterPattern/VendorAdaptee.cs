using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class VendorAdaptee
    {
        public List<string> ListOfProducts()
        {
            List<string> products = new List<string>();

            products.Add("TV Sets");
            products.Add("Books");
            products.Add("Games");

            return products;
        }
    }
}
