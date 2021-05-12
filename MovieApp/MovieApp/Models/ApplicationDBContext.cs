using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
  public class ApplicationDBContext : DbContext
  {
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
    {
        
    }

    public DbSet<Genere> Generes   { get; set; }
    public DbSet<Movie> Movies   { get; set; }
  }
}
