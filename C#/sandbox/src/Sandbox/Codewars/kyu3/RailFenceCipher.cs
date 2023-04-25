using System;
using System.Collections.Generic;

namespace Sandbox.Codewars.kyu3
{
    public class RailFenceCipher
    {
        // CODEWARS: Rail Fence Cipher: Encoding and Decoding
        public static string Encode(string s, int n)
        {
            if (string.IsNullOrEmpty(s)) { return ""; }

            List<string> segments = new List<string>();
            string direction = "backwards";
            string result = "";
            int pos = n - 2;

            for (int i = 0; i < s.Length; i++)
            {
                if (segments.Count < n)
                {
                    segments.Add(s.Substring(i, 1));
                }
                else if (direction == "forwards")
                {
                    segments[pos] += s.Substring(i, 1);
                    if (pos < (n) - 1)
                    {
                        pos++;
                    }
                    else
                    {
                        pos--;
                        direction = "backwards";
                    }
                }
                else
                {
                    segments[pos] += s.Substring(i, 1);
                    if (pos > 0)
                    {
                        pos--;
                    }
                    else
                    {
                        pos++;
                        direction = "forwards";
                    }
                }
            }

            for (int j = 0; j < segments.Count; j++)
            {
                result += segments[j];
            }

            return result;
        }

        public static string Decode(string s, int n)
        {
            if (string.IsNullOrEmpty(s)) { return ""; }
            List<string> segments = new List<string>();
            List<int> code = new List<int>();
            string direction = "backwards";
            string result = "";
            int pos = n - 2;

            // Calculate rails
            for (int i = 0; i < s.Length; i++)
            {
                if (code.Count < n)
                {
                    code.Add(i);
                }
                else if (direction == "forwards")
                {
                    code.Add(pos);
                    if (pos < (n) - 1)
                    {
                        pos++;
                    }
                    else
                    {
                        pos--;
                        direction = "backwards";
                    }
                }
                else
                {
                    code.Add(pos);
                    if (pos > 0)
                    {
                        pos--;
                    }
                    else
                    {
                        pos++;
                        direction = "forwards";
                    }
                }
            }
            code.Sort();

            // Split into segments
            int segmentIndex = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || code[i] != code[i - 1])
                {
                    segments.Add(s.Substring(i, 1));
                    segmentIndex++;
                }
                else
                {
                    segments[segmentIndex] += s.Substring(i, 1);
                }
            }

            // Take chars from segments
            segmentIndex = 0;
            direction = "forwards";
            while (result.Length < s.Length)
            {
                if (direction == "forwards")
                {
                    result += segments[segmentIndex][0];
                    segments[segmentIndex] = segments[segmentIndex].Substring(1);
                    if (segmentIndex < segments.Count - 1)
                    {
                        segmentIndex++;
                    }
                    else
                    {
                        segmentIndex--;
                        direction = "backwards";
                    }
                }
                else
                {
                    result += segments[segmentIndex][0];
                    segments[segmentIndex] = segments[segmentIndex].Substring(1);
                    if (segmentIndex > 0)
                    {
                        segmentIndex--;
                    }
                    else
                    {
                        segmentIndex++;
                        direction = "forwards";
                    }
                }
            }
            return result;
        }
    }
}
