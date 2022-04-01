using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100.MODELS
{
    static class MyExtension
    {
        public static int Power(this int a, int b)
        {
            int result = 1;
            bool c = true;
            if (b < 0)
            {
                c = false;
                b = b * (-1);
            }
            for (int i = 1; i <= b; i++)
            {
                if (c)
                    result = result * a;
                else
                    result /= a;
            }
            return result;
        }
    }
}
