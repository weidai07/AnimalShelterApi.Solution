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
              new Animal { AnimalId = 121, Cats = "Bengal", Dogs = "Corgi", Quantity = 3 },
              new Animal { AnimalId = 131, Cats = "Ragdoll", Dogs = "Lab", Quantity = 1 },
              new Animal { AnimalId = 141, Cats = "Birman", Dogs = "Retriever", Quantity = 2 },
              new Animal { AnimalId = 151, Cats = "Persian", Dogs = "Husky", Quantity = 4 },
              new Animal { AnimalId = 161, Cats = "Sphynx", Dogs = "Chihuahua", Quantity = 5 }
          );
    }
  }
}