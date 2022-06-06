// See https://aka.ms/new-console-template for more information
using Strategy;

PaymentContext paymentContext = new PaymentContext();

paymentContext.SetStrategy(new PaymentStrategyBizum());

var paymentParameters = new Dictionary<string, object>()
{
    ["PhoneNumber"] = "123456789"
};

Console.WriteLine(paymentContext.Execute(paymentParameters));

paymentParameters = new Dictionary<string, object>()
{
    ["CardNumber"] = "12345567763634",
    ["CVV"] = "501",
    ["ExpirationDate"] = "12/29"
};

paymentContext.SetStrategy(new PaymentStrategyCard());

Console.WriteLine(paymentContext.Execute(paymentParameters));

paymentParameters = new Dictionary<string, object>()
{
    ["Email"] = "pepe@gmail.com",
    ["Password"] = "123"
};

paymentContext.SetStrategy(new PaymentStrategyPayPal());

Console.WriteLine(paymentContext.Execute(paymentParameters));
