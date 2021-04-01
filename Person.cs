using System;
namespace Practical_Assignment_OOP_4
{
    //Create a new class Person with the code parts which are the same in the Officer and Lawyer classes
    class Person
    {
        private string name;
        private string surname;
        /* No-argument constructor
        public Lawyer()
        {
            name = "Janet";
            surname = "Jackson"
        }
        */
        //Argument constructor
        public Person() : this("Janet", "Jackson")
        {
        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        //Get and Set function
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetSurname(string value)
        {
            surname = value;
        }
        //ToString() is the method where information about the object values are returned as String value.
        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }
}