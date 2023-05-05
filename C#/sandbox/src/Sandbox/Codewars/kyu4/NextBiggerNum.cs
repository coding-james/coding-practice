using System.Collections.Generic;

namespace Sandbox.Codewars.kyu4
{
    public class NextBiggerNum
    {
        // CODEWARS: Next bigger number with the same digits
        public static long NextBiggerNumber(long n)
        {
            // Create a List and subList for digits
            List<int> nList = new List<int>();
            List<int> subList = new List<int>();
            string result = "";

            // Add digits to list
            foreach (char digit in n.ToString())
            {
                nList.Add((digit - '0'));
            }

            // from right to left, check for a lower digit, add to subList until a lower digit found then replace
            for (int i = nList.Count - 1; i >= 1; i--)
            {
                if (nList[i] > nList[i - 1])
                {
                    subList.Add(nList[i]);
                    subList.Add(nList[i - 1]);
                    subList.Sort();
                    // if nList[i] is smaller than subList num, then replace and remove from list.
                    // then for remaining replace remaining nList nums with subList nums
                    for (int s = 0; s < subList.Count; s++)
                    {
                        if (nList[i - 1] < subList[s])
                        {
                            nList[i - 1] = subList[s];
                            subList.RemoveAt(s);

                            foreach (int num in subList)
                            {
                                nList[i] = num;
                                i++;
                            }

                            foreach (int digit in nList)
                            {
                                result += digit.ToString();
                            }
                            return long.Parse(result);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    subList.Add(nList[i]);
                }
            }
            return -1;
        }
    }
}