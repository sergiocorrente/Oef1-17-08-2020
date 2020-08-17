using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1_17_08_2020
{
    public class Person
    {

        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Person(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;

        }
        public Person(string naam)
        {
            Naam = naam;
            Leeftijd = -1;
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
