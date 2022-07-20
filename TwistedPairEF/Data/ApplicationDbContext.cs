using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TwistedPairEF.Models;

namespace TwistedPairEF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PairModel> PairsModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PairModel>().HasData(new PairModel
            {
                Id = 1,
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