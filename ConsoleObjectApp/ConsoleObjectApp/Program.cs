using System;

namespace ConsoleObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DeanOffice deanOffice = new DeanOffice();
            deanOffice.CreateStudent();
            Console.WriteLine("Naciśnij dowolny klawisz, aby przejść dalej");
            Console.ReadKey();
            Console.WriteLine("\n\n");
            deanOffice.ShowList();
            Console.WriteLine("Naciśnij dowolny klawisz, aby przejść dalej");
            Console.ReadKey();
            Console.WriteLine("\n\n");
            deanOffice.DeleteStudent(0);
            Console.WriteLine("Naciśnij dowolny klawisz, aby przejść dalej");
            Console.ReadKey();
            Console.WriteLine("\n\n");
            deanOffice.ShowList();
            Console.WriteLine("Naciśnij dowolny klawisz, aby przejść dalej");
            Console.ReadKey();
            Console.WriteLine("\n\n");
            Console.WriteLine("Podaj imię studenta, którego chcesz znaleźć");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko studenta, którego chcesz znaleźć");
            string surname = Console.ReadLine();
            deanOffice.ShowStudent(name, surname);


            Console.ReadKey();
        }
    }
}
