using PawnShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;

namespace PawnShop.Domain.Interfaces
{
  public interface IRepository<T> where T : BaseEntity
  {
    T GetById(int id);
    List<T> List();
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
  }
}
