public static class Kata
{
    public static int Solution(int value)
    {
        int result = 0;
        for (int num = (value - 1); num > 0; num--)
        {
            if (num % 3 == 0 || num % 5 == 0)
            {
                result += num;
            }
        }
        return result;
    }
}