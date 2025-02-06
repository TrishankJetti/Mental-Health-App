using Gmail_Test.Areas.Identity.Data;
using Gmail_Test.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Gmail_Test.Data;

public class MentalHealthContext : IdentityDbContext<CustomUser>
{
    public MentalHealthContext(DbContextOptions<MentalHealthContext> options)
        : base(options)
    {
    }

    public DbSet<MoodEntry> MoodEntries { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<MoodEntry>().ToTable("MoodEntry");
    }

}
