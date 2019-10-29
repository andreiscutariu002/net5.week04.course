namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // point1 is an instance of class Point
            Point point1 = new Point(2, 3);
            point1.Print();

            // point2 is an instance of class Point
            Point point2 = new Point(5, 10);
            point2.Print();

            //Point.Print(); - nu merge, pt ca metoda print trebuie accesata prin instanta

            point1.Print();
        }
    }

    class Point
    {
        // field
        int x;

        // field
        int y;

        public Point(int xParam, int yParam)
        {
            this.x = xParam;
            this.y = yParam;
        }

        public void Print()
        {
            System.Console.WriteLine($"Point: x={this.x}, y={this.y}");
        }
    }
}
