using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                 //Function Overriding 

namespace Assignment4_Feb2
{ 
        class Biriyani
        {
            public virtual void Show()
            {
                Console.WriteLine("Biriyani - Base Class");
            }
        }
        class Chicken : Biriyani
        {
            public override void Show()
            {
                Console.WriteLine("Chicken - Derived Class");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Biriyani chicken = new Chicken();
                chicken.Show();
            }
        }
    }

