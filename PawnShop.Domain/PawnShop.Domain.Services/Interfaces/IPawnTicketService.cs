using PawnShop.Domain.Core.Entities;

namespace PawnShop.Domain.Services.Interfaces
{
  public interface IPawnTicketService
  {
    void MakeTicket(PawnTicket ticket);
  }
}
