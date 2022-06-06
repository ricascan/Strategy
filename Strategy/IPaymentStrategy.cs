﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IPaymentStrategy
    {
        string PerformPayment(Dictionary<string, object> paymentParameters);
    }
}
