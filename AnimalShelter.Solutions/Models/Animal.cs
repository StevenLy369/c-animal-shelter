using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models


{
  public class Animal
  {
    private static List<Animal> _instances = new List<Animal> { };
    public int AnimalId { get; set; }
    public string Type { get; set; } 

    public string Gender {get;set;}
    // public int Admittance {get;set;}
    public string Name {get;set;}
  }

}