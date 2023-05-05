namespace Sandbox.Codewars.kyu4 
{
  public class RangeExtraction
  {
    // CODEWARS: Range Extraction
        public static string Extract(int[] args)
        {
            string result = "";
            for (int index = 0; index < args.Length; index++)
            {
                // FOR each number in args, check if next two are in sequence, if so keep working through sequence, recording start and end numbers in sequence
                if (args.Length > index + 2 && args[index + 1] == args[index] + 1 && args[index + 2] == args[index] + 2)
                {
                    int start = args[index];
                    int end = args[index + 2];
                    int endIndex = index + 2;
                    for (int x = endIndex; x < args.Length; x++)
                    {
                        if (args.Length > x + 1 && args[x] + 1 == args[x + 1])
                        {
                            end = args[x + 1];
                            endIndex = x + 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    result += endIndex + 1 < args.Length ? $"{start}-{end}," : $"{start}-{end}";
                    index = endIndex; // when sequence ends, start at index after sequence
                }
                else
                {
                    // otherwise just add number to string
                    result += index + 1 < args.Length ? $"{args[index]}," : args[index].ToString();
                }
            }
            return result;
        }
  }
}