using System;
using System.Collections.Generic;
using System.Text;

namespace PawnShop.Domain.Core.Entities
{
  public abstract class BaseEntity
  {
    public int Id { get; protected set; }

    public Guid Uuid { get; protected set; }
  }
}
