﻿using AMA.Common.Interfaces;
using AMA.Persistence.Contexts;

namespace AMA.Persistence.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        protected readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context) => _context = context;
    }
}
