namespace Sandbox
{
    public class CodeWars
    {       
        // TODO : Fails random test?
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int numOne = ((int[])numbers)[0];
            int numTwo = Int32.MinValue;
            int numOneCount = 0;
            int numTwoCount = 0;
            int index = 0;
            for (int i = 0; i < ((int[])numbers).Length; i++)
            {
                if ((numOneCount == 1 && numTwoCount > 2) || (numOneCount > 2 && numTwoCount == 1))
                {
                    return numOneCount < numTwoCount ? numOne : numTwo;
                }
                else if (((int[])numbers)[index] == numOne)
                {
                    numOneCount++;
                    index++;
                }
                else if (((int[])numbers)[index] == numTwo)
                {
                    numTwoCount++;
                    index++;
                }
                else
                {
                    numTwo = ((int[])numbers)[index];
                    numTwoCount++;
                    index++;
                }
            }
            return numOneCount < numTwoCount ? numOne : numTwo;
        }
    }
}