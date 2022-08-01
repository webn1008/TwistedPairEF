using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Nodes;
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
            // jsonValue takes the data that was read with ReadColors.cs and passes it into the model builder
            // with the for loop, adding 26 pairs to the application upon initial start
            var jsonValue = ReadColors.Read();
            
            for (var i = 0; i < jsonValue.Count; i++)
            {
                modelBuilder.Entity<PairModel>().HasData(new PairModel
                {
                    Id = jsonValue[i].Id,
                    PairNumber = jsonValue[i].PairNumber,
                    FirstColor = jsonValue[i].FirstColor,
                    SecondColor = jsonValue[i].SecondColor,
                    FirstBinderColor = jsonValue[i].FirstBinderColor,
                    SecondBinderColor = jsonValue[i].SecondBinderColor

                });
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}