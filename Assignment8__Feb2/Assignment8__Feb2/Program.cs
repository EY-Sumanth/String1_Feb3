using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstraction by Protected

namespace Assignment8__Feb2
{
    public abstract class Bird
    {
        protected string name = "Crow";
    }
    //public class FlyingBird: Bird
    //{     //}
    class Program : Bird
    {
        static void Main(string[] args)
        {
            Program bird = new Program();
            Console.WriteLine(bird.name);
        }
    }
}
