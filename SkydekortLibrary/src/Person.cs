using System;
using System.Collections.Generic;
using System.Text;

namespace SkydekortLibrary
{
    public class Person
    {
        public uint uID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public List<Skydekort> Skydekort;

        public Person()
        {
            Skydekort = new List<Skydekort>();
        }

        public string Display
        {
            get
            {
                return string.Format("{0} - {1} {2}", uID, FirstName, Lastname);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, Lastname);
        }

    }
}
