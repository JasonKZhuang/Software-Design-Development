using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Tutorial08
{
    //Delegates are data types for references to <<methods>>.
    //Reference: Delegates (C# Programming Guide)
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
    //This defines a new delegate type that is compatible with any method whose return type is Employee 
    // and that takes in a single integer parameter.
    //It doesn’t specify what the behaviour of the method must be, 
    // only what parameters and return type it must have.
    public delegate Employee ManageWorker(int id);

    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();

            //Action is an existing delegate in the System namespace. 
            //It is compatible with any method that has no return value (its return type is void) 
            // and that takes no parameters
            Action doSomething  = boss.Display;
            doSomething();

            ManageWorker manage1 = boss.Use;
            ManageWorker manage2 = boss.Fire;

            Console.WriteLine("Dealing with {0}", manage1(1));
            Console.WriteLine("After dealing with that employee");
            doSomething();

            Console.WriteLine("Fire to {0}", manage2(2));
            Console.WriteLine("After firing that employee");
            doSomething();

            //======Filtering with LINQ=======================================
            boss.Staff =  boss.FilterByGender(Gender.X);
            doSomething();


        }

    }
}
