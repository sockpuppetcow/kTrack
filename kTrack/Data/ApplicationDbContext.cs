using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using kTrack.Models;

namespace kTrack.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<kTrack.Models.Project> Project { get; set; }
        public DbSet<kTrack.Models.Issue> Issue { get; set; }
    }
}
