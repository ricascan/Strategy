using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentStrategyCard : IPaymentStrategy
    {
        public string PerformPayment(Dictionary<string, object> paymentParameters)
        {
            this.ValidateParameters(paymentParameters);
            return $"Card payment successfully completed with card number: {paymentParameters["CardNumber"]}";
        }

        private void ValidateParameters(Dictionary<string, object> paymentParameters)
        {
            if (paymentParameters == null) throw new ArgumentNullException(nameof(paymentParameters));

            if (paymentParameters.ContainsKey("CardNumber") == false)
                throw new ArgumentException("You must enter a card number in order to perform a Card payment.");
            if (paymentParameters.ContainsKey("CVV") == false)
                throw new ArgumentException("You must enter a CVV in order to perform a Card payment.");
            if (paymentParameters.ContainsKey("ExpirationDate") == false)
                throw new ArgumentException("You must enter an expiration date in order to perform a Card payment.");
        }
    }
}
