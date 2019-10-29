namespace StudentProject
{
    public class Student
    {
        public string Nume { get; set; }

        string prenume;
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        internal string FullName
        {
            get { return $"{Nume} {prenume}"; }
        }

        public void Print()
        {
            System.Console.WriteLine("Nume: " + this.FullName);
        }
    }
}
