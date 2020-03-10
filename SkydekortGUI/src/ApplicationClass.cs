using System;
using System.Collections.Generic;
using System.Text;
using SkydekortLibrary;

namespace SkydekortGUI
{
    public class ApplicationClass
    {
        public Person activePerson;

        public List<Person> people;
        public List<uint> usedUIDS;

        

        /// <summary>
        /// Constructor
        /// </summary>
        public ApplicationClass()
        {
            people = new List<Person>();
            usedUIDS = new List<uint>();
        }

        /// <summary>
        /// Til at tilføje Person objekter til people listen
        /// Føjer også person til usedUIDS
        /// </summary>
        /// <param name="person"></param>
        public void addToPeopleList(Person person)
        {
            people.Add(person);
            usedUIDS.Add(person.uID);
        }

        /// <summary>
        /// Til at fjerne Person objekt fra people listen
        /// Fjerner ogås personen fra usedUIDS
        /// </summary>
        /// <param name="person"></param>
        public void deletePerson(Person person)
        {
            people.Remove(person);
            usedUIDS.Remove(person.uID);
        }

    }
}
