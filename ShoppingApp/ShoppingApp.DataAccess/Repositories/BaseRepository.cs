using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.DataAccess.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ShoppingDbContext _context;
        public BaseRepository(ShoppingDbContext context)
        {
            _context = context;
        }
    }
}
