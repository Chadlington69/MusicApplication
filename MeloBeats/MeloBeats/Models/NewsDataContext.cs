using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MeloBeats.Models
{
    public class NewsDataContext : DbContext
    {
        public DbSet<NewsPost> NewsPosts { get; set; }

        public NewsDataContext(DbContextOptions<NewsDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
