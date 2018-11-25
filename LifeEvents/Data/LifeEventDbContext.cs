using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeEvents.Models;
using Microsoft.EntityFrameworkCore;

namespace LifeEvents.Data
{
    public class LifeEventDbContext: DbContext
    {
        public LifeEventDbContext(DbContextOptions opt)
            :base(opt)
        {

        }
        public DbSet<Event> Events { get; set; }

    }
}
