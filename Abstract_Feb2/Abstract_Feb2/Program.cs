using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Feb2
{
    using System;
    public abstract class Biriyani
    {
        public abstract void Eat();
    }
    public class ChickenBiriyani : Biriyani
    {
        public override void Eat()
        {
            Console.WriteLine("Chicken Biriyani is Tasty");
        }
    }
    public class MuttonBiriyani : Biriyani
    {
        public override void Eat()
        {
            Console.WriteLine("Mutton Biriyani is tasty");
        }
    }
    public class ModeAbstract
    {
        public static void Main()
        {
            Eat e1;
            e1 = new ChickenBiriyani();
            e1.Eat();
            e1= new MuttonBiriyani();
            e1.Eat();
        }
    }
}
