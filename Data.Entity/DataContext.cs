using Data.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Entity
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<OtherReousrce> OtherReousrces { get; set; }

    }
}
