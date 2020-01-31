using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Animals.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string cats, string dogs, int quantity) 
    {
    
      var query = _db.Animal.AsQueryable();
      if(cats != null)
      {
        query = query.Where(entry => entry.Cats == cats);
      }
      if(dogs != null)
      {
        query = query.Where(entry => entry.Dogs == dogs);
      }
      if(quantity != 0)
      {
        query = query.Where(entry => entry.Quantity == quantity);
      }
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animal.Add(animal);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id) 
    {
      var foundAnimal = _db.Animal.FirstOrDefault(row =>row.AnimalId==id);
    
      return foundAnimal;
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var animalToDelete = _db.Animal.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animal.Remove(animalToDelete);
      _db.SaveChanges();
    }
  }
}


   