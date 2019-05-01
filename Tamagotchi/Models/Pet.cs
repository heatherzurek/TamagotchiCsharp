using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private int _hunger = 4;
    private int _happiness = 4;
    private int _rest = 4;
    private string _name;
    private int _age = 0;
    private static List<Pet> _myPets = new List<Pet> {};
    private int _id;

    public Pet (string name)
    {
      _name = name;
      _myPets.Add(this);
      _id = _myPets.Count;
    }

    public int Hunger { get => _hunger; set => _hunger = value; }
    public int Happiness { get => _happiness; set => _happiness = value; }
    public int Rest { get => _rest; set => _rest = value; }

    public int GetId()
    {
      return _id;
    }

    public static List<Pet> GetAll()
    {
      return _myPets;
    }

    public static void ClearAll()
    {
      _myPets.Clear();
    }

    public static Pet Find(int searchId)
    {
      return _myPets[searchId-1];
    }

    public static void RemovePet(int searchId)
    {
      _myPets.Remove(_myPets[searchId-1]);
    }

  }
}
