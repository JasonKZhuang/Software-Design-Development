using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//To practise the use of LINQ for filtering and searching data structures, 
//To communicate with the HRIS case study’s MySQL database.
//Reference: https://www.cnblogs.com/dotnet261010/p/8278793.html
namespace KIT206_Tutorial09
{
    public delegate Employee ManageWorker(int id);

    class Program
    {
        static void Main(string[] args)
        {
            Action doSomething;
            Boss boss = new Boss();

            //The use of a delegate here is not necessary, but a remnant of the Week 8 tutorial
            doSomething = boss.Display;
            doSomething();

            //For testing optional implementation of step 2.3.4:
            foreach (Employee e in boss.Workers)
            {
                Console.WriteLine("Employee {0} is busy? {1}", e.Name, Agency.EmployeeBusyNow(e));
            }
        }

    }
}
