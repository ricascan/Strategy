using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentStrategyBizum : IPaymentStrategy
    {
        public string PerformPayment(Dictionary<string, object> paymentParameters)
        {
            this.ValidateParameters(paymentParameters);
            return $"Bizum payment successfully completed with phone number: {paymentParameters["PhoneNumber"]}";
        }

        private void ValidateParameters(Dictionary<string, object> paymentParameters)
        {
            if (paymentParameters == null) throw new ArgumentNullException(nameof(paymentParameters));

            if (paymentParameters.ContainsKey("PhoneNumber") == false) 
                throw new ArgumentException("You must enter a phone number in order to perform a Bizum payment.");
        }
    }
}
