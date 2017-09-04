using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlackDragonPhotographyCore.Models;

namespace BlackDragonPhotographyCore.Models
{
    public class BlackDragonPhotographyCoreContext : DbContext
    {
        public BlackDragonPhotographyCoreContext (DbContextOptions<BlackDragonPhotographyCoreContext> options)
            : base(options)
        {
        }

        public DbSet<BlackDragonPhotographyCore.Models.Gallery> Gallery { get; set; }

        public DbSet<BlackDragonPhotographyCore.Models.Album> Album { get; set; }

        public DbSet<BlackDragonPhotographyCore.Models.Image> Image { get; set; }
    }
}
