using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Tutorial07
{
    enum Gender { M, F, X };

    class Employee
    {
        //Reference: Properties (C# Programming Guide) https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        //Reference: Robust Programming https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-declare-and-use-read-write-properties

        //To declare a string-valued Name property with public read and write access,
        public string FieldPublic { get; set; }
        //The only get method is public, the set method is private,
        //which cannot be accessed from outside of the Employee class
        public string FieldPublicPartly { get; private set; }

        //===============
        private int _id; //Give the private properties names beginning with an upper case letter.
        public int Id   //Give the properties names beginning with an upper case letter.
        {
            get { return _id; }
            set { _id = value; }
        }
        //===============
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null)
                {
                    _name = value;
                } else
                {
                    _name = "Name not provided";
                }
            }
        }
        //===============
        private int _age;// field
        public int Age   // property get set method
        {
            get { return _age; }
            set { _age = value; }
        }
        //===============
        private Gender _gender;
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public override string ToString()
        {
            return FieldPublic +"\t" + _name + "\t" + _id + "\t" + _gender;
        }
    }
}
