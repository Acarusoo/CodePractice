using TelephoneBook.Model;
using TelephoneBook.View;

namespace TelephoneBook.Controll
{
    public class BookController
    {
        private Book book;
        private ConsoleView view;

        public BookController(Book book, ConsoleView view)
        {
            this.view = view;
            this.book = book;
        }

        public int Choice()
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
                return choice;
            return -1;
        }

        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                view.Menu();
                int choice = Choice();

                switch (choice)
                {
                    case 1:
                        var newContact = view.ShowAddContact();
                        book.AddContact(newContact);
                        view.ShowMessage("New contact ADDED");
                        break;

                    case 2:
                        var all = book.All();
                        view.ShowContacts(all);
                        break;

                    case 3:
                        view.ShowMessage("Insert Name or Surname: ");
                        var request = Console.ReadLine();
                        view.ShowContacts(book.Search(request));
                        break;

                    case 4:
                        view.ShowMessage("Insert Name or Surname: ");
                        var target = Console.ReadLine();
                        var deleted = book.DeleteContact(target, target);
                        view.ShowMessage(deleted ? "Contact deleted." : "Contact not found.");
                        break;

                    case 5:
                        exit = true;
                        break;

                    case 6:
                        view.ShowMessage("Not valid choice!");
                        break;
                }
            }

            view.ShowMessage("CLOSED");
        }
    }
}
