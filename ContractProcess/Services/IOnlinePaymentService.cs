namespace ContractProcess.Services
{
  interface IOnlinePaymentService
  {
    double Payment(double amount);
    double Interest(double amount, int months);
  }
}