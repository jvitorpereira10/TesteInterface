using ContractProcess.Services;

namespace ContractProcess.Entities
{
  public class Contract
  {
    public int number { get; set; }
    public DateTime date { get; set; }
    public double totalValue { get; set; }
    public List<Installment> installments { get; set; } = new List<Installment>();

    public Contract(int number, DateTime date, double totalValue)
    {
      this.number = number;
      this.date = date;
      this.totalValue = totalValue;
    }
  }
}