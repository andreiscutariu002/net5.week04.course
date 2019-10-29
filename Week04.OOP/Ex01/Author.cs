namespace Ex01
{
    public class Author
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"Author: {Name}, {Email}, {Country}");
        }
    }
}