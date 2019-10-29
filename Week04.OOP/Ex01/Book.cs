namespace Ex01
{
    public class Book
    {
        public string Name { get; set; }

        public Author Author { get; set; }

        public int Year { get; set; }

        public double Price { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"Book: {this.Name}, Price: {this.Price}, Year: {this.Year}");
            Author.Print();

            System.Console.WriteLine();
        }
    }
}
