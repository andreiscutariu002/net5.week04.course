using StudentProject;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student(); // trebuie sa adaugam referinta catre proiectul student project

            s.Nume = "Andrei";
            s.Prenume = "Sct";

            //System.Console.WriteLine(s.FullName);

            s.Print();
        }
    }
}
