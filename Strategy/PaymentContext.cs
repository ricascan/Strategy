using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy? _paymentStrategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public string Execute(Dictionary<string, object> paymentParameters)
        {
            if (_paymentStrategy == null) throw new ArgumentException("Payment strategy has not been set for this context object.");
            return _paymentStrategy.PerformPayment(paymentParameters);
        }
    }
}
