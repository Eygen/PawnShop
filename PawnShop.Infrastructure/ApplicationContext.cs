using Microsoft.EntityFrameworkCore;
using PawnShop.Domain.Core.Entities;
using System;

namespace PawnShop.Infrastructure.Data
{
  public class ApplicationContext : DbContext
  {
    public DbSet<PawnTicket> Tickets { get; set; }

    public ApplicationContext()
    {
      Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PawnShop;Trusted_Connection=True;");
    }
  }
}
