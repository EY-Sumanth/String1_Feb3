using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6__Feb2
{
    public abstract class Shape
    {
        public abstract void Draw();
    }
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sqaure = new Square();
            sqaure.Draw();
            Shape circle = new Circle();
            circle.Draw();
        }
    }
}
