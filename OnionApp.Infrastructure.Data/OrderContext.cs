using System;
using System.Collections.Generic;
using OnionApp.Domain.Core;
using System.Data.Entity;

namespace OnionApp.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
