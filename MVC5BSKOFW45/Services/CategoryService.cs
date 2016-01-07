using System;
using System.Collections.Generic;
using System.Linq;
using MVC5BSKOFW45.EFDAL;
using MVC5BSKOFW45.Models;

namespace MVC5BSKOFW45.Services
{
    public class CategoryService : IDisposable
    {
        private EFDataContext _db = new EFDataContext();

        public List<Category> Get()
        {
            return _db.Categories.OrderBy(c => c.Name).ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
