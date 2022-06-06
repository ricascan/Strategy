using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentStrategyPayPal : IPaymentStrategy
    {
        public string PerformPayment(Dictionary<string, object> paymentParameters)
        {
            this.ValidateParameters(paymentParameters);
            return $"PayPal payment successfully completed with email: {paymentParameters["Email"]}";
        }

        private void ValidateParameters(Dictionary<string, object> paymentParameters)
        {
            if (paymentParameters == null) throw new ArgumentNullException(nameof(paymentParameters));

            if (paymentParameters.ContainsKey("Email") == false)
                throw new ArgumentException("You must enter an email in order to perform a PayPal payment.");
            if (paymentParameters.ContainsKey("Password") == false)
                throw new ArgumentException("You must enter a password in order to perform a PayPalPayment.");
        }
    }
}
