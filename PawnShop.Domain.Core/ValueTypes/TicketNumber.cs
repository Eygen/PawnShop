using System;
using System.Collections.Generic;
using System.Text;

namespace PawnShop.Domain.Core.ValueTypes
{
  public class TicketNumber
  {    
    public int BranchId { get; set; }

    public int LastNumber { get; set; }

    public TicketNumber(int branchId, int lastNumber)
    {
      BranchId = branchId;
      LastNumber = lastNumber;
    }

    public override string ToString()
    {
      //TODO: generate ticket number and return it
      return base.ToString();
    }
  }
}
