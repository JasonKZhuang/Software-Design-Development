using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Tutorial08
{
    public enum Gender { M, F, X };
    
    public class Employee
    {
        //Reference: Properties (C# Programming Guide) https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        //Reference: Robust Programming https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-declare-and-use-read-write-properties
        //These properties have auto-generated getters and setters and hence are entirely public
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int ID { get; set; }

        public Gender Gender { get; set; }

       
        public override string ToString()
        {
            return ID + "\t " + Name + '\t'  + Gender;
        }
    }
}
