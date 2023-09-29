using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    static class MyExtensions
    {
        public static bool ContainsAnyCharacter(this string mainString, params string[] strings2Check)
        {
            foreach (string str in strings2Check)
            {
                bool contains = false;
                foreach (char c in str)
                {
                    if (mainString.Contains(c))
                    {
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
