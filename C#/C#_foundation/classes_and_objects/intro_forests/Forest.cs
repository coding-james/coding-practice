using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
    }
    
    //overloading constructors
    public Forest(string name) : this(name, "Unknown")
    {
      Console.WriteLine("Biome not specified. Value defaulted to 'Unknown'.");
    }
    
    public string Name //Using Automatic Properities
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; } //making set private
    }
     
    public int Grow() //using methods
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }

}