using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Nodes;
using TwistedPairEF.Models;

namespace TwistedPairEF.Data
{
    public class ApplicationDbContext : IdentityDbContext, ReadColors
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PairModel> PairsModel { get; set; }

        var jsonValue = ReadColors(filename);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PairModel>().HasData(new PairModel
            {
                JsonValue.Id[0],
                PairNumber = 1,
                FirstColor = "White",
                SecondColor = "Blue",
                FirstBinderColor = null,
                SecondBinderColor = null
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}