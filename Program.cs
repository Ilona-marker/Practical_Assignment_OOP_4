using System;
using System.Collections;
using System.Collections.Generic;
 
namespace Practical_Assignment_OOP_4
{
  //Create a new class with the main method in it.
  class Program
  {
      static void Main(string[] args)
      {
       //a. Create seven Officers as the objects, two Districts as the objects and three Lawyers as the objects.
       Officer[] officers = { 
       new Officer(),
       new Officer("John", "Doe", 3347, 12),
       new Officer("Anna", "Black", 3348, 25),
       new Officer("Stive", "Roze", 3349, 33),
       new Officer("Antuan", "Zeben",3350, 44),
       new Officer("Bete", "Deniro", 3351, 10),
       new Officer("Alex", "Stone", 3352, 8)
       };
       District district1 = new District();
       District district2 = new District("East", "Riga", 1006, new Officer[0]);
       Lawyer[] lawyers = {
       new Lawyer(),
       new Lawyer("Aivar", "Arajs", 225, 10),
       new Lawyer("Andris", "Dzerve", 226, 20)
       };
       //b. Add four Officers and two Lawyers in the first District 
       //and others Officers and Lawyers in the second District.
       for (int i = 0; i < officers.Length; i++)
            {
                District district;
                if (i < 4) { district = district1; }
                else { district = district2; }
                district.AddNewPerson(officers[i]);
            }
            for (int i = 0; i < lawyers.Length; i++)
            {
                District district;
                if (i < 2) { district = district1; }
                else { district = district2; }
                district.AddNewPerson(lawyers[i]);
            }
       
       //c. Print out all information about each District. 
       Console.WriteLine(district1);
       Console.WriteLine(district2);
      
       //d-e Edit the method calculateAvgLevelInDistrict() that only all Officers’ levels 
       //are summarized and divided by the amount of the Officers (not Lawyers) in this District.
       // Code in District.cs
       float avg1 = district1.CalculateAvgLevelInDistrict();
       float avg2 = district2.CalculateAvgLevelInDistrict();
       Console.WriteLine($"District 1 average: {avg1.ToString("0.###")} | District 2 average: {avg2.ToString("0.###")}");

       //f. Create an arraylist for the Districts storage. Put both Districts in the Arraylist. 
         ArrayList districts = new ArrayList();
         districts.Add(district1);
         districts.Add(district2);

        //g. Find out which District is with the highest number of Persons.
        int largestCount = 0;
        List<District> largest = new List<District>();
        foreach (District current in districts)
        {
            int currentCount = current.GetPersonsInTheDistrict().Length;
            if (currentCount > largestCount)
            {
              largest.Clear();
              largestCount = currentCount;
              largest.Add(current);
            }
            else if (currentCount == largestCount)
            {
              largest.Add(current);
            }
        }
            foreach (District district in largest)
            {
              Console.WriteLine($"The highest number of Persons in District are: {largestCount}.");
            }
        }
      }
  }
