using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Tutorial08
{
    class Boss
    {
        private List<Employee> _staff;
        public List<Employee> Staff
        {
            get
            {
                return _staff;
            }

            set
            {
                _staff = value;
            }
        }

        //constructor method
        //there is no return value, and the name of the method is same as the name of the class
        public Boss()
        {
            Staff = Agency.Generate();
        }

        //the construtor method could have parameters
        public Boss(int age)
        {
            ;
        }

        /// <summary>
        /// Displays the list of employees on the console.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("=======================================================");
            Staff.ForEach(Console.WriteLine);
            Console.WriteLine("=======================================================");
        }

        /// <summary>
        /// Returns the Employee with the given ID, or null if no such employee exists.
        /// </summary>
        public Employee Use(int id)
        {
            foreach (Employee e in Staff) {
                if (e.ID == id)
                {
                    return e;
                }
            }
            return null;

            //FYI, if you have an interest in lambda expressions the above could be achieved with:
            //return staff.First(e => e.ID == id);
        }

        /// <summary>
        /// Removes the Employee with the given ID from the staff list; if a
        /// matching Employee was found it is returned, otherwise returns null.
        /// </summary>
        public Employee Fire(int id)
        {
            Employee eInstance = Use(id);

            if (eInstance != null)
            {
                Staff.Remove(eInstance);
            }
            return eInstance;
        }

        //Filtering with LINQ
        public List<Employee> FilterByGender(Gender gender)
        {
            var selected = from Employee e in Staff
                           where e.Gender == gender
                           select e;
            return new List<Employee>(selected);
        }

    }
}
