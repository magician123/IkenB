using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class VendorAdapter : ITarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee vendorAdaptee = new VendorAdaptee();

            return vendorAdaptee.ListOfProducts();
        }
    }
}
