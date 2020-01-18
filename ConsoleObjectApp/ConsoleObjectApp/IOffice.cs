using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleObjectApp
{
    interface IOffice
    {
        List<Student> StudentList { get; }
        void CreateStudent();
        void AddStudentToList(Student student);
        void DeleteStudent(int albumNumber);
        void ShowList();
    }
}
