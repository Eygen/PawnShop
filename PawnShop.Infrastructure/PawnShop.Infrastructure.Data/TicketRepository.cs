using PawnShop.Domain.Core.Entities;
using PawnShop.Domain.Interfaces;

namespace PawnShop.Infrastructure.Data
{
  public class TicketRepository : EfRepository<PawnTicket>, ITicketRepository
  {    
    public TicketRepository(ApplicationContext context) : base(context)
    {      
    }

    
  }
}
