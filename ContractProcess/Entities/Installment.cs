using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractProcess.Entities
{
  public class Installment
  {
    public DateTime dueDate { get; set; }
    public double amount { get; set; }

    public Installment(DateTime dueDate, double amount)
    {
      this.dueDate = dueDate;
      this.amount = amount;
    }
  }
}