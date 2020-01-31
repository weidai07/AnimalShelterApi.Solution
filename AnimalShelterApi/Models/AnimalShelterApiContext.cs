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
              new Animal { AnimalId = 121, Cats = "Brown", Dogs = "Corgi", Quantity = 51 },
              new Animal { AnimalId = 131, Cats = "White", Dogs = "Lab", Quantity = 61 },
              new Animal { AnimalId = 141, Cats = "Egyptian", Dogs = "Retriever", Quantity = 71 },
              new Animal { AnimalId = 151, Cats = "Grey", Dogs = "Pug", Quantity = 81 },
              new Animal { AnimalId = 161, Cats = "Orange", Dogs = "Chihuahua", Quantity = 91 }
          );
    }
  }
}