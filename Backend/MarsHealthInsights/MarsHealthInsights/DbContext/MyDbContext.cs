using MarsHealthInsights.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml;

namespace MarsHealthInsights.MyContext
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        // DbSet properties representing database tables
        public DbSet<CDCDataEntity> CDCData { get; set; }
    }
}
