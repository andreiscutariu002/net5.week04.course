namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author
            {
                Name = "Andrei",
                Email = "and@some.com",
                Country = "RO"
            };

            Book b1 = new Book
            {
                Name = "Prima carte",
                Year = 2019,
                Price = 10.2,
                Author = a
            };

            Book b2 = new Book
            {
                Name = "A doua carte",
                Year = 2020,
                Price = 15,
                Author = a
            };

            b1.Print();

            b2.Print();
        }
    }
}
