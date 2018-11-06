using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreLearning.Models
{
    public class DotNetCoreLearningContext : DbContext
    {
        public DotNetCoreLearningContext (DbContextOptions<DotNetCoreLearningContext> options)
            : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
    }
}
