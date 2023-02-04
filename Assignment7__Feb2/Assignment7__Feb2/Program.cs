using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Abstract by Private

namespace Assignment7__Feb2
{
    public abstract class Teacher
    {
        private string teacherName = "Mikee";
    }
    public class Student : Teacher
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher student = new Student();
            Console.WriteLine(student.teacherName); //It generates an error because private data member can be access inside the class only.
        }
    }
}
