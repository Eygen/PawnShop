using PawnShop.Domain.Core.Entities;

namespace PawnShop.Services.Interfaces
{
  public interface IPawnTicketService
  {
    void MakeTicket(PawnTicket ticket);
  }
}
