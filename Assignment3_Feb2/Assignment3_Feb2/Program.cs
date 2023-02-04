using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  
                    //Function OverLoading//

namespace Assignment3_Feb2
{   
        class Program
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
            public static float Add(float a, float b)
            {
                return a + b;
            }
            public static string Add(string a, string b)
            {
                return a + " " + b;
            }
            static void Main(string[] args)
            {
                int result = Add(69, 96);
                Console.WriteLine("Addition of integers are: " + result);
                float resultOne = Add(6.9f, 9.6f);
                Console.WriteLine("Addition of float are: " + resultOne);
                string resultTwo = Add("Hello", "Mike");
                Console.WriteLine("Addition of Strings are: " + resultTwo);
            }
        }
    }
