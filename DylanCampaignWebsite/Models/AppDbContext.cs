using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DylanCampaignWebsite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        //Database sets go here, and these DbSet properties allow for querying and setting instances of the classes
        //that they interface with.
        public DbSet<Character> Characters { get; set; } //Database set for Characters
    }
}
