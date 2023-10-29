using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.Lawand.Learnings.DataService.Data
{
    public class DatabaseContextFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public DatabaseContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }

        public AppDbContext CreateDbContext()
        {
            DbContextOptionsBuilder<AppDbContext> optionsBuilder = new();
            _configureDbContext(optionsBuilder);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
