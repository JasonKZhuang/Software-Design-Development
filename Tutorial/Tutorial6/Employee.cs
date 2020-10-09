using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Tutorial06
{
    enum Gender { M, F, X };

    class Employee
    {
        //private string name;
        public String Name { get; set; }// get set method

        private int _age;// field
        public int Age   // property get set method
        {
            get { return _age; }
            set { _age = value; }
        }

        private Gender _gender;
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public override string ToString()
        {
            return this.Name + ":" + this.Age + ":" + this.Gender;
        }

    }



}
