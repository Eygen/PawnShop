using System;
using System.Collections.Generic;
using System.Text;

namespace PawnShop.Domain.Core.Entities
{
  public class ItemType : BaseEntity
  {    
    public string Name { get; protected set; }

    private ItemType()
    {
    }

    public static ItemType Create(string name)
    {
      return new ItemType
      {
        Name = name
      };
    }
  }
}
