using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleObjectApp
{
    class Student: Person
    {
        private int acceptanceYear;
        private int albumNumber;
        private bool graduated;
        private int semester;
        private string studiesMode;

        public int AcceptanceYear { get => acceptanceYear; set => acceptanceYear = value; }
        public int AlbumNumber { get => albumNumber; set => albumNumber = value; }
        public bool Graduated { get => graduated; set => graduated = value; }
        public int Semester { get => semester; set => semester = value; }
        public string StudiesMode { get => studiesMode; set => studiesMode = value; }

        /* konstruktor domyślny*/
        public Student():base()
        {
            this.acceptanceYear = 2018;
            this.albumNumber = 000000;
            this.graduated = false;
            this.semester = 4;
            this.studiesMode = "Stacjonarne";
        }
        /* konstruktor z parametrami*/
        //string name, string surname, string country, string birthDate, string gender
        public Student(string name, string surname, string country, string birthDate, string gender, int acceptanceYear, int albumNumber, int semester, string studiesMode, bool graduated = false)
            : base ( name,  surname,  country,  birthDate,  gender)
        {
            this.acceptanceYear = acceptanceYear;
            this.albumNumber = albumNumber;
            this.graduated = graduated;
            this.semester = semester;
            this.studiesMode = studiesMode;
        }
        /* konstruktor kopiujący*/
        public Student(Student copyMe)
        {
            Name = copyMe.Name;
            Surname = copyMe.Surname;
            Country = copyMe.Country;
            BirthDate = copyMe.BirthDate;
            Gender = copyMe.Gender;
            this.acceptanceYear = copyMe.AcceptanceYear;
            this.albumNumber = copyMe.AlbumNumber;
            this.graduated = copyMe.Graduated;
            this.semester = copyMe.Semester;
            this.studiesMode = copyMe.StudiesMode;
        }
    }
}
