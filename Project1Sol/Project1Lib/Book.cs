namespace Project1Lib
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public decimal Cost { get; set; } = 0.0M;

        public Book() // no arg
        {

        }
        public Book(string title, decimal cost) // two arg constructor
        {
            Title = title;
            Cost = cost;
        }

        public Book(TaxRate tax) // setting up parameter injection
        {

        }

    }
}