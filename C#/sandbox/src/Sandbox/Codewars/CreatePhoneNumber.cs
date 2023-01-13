namespace CWars
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({string.Join("", numbers[0..3])}) {string.Join("", numbers[3..6])}-{string.Join("", numbers[6..10])}";
        }
    }
}