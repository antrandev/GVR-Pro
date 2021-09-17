using Data.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Entity
{
    public partial class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


    }
}
