using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Patterns.FACADE
{
    public interface IProductProvider
    {
        object GetProductById(string productId);
        object GetAllProducts();
    }

    public class ProductProvider : IProductProvider
    {
        public object GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public object GetProductById(string productId)
        {
            throw new NotImplementedException();
        }
    }
}
