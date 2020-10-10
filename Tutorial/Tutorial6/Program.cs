using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.jianshu.com/p/c8e2779e43ae
namespace KIT206_Tutorial06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            //Using for add Employees to List
            for (int i = 0; i < 10; i++)
            {
                Employee e = new Employee();
                e.Age = i;
                if (i % 2 == 0)
                {
                    e.Name = "Jane" + i;
                    e.Gender = Gender.M;
                } else
                {
                    e.Name = "Bob" + i;
                    e.Gender = Gender.F;
                }
                employees.Add(e);
            }

            //using foreach print each employee in List, calling the tostring method
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("=======================================================");


            //using custerm Filter method to filter List by Gender
            List<Employee> newEmployees = FilterByGender(employees, Gender.F);
            //Using foreach to Print the filtered result
            foreach (Employee e in newEmployees)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("=======================================================");

        }

        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            List<Employee> returnEmployees = new List<Employee>();
            foreach (Employee e in staff)
            {
                if (e.Gender == gender)
                {
                    returnEmployees.Add(e);
                }
            }
            return returnEmployees;
        }
    }


    class Box
    {
        private double length;   // 长度
        private double breadth;  // 宽度
        private double height;   // 高度

        public double Length
        {
            get{ return length;}
            set{ length = value;}
        }

        public double Breadth
        {
            get
            {
                return breadth;
            }

            set
            {
                breadth = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
    }

}
