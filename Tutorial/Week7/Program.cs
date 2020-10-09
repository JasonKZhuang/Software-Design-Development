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
            //Employee e = new Employee { name = "Jane", id = 1, gender = Gender.F };
            //Console.WriteLine("Test employee == " + e);

            List<Employee> employees = GenerateTestData();
            DisplayEmployees(employees);

            Console.WriteLine("\nMale employees:");
            DisplayEmployees( FilterByGender(employees, Gender.M) );

            Console.WriteLine("\nFemale employees:");
            DisplayEmployees( FilterByGender(employees, Gender.F) );

            Console.WriteLine("\nIndeterminate, unspecified or intersex employees:");
            DisplayEmployees( FilterByGender(employees, Gender.X) );
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
        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
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
