using ContractProcess.Entities;

namespace ContractProcess.Services
{
  class ContractService
  {
    public Contract contract { get; set; }
    public int months { get; set; }

    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(Contract contract, int months, IOnlinePaymentService onlinePaymentService)
    {
      this.contract = contract;
      this.months = months;
      _onlinePaymentService = onlinePaymentService;
    }
    public void processContract(Contract contract, int months)
    {
      for (int i = 1; i <= months; i++)
      {
        double installmentValue = _onlinePaymentService.Payment(_onlinePaymentService.Interest(contract.totalValue/months, i));

        contract.installments.Add(new Installment
        (
         contract.date.AddMonths(i),
         installmentValue
        ));
      }
    }
  }
}