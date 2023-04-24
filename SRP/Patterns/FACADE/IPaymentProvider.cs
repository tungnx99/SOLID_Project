using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Patterns.FACADE
{
    public interface IPaymentProvider
    {
        object Payment();
    }

    public class PaymentProvider : IPaymentProvider
    {
        public object Payment()
        {
            throw new NotImplementedException();
        }
    }
}
