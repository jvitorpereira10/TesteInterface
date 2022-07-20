using ContractProcess.Entities;
using ContractProcess.Services;
using System.Globalization;

namespace ContractProcess
{
  class Startup
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter contract data: ");
      Console.Write("Number: ");
      int number = int.Parse(Console.ReadLine());
      Console.Write("Date (dd/MM/yyyy): ");
      DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
      Console.Write("Contract value: ");
      double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Enter number of installments: ");
      int qtyInstallments = int.Parse(Console.ReadLine());

      Contract contract = new Contract(number, date, value);
      ContractService contractService = new ContractService(contract, qtyInstallments, new PaypalService());

      contractService.processContract(contract, qtyInstallments);

      Console.WriteLine();
      Console.WriteLine("Installments:");

      foreach (Installment installment in contract.installments)
      {
        Console.WriteLine(installment.dueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " - " + installment.amount.ToString("F2", CultureInfo.InvariantCulture));
      }
    }
  }
}