using System;

namespace DatingProfile
{
  class Profile
  {
    // FIELDS
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // CONSTRUCTORS
    public Profile(
    string name, 
    int age, 
    string city = "n/a", 
    string country = "n/a", 
    string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0]; //set to an empty string
    }

    // METHODS

    public string ViewProfile()
    {
      string bio = $"Name: {name},\nAge: {age},\nCity: {city},\nCountry: {country},\nPronouns: {pronouns}";
      
      if (this.hobbies.Length > 0)
      {
        bio  += "\nHobbies:\n";
        foreach (string hobby in hobbies)
        {
          bio += $"- {hobby}\n";
        }
      }
      

      return bio;
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }

  } 
}