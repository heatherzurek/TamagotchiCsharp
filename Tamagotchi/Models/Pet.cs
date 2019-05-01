using System;
using System.Collections.Generic;
using System.Timers;

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
    public System.Timers.Timer aTimer = new System.Timers.Timer();

    public Pet (string name)
    {
      _name = name;
      _myPets.Add(this);
      _id = _myPets.Count;
      SetTimer();
    }

    public string Name { get => _name; }
    public int Age { get => _age; }
    public int Hunger { get => _hunger; set => _hunger = value; }
    public int Happiness { get => _happiness; set => _happiness = value; }
    public int Rest { get => _rest; set => _rest = value; }

    private void SetTimer()
    {
      aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
      aTimer.Interval = 5000;
      aTimer.Enabled = true;
    }

    public System.Timers.Timer GetTimer()
    {
      return aTimer;
    }

    public void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                          e.SignalTime);
      _hunger--;
    }

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

    public string HowHungry()
    {
      if(_hunger == 5)
      {
        return "SO FULL!";
      }
      if(_hunger == 4)
      {
        return "KINDA FULL..";
      }
      if(_hunger == 3)
      {
        return "neither hungry, nor full.";
      }
      if(_hunger == 2)
      {
        return "peckish";
      }
      if(_hunger == 1)
      {
        return "HUNGRY!";
      }
      else
      {
        return "dead.";
      }
    }

    public string HowHappy()
    {
      if(_happiness == 5)
      {
        return "SO HAPPY";
      }
      if(_happiness == 4)
      {
        return "that life is swell..";
      }
      if(_happiness == 3)
      {
        return "ok";
      }
      if(_happiness == 2)
      {
        return "moody.";
      }
      if(_happiness == 1)
      {
        return "sad";
      }
      else
      {
        return "Died of lonliness";
      }
    }

    public string HowRested()
    {
      if(_rest == 5)
      {
        return "am bouncing off the walls!";
      }
      if(_rest == 4)
      {
        return "am ready to play";
      }
      if(_rest == 3)
      {
        return "am normal energy";
      }
      if(_rest == 2)
      {
        return "need a nap";
      }
      if(_rest == 1)
      {
        return "AM TIRED.";
      }
      else
      {
        return "died of sleep deprevation";
      }
    }


  }
}
