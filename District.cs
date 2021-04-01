namespace Practical_Assignment_OOP_4
{
    //Create a new class District
    class District
    {
        private string title;
        private string city;
        private int districtID;
        private Person[] personsInTheDistrict;

        /* No-argument constructor
        public District()
        {
            title = "Central";
            city = "Riga";
            districtID = 1039;
            personsInTheDistrict = new Person[0];
        }
        */
        //Argument constructor
        public District() : this("Central", "Riga", 1039, new Person[0] )
         {
         }
        public District(string title, string city, int districtID, Person[] persons)
        {
            this.title = title;
            this.city = city;
            this.districtID = districtID;
            this.personsInTheDistrict = persons;
        }
        //Get and Set functions
        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string value)
        {
            city = value;
        }

        public int GetDistrictID()
        {
            return districtID;
        }

        public void SetDistrictID(int value)
        {
            districtID = value;
        }
        public Person[] GetPersonsInTheDistrict()
        {
            return personsInTheDistrict;
        }

        public void SetPersonsInTheDistrict(Person[] value)
        {
            personsInTheDistrict = value;
        }

        //ToString() is the method where information about the object values are returned as String value.
        public override string ToString()
        {
            string result = $"{title} #{districtID} in {city} (Persons:";
            foreach (Person person in personsInTheDistrict)
            {
                result += "\n" + person;
            }
            return result;
        }   

          /* There are printed out:
            Central #1039 in riga, Persons:
            Janet Snow (ID 3346, Crimes solved 19)  
            Stive Black (ID 3347, Crimes solved 33)
          */ 
           //Add new Person():boolean
           public bool AddNewPerson(Person newPerson) 
           {
            //1.Check that NewPerson does not exist as part of personInTheDistrict;
            foreach (Person existingPerson in personsInTheDistrict)
            {
              if (existingPerson.Equals(newPerson))
              {
                  return false;
              }
            }
            //2.Actually add newPerson to array as element.
            Person[] newPersons = new Person[personsInTheDistrict.Length + 1];
            for (int i = 0; i < personsInTheDistrict.Length; i++ )
            {
                newPersons[i] = personsInTheDistrict[i];
            }
            newPersons[newPersons.Length - 1] = newPerson;
            personsInTheDistrict = newPersons;
            return true;
           }
           //Actually remove personToRemove from array.
           public bool RemovePerson(Person personToRemove)
           {
           //1.Check if personToRemove actually exists in our district.
           int indexToRemove = -1;
           for (int i = 0; i < personsInTheDistrict.Length; i++ )
             {
               Person existingPerson = personsInTheDistrict[i];
               if (existingPerson.Equals(personToRemove))
               {
                 indexToRemove = i;  
                 break;
               }
               if (i == personsInTheDistrict.Length - 1)
               {
                   return false;
               }
               
             }
            //2.Actually remove officerToRemove from aray.
            Person[] newPersons = new Person[personsInTheDistrict.Length - 1];
            for (int i = 0; i < indexToRemove; i++)
            {
                newPersons[i] = personsInTheDistrict[i];
            }
            for (int i = indexToRemove + 1; i < personsInTheDistrict.Length; i++)
            {
                newPersons[i - 1] = personsInTheDistrict[i];
            }
            personsInTheDistrict = newPersons;
            return true;
        }
           //d. Edit the method calculateAvgLevelInDistrict() that only all Officers’ levels 
           //are summarized and divided by the amount of the Officers (not Lawyers) in this District.
           public float CalculateAvgLevelInDistrict()
           {
               int sum = 0, count = 0;
               foreach (Person person in personsInTheDistrict)
               if (person is Officer)
               {
                   Officer officer = (Officer)person;
                   sum += officer.CalculateLevel();
                   count++;
               }
               return (float)sum / count;
           }
        } 
    }
    

    
