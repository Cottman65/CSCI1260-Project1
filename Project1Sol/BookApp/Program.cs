using Project1Lib;

MainMenu();

bool showMenu = true;
while (showMenu) // if showmenu = true will display main menu after each method. See switches for more
{
    showMenu = MainMenu();
}

static bool MainMenu() // method containing code for the main menu
{
    TaxRate bookTax = new TaxRate();
    Book book1 = new Book(bookTax) { Title = "Science", Cost = 10 };
    Book book2 = new Book(bookTax) { Title = "Math", Cost = 10 };
    Book book3 = new Book(bookTax) { Title = "History", Cost = 10 };

    Console.WriteLine("1 - Enter the details about book 1");
    Console.WriteLine("2 - Enter the details about book 2");
    Console.WriteLine("3 - Enter the details about book 3");
    Console.WriteLine("4 - Remove book 1 details");
    Console.WriteLine("5 - Remove book 2 details");
    Console.WriteLine("6 - Remove book 3 details");
    Console.WriteLine("7 - Show all books");
    Console.WriteLine($"8 - Set the tax rate (current: {bookTax.Tax}%)");
    Console.WriteLine("9 - Exit");
    Console.Write("Please make a choice: ");

    int choice;
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice.ToString()) // methods are inside appropriate case, allowing for each to do its part in the program
    {
        case "1":
            EnterBookOneDetails(book1, bookTax);
            return true;

        case "2":
            EnterBookTwoDetails(book2, bookTax);
            return true;

        case "3":
            EnterBookThreeDetails(book3, bookTax);
            return true;

        case "4":
            RemoveBookOneDetails(book1, bookTax);
            Console.WriteLine();
            Console.Write("Press enter to return to the main menu ");
            Console.ReadLine();
            return true;

        case "5":
            RemoveBookOneDetails(book2, bookTax);
            Console.WriteLine();
            Console.Write("Press enter to return to the main menu ");
            Console.ReadLine();
            return true;

        case "6":
            RemoveBookOneDetails(book3, bookTax);
            Console.WriteLine();
            Console.Write("Press enter to return to the main menu ");
            Console.ReadLine();
            return true;

        case "7":
            ShowAllBooks(book1, book2, book3, bookTax);
            Console.WriteLine();
            Console.Write("Press enter to return to the main menu ");
            Console.ReadLine();
            return true;

        case "8":
            ChangeTaxRate(bookTax);
            Console.WriteLine();
            return true;

        case "9":
            return false;

        default:
            while (choice < 1 || choice > 9)
            {
                if (choice < 1 || choice > 9)
                {
                    Console.WriteLine("Only choices from 1 to 9 are available!");
                    Console.WriteLine();
                }
                MainMenu();
            }
            return true;
    }
}


static void ShowAllBooks(Book book1, Book book2, Book book3, TaxRate bookTax) // shows all books instantiated in application
{
    Console.WriteLine($"There are 3 books");
    Console.WriteLine($"Book 1: {book1.Title}, ${book1.Cost}");
    Console.WriteLine($"Book 2: {book2.Title}, ${book2.Cost}");
    Console.WriteLine($"Book 3: {book3.Title}, ${book3.Cost}");
    Console.WriteLine($"Tax rate: 10%");
    Console.WriteLine();
    decimal totalCost = book1.Cost + book2.Cost + book3.Cost;
    Console.WriteLine($"Total cost: ${totalCost}");
    decimal totalTax = totalCost * bookTax.Tax;
    Console.WriteLine($"Total tax: ${totalTax}");
    decimal totalCostWithTax = totalCost + totalTax;
    Console.WriteLine($"Total cost + tax: ${totalCostWithTax}");


}

static void EnterBookOneDetails(Book book1, TaxRate booktax) // These next 3 methods allow the user to enter book details 
{
    Console.Write("Enter the book title: ");
    book1.Title = Console.ReadLine();

    while(book1.Title == "")
    {
        if(book1.Title == "")
        {
            Console.WriteLine("Title cannot be blank!");
        }
        Console.Write("Enter the book title: ");
        book1.Title = Console.ReadLine();
    }

    Console.Write("Enter the book cost: ");
    book1.Cost = Convert.ToDecimal(Console.ReadLine());

    while(book1.Cost < 0M || book1.Cost > 9999M)
    {
        if(book1.Cost < 0M || book1.Cost > 9999M)
        {
            Console.WriteLine("Cost must be between 0 and 9999!");
        }
        Console.Write("Enter the book cost: ");
        book1.Cost = Convert.ToDecimal(Console.ReadLine());
    }

}

static void EnterBookTwoDetails(Book book2, TaxRate bookTax)
{
    Console.Write("Enter the book title: ");
    book2.Title = Console.ReadLine();

    while (book2.Title == "")
    {
        if (book2.Title == "")
        {
            Console.WriteLine("Title cannot be blank!");
        }
        Console.Write("Enter the book title: ");
        book2.Title = Console.ReadLine();
    }

    Console.Write("Enter the book cost: ");
    book2.Cost = Convert.ToDecimal(Console.ReadLine());

    while (book2.Cost < 0M || book2.Cost > 9999M)
    {
        if (book2.Cost < 0M || book2.Cost > 9999M)
        {
            Console.WriteLine("Cost must be between 0 and 9999!");
        }
        Console.Write("Enter the book cost: ");
        book2.Cost = Convert.ToDecimal(Console.ReadLine());
    }
}

static void EnterBookThreeDetails(Book book3, TaxRate bookTax)
{
    Console.Write("Enter the book title: ");
    book3.Title = Console.ReadLine();

    while (book3.Title == "")
    {
        if (book3.Title == "")
        {
            Console.WriteLine("Title cannot be blank!");
        }
        Console.Write("Enter the book title: ");
        book3.Title = Console.ReadLine();
    }

    Console.Write("Enter the book cost: ");
    book3.Cost = Convert.ToDecimal(Console.ReadLine());

    while (book3.Cost < 0M || book3.Cost > 9999M)
    {
        if (book3.Cost < 0M || book3.Cost > 9999M)
        {
            Console.WriteLine("Cost must be between 0 and 9999!");
        }
        Console.Write("Enter the book cost: ");
        book3.Cost = Convert.ToDecimal(Console.ReadLine());
    }
}

static void RemoveBookOneDetails(Book book1, TaxRate bookTax) // these next 3 methods allow the user to remove book details
{
    Console.WriteLine($"You are removing '{book1.Title}', ${book1.Cost}");
    Console.Write("Press 'Y' to remove or 'N' to not remove: " );
    string answer = Console.ReadLine();
    if(answer == "y")
    {
        book1.Title = String.Empty;
        book1.Cost = 0;
        Console.WriteLine("The book was removed.");
    }
    else
    {
        Console.WriteLine("The book was not removed.");
    }
            

}

static void RemoveBookTwoDetails(Book book2, TaxRate bookTax)
{
    Console.WriteLine($"You are removing '{book2.Title}', ${book2.Cost}");
    Console.Write("Press 'Y' to remove or 'N' to not remove: ");
    string answer = Console.ReadLine();
    if (answer == "y")
    {
        book2.Title = String.Empty;
        book2.Cost = 0;
        Console.WriteLine("The book was removed.");
    }
    else
    {
        Console.WriteLine("The book was not removed.");
    }


}

static void RemoveBookThreeDetails(Book book3, TaxRate bookTax)
{
    Console.WriteLine($"You are removing '{book3.Title}', ${book3.Cost}");
    Console.Write("Press 'Y' to remove or 'N' to not remove: ");
    string answer = Console.ReadLine();
    if (answer == "y")
    {
        book3.Title = String.Empty;
        book3.Cost = 0;
        Console.WriteLine("The book was removed.");
    }
    else
    {
        Console.WriteLine("The book was not removed.");
    }


}

static void ChangeTaxRate(TaxRate bookTax) // this methods allows the user to change the tax rate
{
    Console.WriteLine($"Current tax rate: $10%");
    Console.Write("Enter the new tax rate: ");
    bookTax.Tax = Convert.ToDecimal(Console.ReadLine());
    while(bookTax.Tax < 0.0M || bookTax.Tax > 1.0M)
    {
        if(bookTax.Tax < 0.0M || bookTax.Tax > 1.0M)
        {
            Console.WriteLine("Please enter a value from 0 to 1 inclusive!");
        }
        Console.Write("Enter the new tax rate: ");
        bookTax.Tax = Convert.ToDecimal(Console.ReadLine());
    }
    Console.WriteLine("The tax rate was changed.");
}

