using Base.Model;
using TelephoneBook.Controll;
using TelephoneBook.Model;
using TelephoneBook.View;

class Program
{
    private static readonly List<Contact> rubrica = new();

    static void Main()
    { 
        Book book = new Book();
        ConsoleView view = new ConsoleView();
        BookController controller = new BookController(book,view);

        controller.Start();
    }
}