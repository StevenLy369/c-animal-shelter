using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models


{
  public class Animal
  {
    private static List<Animal> _instances = new List<Animal> { };
    public int AnimalId { get; set; }
    public string Type { get; set; } 
  }

}