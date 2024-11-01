using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Infrastructure.Context.Interfaces
{
    public interface ISocialNetworkDataContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<PersonFeed> Feeds { get; set; }
    }
}