using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan skoda = new Sedan(60);
      Sedan vw = new Sedan(70);
      Truck bedford = new Truck(45, 500);

      Console.WriteLine($"Skoda:\nSpeed: {skoda.Speed},\nWheels: {skoda.Wheels},\nLicense: {skoda.LicensePlate}\n");
      Console.WriteLine($"VW:\nSpeed: {vw.Speed},\nWheels: {vw.Wheels},\nLicense: {vw.LicensePlate}\n");
      Console.WriteLine($"Bedord:\nSpeed: {bedford.Speed},\nWheels: {bedford.Wheels},\nLicense: {bedford.LicensePlate}\n");

      skoda.SpeedUp();
      vw.SpeedUp();
      bedford.SpeedUp();

      Console.WriteLine($"Skoda new speed: {skoda.Speed}");
      Console.WriteLine($"VW new speed: {vw.Speed}");
      Console.WriteLine($"Bedord new speed: {bedford.Speed}");
    }
  }
}