using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Task
{
    public static class ExtensionMethod
    {


        public static bool CustomContains(this string exampleWord)
        {
            if (exampleWord.Length != 1)
            {
                return true;
            }
            return false;
        }
        public static bool CustomContains(this char exampleWord)
        {
            if (exampleWord.ToString().Length == 1)
            {
                return false;
            }
            return true;
        }

        public static bool IsPrime(this int Digit)
        {
            int count = 0;
            for (int i = 1; i <= Digit; i++)
            {
                if (Digit % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsPowOfTwo(this int Power)
        {
            bool Result = true;
            int Multipler = 2;
            while (Multipler <= Power)
            {
                if (Multipler == Power)
                {
                    Result = true;
                    break;
                }
                else
                {
                    Result = false;
                }

                Multipler *= 2;
            }
            return Result;
        }
    }
}
