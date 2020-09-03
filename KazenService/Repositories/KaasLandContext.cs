using KazenService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KazenService.Repositories
{
    public class KaasLandContext : DbContext
    {
        public KaasLandContext(DbContextOptions<KaasLandContext> options) : base(options)
        {
        }

        public DbSet<Kaas> Kazen { get; set; }
    }
}
