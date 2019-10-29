namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Student
    {
        string cnp;

        // prop pt cnp
        public string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }

        // auto property
        public string Name { get; set; }

        // dinamyc property & readonly
        public string FullDescription
        {
            get { return $"{cnp} - {Name}"; }
        }
    }
}
