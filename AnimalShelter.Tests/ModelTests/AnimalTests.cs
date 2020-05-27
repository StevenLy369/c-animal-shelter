using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AnimalShelter.Models;
using System;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Tests
{
  [TestClass]
  public class AnimalTest : IDisposable
  {
    public void Dispose()
    {
      Animal.ClearAll();
    }

    // public AnimalTest()
    // {
    //   DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=animal_shelter;";
    // }
    [TestMethod]
    public void AnimalConstructor_CreatesInstanceOfAnimal_Animal()
    {
      Animal newAnimal = new Animal("test");
      Assert.AreEqual(typeof(Animal), newAnimal.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyListFromDatabase_ItemList()
    {
      // Arrange
      List<Animal> newList = new List<Animal> { };

      // Act
      List<Animal> result = Animal.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

     [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string type = "dog";
      Animal newAnimal = new Animal(type);

      //Act
      int result = newAnimal.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

     [TestMethod]
    public void GetAll_ReturnsAnimals_AnimalList()
    {
      //Arrange
      string type1 = "dog";
      string type2 = "cat";
      Animal newAnimal1 = new Animal(type1);
      newAnimal1.Save();
      Animal newAnimal2 = new Animal(type2);
      newAnimal2.Save();
      List<Animal> newAnimal = new List<Animal> { newItem1, newItem2 };

      //Act
      List<Animal> result = Animal.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    

 

  }
}