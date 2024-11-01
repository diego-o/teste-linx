using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Infrastructure.Context.Interfaces;
using SocialNetwork.Infrastructure.Context.ModelBuilders;

namespace SocialNetwork.Infrastructure.Context
{
    public class SocialNetworkDataContext : DbContext, ISocialNetworkDataContext
    {
        public SocialNetworkDataContext(DbContextOptions<SocialNetworkDataContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonFeed> Feeds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PersonModelBuilder.Builder(modelBuilder);
            PersonFeedModelBuilder.Builder(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}

