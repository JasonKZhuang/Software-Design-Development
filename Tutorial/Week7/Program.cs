using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Tutorial07
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first test case
            List<Employee> employees1 = new List<Employee>();

            //Using for add Employees to List
            for (int i = 0; i < 10; i++)
            {
                Employee e = new Employee();
                e.Age = i;
                if (i % 2 == 0)
                {
                    e.Name = "Jane" + i;
                    e.Gender = Gender.M;
                }
                else
                {
                    e.Name = "Bob" + i;
                    e.Gender = Gender.F;
                }
                employees1.Add(e);
            }

            //using foreach print each employee in List, calling the tostring method
            foreach (Employee e in employees1)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("=======================================================");

            //=============================================================================//
            List<Employee> employees = GenerateTestData();
            DisplayEmployees(employees);

            Console.WriteLine("\nMale employees:");
            DisplayEmployees(Program.FilterByGender1(employees, Gender.M) );

            Console.WriteLine("\nFemale employees:");
            DisplayEmployees(Program.FilterByGender1(employees, Gender.F) );

            Console.WriteLine("\nIndeterminate, unspecified or intersex employees:");
            DisplayEmployees(Program.FilterByGender1(employees, Gender.X) );


            Console.WriteLine("\nMale employees22222:");
            Program pInstance = new Program();
            DisplayEmployees(pInstance.FilterByGender2(employees, Gender.M));

        }

        // Returns a new list of Employees containing some test examples.
        static List<Employee> GenerateTestData()
        {
            List<Employee> data = new List<Employee>();
            data.Add(new Employee { FieldPublic = "KIT", Name = "Jane", Id = 1, Gender = Gender.F });
            data.Add(new Employee { FieldPublic = "KIT", Name = "John", Id = 3, Gender = Gender.M });
            data.Add(new Employee { FieldPublic = "KIT", Name = "Mary", Id = 7, Gender = Gender.F });
            data.Add(new Employee { FieldPublic = "KIT", Name = "Lindsay", Id = 5, Gender = Gender.X });
            data.Add(new Employee { FieldPublic = "KIT", Name = "Meilin", Id = 2, Gender = Gender.F });

            return data;
        }

        // Returns a new list of Employees containing those with the specified gender.
        static List<Employee> FilterByGender1(List<Employee> staff, Gender gender)
        {
            List<Employee> filtered = new List<Employee>();
            foreach (Employee e in staff)
            {
                if (e.Gender == gender)
                {
                    filtered.Add(e);
                }
            }
            return filtered;
        }

        public List<Employee> FilterByGender2(List<Employee> staff, Gender gender)
        {
            List<Employee> filtered = new List<Employee>();
            foreach (Employee e in staff)
            {
                if (e.Gender == gender)
                {
                    filtered.Add(e);
                }
            }
            return filtered;
        }

        // Displays a list of employees on the console.
        static void DisplayEmployees(List<Employee> staff)
        {
            foreach (Employee e in staff)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
