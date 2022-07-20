namespace ContractProcess.Services
{
  class PaypalService : IOnlinePaymentService
  {
    public double Payment(double amount)
    {
      return amount + amount * 0.02;
    }

    public double Interest(double amount, int months)
    {
      return amount + (amount * 0.01) * months;
    }
  }
}