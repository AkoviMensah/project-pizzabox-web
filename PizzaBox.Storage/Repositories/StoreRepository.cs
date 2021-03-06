using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class StoreRepository : IRepository<Store>
  {
    private readonly PizzaBoxContext _context;

    public StoreRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Store entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Store> Select(Func<Store, bool> filter)
    {
      return _context.Stores.Where(filter);
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }
  }
}