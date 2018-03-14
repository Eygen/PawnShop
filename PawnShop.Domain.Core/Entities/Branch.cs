using System;
using System.Collections.Generic;
using System.Text;

namespace PawnShop.Domain.Core.Entities
{
  public class Branch : BaseEntity
  {    
    public string Name { get; protected set; }
    
    public string Code { get; protected set; }
    
    public string Address { get; protected set; }
    
    public string Phone { get; protected set; }

    private Branch()
    {
    }

    public static Branch Create(string name, string code, string address, string phone)
    {
      return new Branch
      {
        Uuid = Guid.NewGuid(),
        Name = name,
        Code = code,
        Address = address,
        Phone = phone
      };
    }
  }
}
