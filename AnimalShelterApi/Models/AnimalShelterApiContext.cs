using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animal { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Cats = "1", Dogs = "a", Quantity = 5 },
              new Animal { AnimalId = 2, Cats = "2", Dogs = "b", Quantity = 4 },
              new Animal { AnimalId = 3, Cats = "3", Dogs = "c", Quantity = 3 },
              new Animal { AnimalId = 4, Cats = "4", Dogs = "d", Quantity = 2 },
              new Animal { AnimalId = 5, Cats = "5", Dogs = "e", Quantity = 1 }
          );
    }
  }
}