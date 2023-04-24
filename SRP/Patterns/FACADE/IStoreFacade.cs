using SRP.Patterns.FACADE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Patterns.FACADE
{
    public interface IStoreFacade
    {
        object GetProductById(string productId);
        object GetAllProducts();
        object Payment();
    }

    public class StoreFacade : IStoreFacade
    {
        private readonly IProductProvider _productProvider;
        private readonly IPaymentProvider _paymentProvider;

        public StoreFacade(IPaymentProvider paymentProvider, IProductProvider productProvider)
        {
            _paymentProvider = paymentProvider;
            _productProvider = productProvider;
        }

        public object GetAllProducts()
        {
            return _productProvider.GetAllProducts();
        }

        public object GetProductById(string productId)
        {
            return _productProvider.GetProductById(productId);
        }

        public object Payment()
        {
            return _paymentProvider.Payment();
        }
    }
}
