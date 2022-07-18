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

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    ModelBuilder.Entity<PairModel>().HasData(new PairModel
        //    {
        //        Id = 1,
        //        FirstPair = "White"
        //    });
        //}
    }
}