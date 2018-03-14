using System;
using System.Collections.Generic;
using System.Text;

namespace PawnShop.Domain.Core.Entities
{
  public class PawnItem : BaseEntity
  {    
    public int TicketId { get; protected set; }
        
    public string Name { get; protected set; }
    
    public string Grade { get; protected set; }
    
    public decimal TotalWeight { get; protected set; }
    
    public decimal Weight { get; protected set; }
    
    public int TypeId { get; protected set; }    
    
    public int FactSum { get; protected set; }
    
    public int CreditSum { get; protected set; }
    
    public string Description { get; protected set; }

    private PawnItem()
    {
    }

    public static PawnItem Create(int ticketId, string name, string grade, decimal totalWeight, decimal weight,
      int typeId, int factSum, int creditSum, string description)
    {
      return new PawnItem
      {
        Uuid = Guid.NewGuid(),
        TicketId = ticketId,
        Name = name,
        Grade = grade,
        TotalWeight = totalWeight,
        Weight = weight,
        TypeId = typeId,
        FactSum = factSum,
        CreditSum = creditSum,
        Description = description
      };
    }
  }
}
