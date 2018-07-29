using Microsoft.EntityFrameworkCore;
using PawnShop.Domain.Core.Entities;
using PawnShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PawnShop.Infrastructure.Data
{
  public class EfRepository<T> : IRepository<T> where T : BaseEntity
  {
    protected readonly ApplicationContext _context;

    public EfRepository(ApplicationContext context)
    {
      _context = context;
    }

    public void Create(T entity)
    {
      _context.Set<T>().Add(entity);      
    }

    public void Delete(T entity)
    {      
      _context.Set<T>().Remove(entity);
    }

    public T GetById(int id)
    {
      return _context.Set<T>().SingleOrDefault(t => t.Id == id);
    }

    public List<T> List()
    {
      return _context.Set<T>().ToList();
    }

    public void Update(T entity)
    {
      _context.Entry(entity).State = EntityState.Modified;
    }
  }
}
