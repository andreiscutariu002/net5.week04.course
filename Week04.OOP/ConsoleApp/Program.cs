namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0. point class examples
            // point1 is an instance of class Point
            Point point1 = new Point(2, 3);
            point1.Print();

            // point2 is an instance of class Point
            Point point2 = new Point(5, 10);
            point2.Print();

            //Point.Print(); - nu merge, pt ca metoda print trebuie accesata prin instanta

            point1.Print();

            Point point3 = new Point(1);
            point3.Print();

            //Point point4 = new Point(); - nu va merge


            // 1. properties in point
            Point p = new Point(10, 20);
            p.Print();
            System.Console.WriteLine($"X = {p.X}");
            p.X = -5;
            p.Print();


            // 2. examples with properties

            Student s = new Student();
            s.Name = "Andrei";
            s.Cnp = "123";

            System.Console.WriteLine(s.FullDescription);

            //s.FullDescription = "21";
        }
    }

    class Point
    {
        // field
        public int x;

        // field
        int y;

        // proprietate pt field-ul x
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 0)
                {
                    x = value;
                }
            }
        }

        public Point(int p)
        {
            this.x = p;
            this.y = p;
        }

        // constructor, setam field-urile necesare (x si y in cazul point)
        public Point(int xParam, int yParam)
        {
            this.x = xParam;
            this.y = yParam;
        }

        // metoda simpla, aici printam fields din cadrul obiectului (x si y)
        public void Print()
        {
            System.Console.WriteLine($"Point: x={this.x}, y={this.y}");
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
