using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
//    Create a method named Add, that accepts two integers and returns the sum of those two integers
//Now create an overload of the Add method to account for being able to add two decimals together
//Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
//If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
//You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
    internal class methods
    {
        public static int Add(int num1, int num2) 
        {
         return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2) 
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool tigger) 
        {
            if (tigger && num1+num2 != 1)
            {
               return $"{num1} + {num2} = {num1 + num2} dollars";
            }
            else if (tigger && num1+num2 == 1 )
            {
                return $"{num2} + {num2} = {num1 + num2} dollar";
            }
            else 
            {
                return $"{num1} + {num2} = {num1 + num2}";
            }
        }
      
    }
}
