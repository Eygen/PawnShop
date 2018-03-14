using PawnShop.Domain.Core.ValueTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PawnShop.Domain.Core.Entities
{
  public class PawnTicket : BaseEntity
  {    
    public bool IsRefund { get; protected set; }

    public bool IsExpired { get; protected set; }

    //срок залога в днях
    public int PledgePeriod { get; protected set; }

    public DateTime IssueDate { get; protected set; }

    //дата возврата
    public DateTime RefundDate { get; protected set; }

    public DateTime ExpireDate { get; protected set; }

    public int BranchId { get; protected set; }

    public TicketNumber TicketNumber { get; protected set; }

    public string ManagerName { get; protected set; }

    public int CustomerId { get; protected set; }

    public IList<PawnItem> PawnItems { get; protected set; }

    public decimal TotalWeight { get; protected set; }

    public decimal Weight { get; protected set; }

    public int FactSum { get; protected set; }

    public int CreditSum { get; protected set; }

    //процентная ставка      
    public decimal PercentRate { get; protected set; }

    public int PercentSum { get; protected set; }

    //ком.сбор в процентах
    public decimal CommissionRate { get; protected set; }

    public int? CommissionSum { get; protected set; }

    public int GuaranteeId { get; protected set; }

    public decimal GuaranteeRate { get; protected set; }

    public int? GuaranteeSum { get; protected set; }

    public int? RefundSum { get; protected set; }

    private PawnTicket()
    {
    }

    public static PawnTicket Create(int pledgePeriod, int branchId, string managerName, int customerId,
      IList<PawnItem> pawnItems, decimal totalWeight, decimal weight, int factSum, int creditSum,
      decimal percentRate, int percentSum, decimal commissionRate, int guaranteeId, decimal guaranteeRate, 
      TicketNumber ticketNumber)
    {
      return new PawnTicket
      {
        Uuid = Guid.NewGuid(),
        IsRefund = false,
        IsExpired = false,
        IssueDate = DateTime.Now,
        ExpireDate = DateTime.Today.AddDays(pledgePeriod),
        RefundDate = DateTime.MinValue,
        PledgePeriod = pledgePeriod,
        BranchId = branchId,
        ManagerName = managerName,
        CustomerId = customerId,
        PawnItems = pawnItems,
        TotalWeight = totalWeight,
        Weight = weight,
        FactSum = factSum,
        CreditSum = creditSum,
        PercentRate = percentRate,
        PercentSum = percentSum,
        CommissionRate = commissionRate,
        GuaranteeId = guaranteeId,
        GuaranteeRate = guaranteeRate,
        TicketNumber = ticketNumber
      };
    }
  }
}
