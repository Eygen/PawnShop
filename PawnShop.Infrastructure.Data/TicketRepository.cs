using PawnShop.Domain.Core.Entities;
using PawnShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PawnShop.Infrastructure.Data
{
  public class TicketRepository : EfRepository<PawnTicket>, ITicketRepository
  {    
    public TicketRepository(ApplicationContext context) : base(context)
    {      
    }

    
  }
}
