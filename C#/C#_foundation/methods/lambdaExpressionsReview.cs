using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = {0, 555, 252, 3, 9, 101};
      
      // bool hasBigNum = Array.Exists(nums, IsBig);
      bool hasBigNum = Array.Exists(nums, n => n > 100);
      
      // bool hasSmallNum = Array.Exists(nums, IsSmall);
      bool hasSmallNum = Array.Exists(nums, n => n < 10);
      
      // bool hasMediumNum = Array.Exists(nums, (n) => n >= 10 && n <= 100);
      bool hasMediumNum = Array.Exists(nums, n => n >= 10 && n <= 100);
      
      Console.WriteLine($"Any big #s? {hasBigNum}");
      Console.WriteLine($"Any small #s? {hasSmallNum}");
      Console.WriteLine($"Any medium #s? {hasMediumNum}");
      
    }
    
    static bool IsBig(int n) => n > 100;
    
    static bool IsSmall(int n) => n < 10;
    
  }
}