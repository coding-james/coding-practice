using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class WhoLikesIt
    {
        // CODEWARS - Who likes it?
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                case >= 4:
                    int extra = name.Length - 2;
                    return $"{name[0]}, {name[1]} and {extra} others like this";
                default:
                    return "no one likes this";
            }
        }
    }
}
