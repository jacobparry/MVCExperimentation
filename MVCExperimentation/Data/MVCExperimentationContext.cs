using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCExperimentation.Models
{
    public class MVCExperimentationContext : DbContext
    {
        public MVCExperimentationContext (DbContextOptions<MVCExperimentationContext> options)
            : base(options)
        {
        }

        public DbSet<MVCExperimentation.Models.Movie> Movie { get; set; }
    }
}
