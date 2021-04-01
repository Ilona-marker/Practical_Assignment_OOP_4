using System;
namespace Practical_Assignment_OOP_4
{
    //Create a new class Lawyer
    class Lawyer : Person
    {
        //Remove name and surname because of Person is base class and include those
        //private string name;  
        //private string surname;
        private int lawyerID;
        private int helpedinCrimesSolving;

        /* No-argument constructor
        public Lawyer()
        {
            name = "Bob";
            surname = "Dilan";
            lawyerID = 555;
            helpedinCrimesSolving = 13;
        }
        */
        //Argument constructor
        public Lawyer() : this("Bob","Dilan", 555, 13)
        {
        }
        public Lawyer(string name, string surname, int lawyerID, int helpedinCrimesSolving ) : base(name, surname)
        {
            //this.name = name;
            //this.surname = surname;
            this.lawyerID = lawyerID;
            this.helpedinCrimesSolving = helpedinCrimesSolving;
        }
        //Get and Set function
        /*public string GetName()
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
        */
        public int GetLawyerID()
        {
          return lawyerID;  
        }
        public void SetLawyerID(int value)
        {
           lawyerID = value;   
        }
        public int GetHelpedinCrimesSolving()
        {
          return helpedinCrimesSolving;  
        }
        public void SeThelpedinCrimesSolving(int value)
        {
           helpedinCrimesSolving = value;   
        }
        //ToString() is the method where information about the object values are returned as String value.
        public override string ToString()
        {
          return "Lawyer " + base.ToString() + $"(ID {lawyerID}, Crimes helped in solving {helpedinCrimesSolving})";
        }

    }
}