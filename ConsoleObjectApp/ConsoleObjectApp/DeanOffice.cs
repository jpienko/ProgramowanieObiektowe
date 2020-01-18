using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleObjectApp
{

    class DeanOffice : IOffice
    {
        private List<Student> studentList;

        public List<Student> StudentList { get => studentList; set => studentList = value; }

        public DeanOffice()
        {
            this.studentList = new List<Student>();
        }

        public DeanOffice(List<Student> studentList)
        {
            this.studentList = studentList;
        }

        public void AddStudentToList(Student student)
        {
            this.studentList.Add(student);
            Console.WriteLine("Dodano studenta: " + student.Name + " " + student.Surname);        }

        public void CreateStudent()
        {
            Student s1 = new Student();
            Student s2 = new Student("Joanna", "Pieńko", "16.03.1996", "Polska", "Kobieta", 2019, 008076, 1, "niestacjonarne");
            Student s3 = new Student("Adam", "Kowalski", "16.03.1996", "Polska", "Kobieta", 2019, 008076, 1, "niestacjonarne", true);
            Student s4 = new Student(s3);
            AddStudentToList(s1);
            AddStudentToList(s2); 
            AddStudentToList(s3);
            AddStudentToList(s4);
        }

        public void DeleteStudent(int albumNumber)
        {
            Console.WriteLine("Usunięto studenta o numerze indeksu: " + albumNumber);
            this.studentList.RemoveAll(x => x.AlbumNumber == albumNumber);
        }

        public void ShowList()
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine(
                  "Imie i nazwisko: " + student.Name + " " + student.Surname + "\n" +
                  "Data urodzenia: " + student.BirthDate + "\n" +
                  "Kraj: " + student.Country + "\n" +
                  "Rok przyjęcia na studia: " + student.AcceptanceYear + "\n" +
                  "Semestr: " + student.Semester + "\n" +
                  "Tryb studiów: " + student.StudiesMode + "\n" +
                  "Numer albumu: " + student.AlbumNumber + "\n" +
                  "Ukończył: " + student.Graduated + "\n"
              );

            }
        }

        public Student GetStudent(string name, string surname)
        {
           return this.studentList.Find(x => x.Name == name && x.Surname == surname);
        }

        public void ShowStudent(string name, string surname)
        {
            Student student = GetStudent(name, surname);
            if(student != null)
            {
                Console.WriteLine("\n Znaleziono studenta");
                Console.WriteLine(
                                 "Imie i nazwisko: " + student.Name + " " + student.Surname + "\n" +
                                 "Data urodzenia: " + student.BirthDate + "\n" +
                                 "Kraj: " + student.Country + "\n" +
                                 "Rok przyjęcia na studia: " + student.AcceptanceYear + "\n" +
                                 "Semestr: " + student.Semester + "\n" +
                                 "Tryb studiów: " + student.StudiesMode + "\n" +
                                 "Numer albumu: " + student.AlbumNumber + "\n" +
                                 "Ukończył: " + student.Graduated + "\n");
            } else
            {
                Console.WriteLine("Nie znaleziono takiego studenta");
            }
           
        }
    }
}

