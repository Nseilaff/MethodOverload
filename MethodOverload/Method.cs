using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class Method
    {
        public static int Add(int num1, int num2)
        {
            
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {

            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            if (isTrue && sum > 1)
            {
                return $"{num1} + {num2} = {sum} dollars.";

            }
            else if (isTrue && sum == 1)
            {
                return $"{num1} + {num2} = {sum} dollar.";

            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
