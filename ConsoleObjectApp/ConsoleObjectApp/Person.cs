using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleObjectApp
{
    class Person
    {
        private string name;
        private string surname;
        private string country;
        private string birthDate;
        private string gender;

       
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Country { get => country; set => country = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }

        public Person()
        {
            this.name = "Jan";
            this.surname = "Kowalski";
            this.country = "Polska";
            this.birthDate = "19.03.1996";
            this.gender = "Mężczyzna";
        }

        public Person(string name, string surname, string country, string birthDate, string gender)
        {
            this.name = name;
            this.surname = surname;
            this.country = country;
            this.birthDate = birthDate;
            this.gender = gender;
        }

    }
}
